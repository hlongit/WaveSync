using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TagLib;                    // For reading MP3 metadata (title, artist, album, cover)
using File = System.IO.File;   // Avoid conflict with TagLib.File

namespace MusicPlayer {
    /// <summary>
    /// Central helper class for all database + music file operations
    /// Handles: seeding users/songs, adding new songs from MP3 files, reading all songs
    /// </summary>
    public static class DatabaseHelper {
        
        // Root folder = where the .exe is (bin\Debug or installed location)
        private static readonly string BasePath = Application.StartupPath;

        private static readonly string MusicFolder = Path.Combine(BasePath, "Music"); //Music folder
        private static readonly string CoversFolder = Path.Combine(BasePath, "Covers"); //Covers folder

        // Connection string to LocalDB (set from App.config at app startup)
        public static string ConnStr { get; set; } 
        
        
        /// <summary>
        /// Adds fake users on first run if the Users table is empty
        /// Useful for testing/login demo
        /// </summary>
        public static void SeedFakeUsers()
        {
            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                // Check Program.cs if don't understand where ConnStr comes from
                con.Open();
        
                string check = "SELECT COUNT(*) FROM Users";
                SqlCommand cmdCheck = new SqlCommand(check, con);
        
                int count = (int)cmdCheck.ExecuteScalar();
        
                if (count == 0)
                {
                    string sql =
                    @"INSERT INTO Users (Username, Password) VALUES
                        ('admin', '123'),
                        ('test', '123'),
                        ('vinh', '12345');";
        
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Adds a song to the database by copying the MP3 + extracting metadata and cover
        /// Supports overriding title/artist/album, or falling back to file tags → filename
        /// </summary>
        public static void AddSongFromFile(string mp3Path, string coverPath = null,
                                   string overrideTitle = null,
                                   string overrideArtist = null,
                                   string overrideAlbum = null) 
        {
            try {
                // Read metadata using TagLib Sharp (best library for MP3/ID3 tags)
                var taglibFile = TagLib.File.Create(mp3Path);

                // Determine final title, artist, album (priority: override → tag → fallback)
                string title = !string.IsNullOrEmpty(overrideTitle) ? overrideTitle : (taglibFile.Tag.Title ?? Path.GetFileNameWithoutExtension(mp3Path));
                string artist = !string.IsNullOrEmpty(overrideArtist) ? overrideArtist : (taglibFile.Tag.FirstPerformer ?? taglibFile.Tag.FirstAlbumArtist ?? "Unknown Artist");
                string album = !string.IsNullOrEmpty(overrideAlbum) ? overrideAlbum : (taglibFile.Tag.Album ?? "Unknown Album");
                int duration = (int)taglibFile.Properties.Duration.TotalSeconds;

                // Ensure Music and Covers folders exist in the app directory bin\Debug or bin\Release
                Directory.CreateDirectory(MusicFolder);
                Directory.CreateDirectory(CoversFolder);

                // Randomly generate unique filenames to avoid conflicts, then create paths
                string newMp3Name = Guid.NewGuid() + ".mp3";
                string newCoverName = Guid.NewGuid() + ".jpg";

                string finalMp3Path = Path.Combine(MusicFolder, newMp3Name);
                string finalCoverPath = Path.Combine(CoversFolder, newCoverName);
                
                // Copy the actual MP3 file into our .\Music folder
                File.Copy(mp3Path, finalMp3Path, true);

                // Extract and save cover art
                if (!string.IsNullOrEmpty(coverPath) && File.Exists(coverPath)) {
                    File.Copy(coverPath, finalCoverPath, true);
                    //Use provided cover image file
                }
                else if (taglibFile.Tag.Pictures.Length > 0) {
                    var pic = taglibFile.Tag.Pictures[0];
                    File.WriteAllBytes(finalCoverPath, pic.Data.Data);
                    // Use embedded cover art from MP3 tags
                }
                else {
                    finalCoverPath = Path.Combine(CoversFolder, "null.png");
                    // No cover art available, use default null.png
                }

                // Store relative paths in the database
                string relativeMp3 = Path.Combine("Music", newMp3Name);
                string relativeCover = finalCoverPath.Contains("null.png") ? "Covers\\null.png" : Path.Combine("Covers", newCoverName);

                // Insert song record into the database
                using (SqlConnection conn = new SqlConnection(ConnStr)) {
                    conn.Open();
                    string sql = @"INSERT INTO Songs (Title, Artist, Album, DurationSeconds, FilePath, CoverPath)
                           VALUES (@Title, @Artist, @Album, @Duration, @FilePath, @CoverPath)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Artist", artist);
                        cmd.Parameters.AddWithValue("@Album", album);
                        cmd.Parameters.AddWithValue("@Duration", duration);
                        cmd.Parameters.AddWithValue("@FilePath", relativeMp3);
                        cmd.Parameters.AddWithValue("@CoverPath", relativeCover);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error adding song: " + ex.Message);
            }
        }
        public static void SeedFourTestSongsIfEmpty() {
            SqlConnection conn = new SqlConnection(ConnStr);
            conn.Open();

            if ((int)new SqlCommand("SELECT COUNT(*) FROM Songs", conn).ExecuteScalar() >= 4)
                return;

            new SqlCommand("DELETE FROM Songs", conn).ExecuteNonQuery();

            string basePath = Application.StartupPath;
            string testMusicPath = Path.Combine(basePath, "TestMusic");
            string testCoversPath = Path.Combine(basePath, "TestCovers");

            // Check if TestMusic exists and has MP3s
            if (!Directory.Exists(testMusicPath) || !Directory.EnumerateFiles(testMusicPath, "*.mp3").Any()) {
                MessageBox.Show("TestMusic folder not found or empty!", "Warning");
                return;
            }

            // Use a SPECIFIC default cover — predictable and safe
            string defaultCoverPath = Path.Combine(testCoversPath, "default.png");

            // If default.png doesn't exist → fall back to any image, or warn
            if (!File.Exists(defaultCoverPath)) {
                var anyImage = Directory.EnumerateFiles(testCoversPath, "*.*", SearchOption.TopDirectoryOnly)
                    .FirstOrDefault(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                         f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                         f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase));

                defaultCoverPath = anyImage ?? Path.Combine(basePath, "Covers", "null.png");
                // fallback to first image or null.png in app Covers folder
            }

            foreach (string mp3 in Directory.GetFiles(testMusicPath, "*.mp3").Take(4)) {
                string title = Path.GetFileNameWithoutExtension(mp3);

                AddSongFromFile(
                    mp3Path: mp3,
                    coverPath: defaultCoverPath,  // Always use the same predictable cover
                    overrideTitle: title,
                    overrideArtist: "Test Artist",
                    overrideAlbum: "Demo Album"
                );
            }

            //MessageBox.Show("4 test songs seeded successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Reads all songs from the database and returns as a list of Song objects
        public static List<Song> GetAllSongs() 
        {
            // This will hold all songs loaded from the database
            var songs = new List<Song>();

            // Create a connection to our LocalDB database (ConnStr was set in Program.cs)
            using (var conn = new SqlConnection(ConnStr)) {
                // Open the connection — required before running any query
                conn.Open();

                // SQL query: get ALL songs, sorted by title alphabetically
                string sql = @"
            SELECT SongId, Title, Artist, Album, DurationSeconds, FilePath, CoverPath
            FROM Songs
            ORDER BY Title";

                // Create a command to execute the SQL
                using (var cmd = new SqlCommand(sql, conn))

                // Execute the query and get a "reader" to go through results row by row
                using (var reader = cmd.ExecuteReader()) {
                    // Loop through every row in the Songs table
                    while (reader.Read()) {
                        // Create a new Song object and fill it with data from current row
                        songs.Add(new Song {
                            // Column 0 = SongId (int)
                            SongId = reader.GetInt32(0),
                            // Column 1 = Title (string)
                            Title = reader.GetString(1),
                            // Column 2 = Artist (string)
                            Artist = reader.GetString(2),
                            // Column 3 = Album (string)
                            Album = reader.GetString(3),
                            // Column 4 = Duration in seconds (int)
                            DurationSeconds = reader.GetInt32(4),
                            // Column 5 = FilePath like "Music/abc123.mp3" (string)
                            FilePath = reader.GetString(5),
                            // Column 6 = CoverPath (can be NULL in database!)
                            // If NULL → use default placeholder image
                            // Otherwise use the saved path
                            CoverPath = reader.IsDBNull(6) ? "Covers\\null.png" : reader.GetString(6)
                        });
                    }
                }
                // → reader, cmd, and conn are automatically closed and disposed here (thanks to 'using')
            }

            // Return the complete list of songs
            return songs;
        }
    }
}
