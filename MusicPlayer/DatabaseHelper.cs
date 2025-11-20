using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TagLib;
using File = System.IO.File;

namespace MusicPlayer {
    public static class DatabaseHelper {
        private static string MusicFolder => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Music");
        private static string CoversFolder => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Covers");
        public static string ConnStr { get; set; }
        public static void SeedFakeUsers()
        {
            using (SqlConnection con = new SqlConnection(ConnStr))
            {
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
        public static void AddSongFromFile(string mp3Path, string coverPath = null,
                                   string overrideTitle = null,
                                   string overrideArtist = null,
                                   string overrideAlbum = null) 
        {
            try {
                var taglibFile = TagLib.File.Create(mp3Path);

                string title = !string.IsNullOrEmpty(overrideTitle) ? overrideTitle : (taglibFile.Tag.Title ?? Path.GetFileNameWithoutExtension(mp3Path));
                string artist = !string.IsNullOrEmpty(overrideArtist) ? overrideArtist : (taglibFile.Tag.FirstPerformer ?? taglibFile.Tag.FirstAlbumArtist ?? "Unknown Artist");
                string album = !string.IsNullOrEmpty(overrideAlbum) ? overrideAlbum : (taglibFile.Tag.Album ?? "Unknown Album");
                int duration = (int)taglibFile.Properties.Duration.TotalSeconds;

                // ←←← CORRECT FOLDERS (inside bin\Debug or bin\Release)
                Directory.CreateDirectory(MusicFolder);
                Directory.CreateDirectory(CoversFolder);

                string newMp3Name = Guid.NewGuid() + ".mp3";
                string newCoverName = Guid.NewGuid() + ".jpg";

                string finalMp3Path = Path.Combine(MusicFolder, newMp3Name);
                string finalCoverPath = Path.Combine(CoversFolder, newCoverName);

                File.Copy(mp3Path, finalMp3Path, true);

                if (!string.IsNullOrEmpty(coverPath) && File.Exists(coverPath)) {
                    File.Copy(coverPath, finalCoverPath, true);
                }
                else if (taglibFile.Tag.Pictures.Length > 0) {
                    var pic = taglibFile.Tag.Pictures[0];
                    File.WriteAllBytes(finalCoverPath, pic.Data.Data);
                }
                else {
                    finalCoverPath = Path.Combine(CoversFolder, "null.png");
                }

                string relativeMp3 = Path.Combine("Music", newMp3Name);
                string relativeCover = finalCoverPath.Contains("null.png") ? "Covers\\null.png" : Path.Combine("Covers", newCoverName);

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
        public static void SeedFourTestSongsIfEmpty() 
        {
            using (var conn = new SqlConnection(ConnStr)) {
                conn.Open();

                // Check if we already have songs
                var checkCmd = new SqlCommand("SELECT COUNT(*) FROM Songs", conn);
                int count = (int)checkCmd.ExecuteScalar();

                if (count >= 4) return; // already seeded → do nothing

                // Clear old ones just in case (optional)
                new SqlCommand("DELETE FROM Songs", conn).ExecuteNonQuery();

                Directory.CreateDirectory("Music");
                Directory.CreateDirectory("Covers");

                string[] testSongs = Directory.GetFiles("TestMusic", "*.mp3");
                string defaultCover = Directory.GetFiles("TestCovers")[0];

                int index = 1;
                foreach (string mp3 in testSongs.Take(4)) {
                    string newMp3 = Guid.NewGuid() + ".mp3";
                    string destMp3 = Path.Combine("Music", newMp3);
                    File.Copy(mp3, destMp3, true);

                    string newCover = Guid.NewGuid() + ".jpg";
                    string destCover = Path.Combine("Covers", newCover);
                    File.Copy(defaultCover, destCover, true);

                    // Use filename as title
                    string title = Path.GetFileNameWithoutExtension(mp3);

                    AddSongFromFile(
                        mp3Path: destMp3,
                        coverPath: destCover,
                        overrideTitle: title,
                        overrideArtist: "Test Artist",
                        overrideAlbum: "Demo Album"
                    );

                    index++;
                }
            }
        }
        public static List<Song> GetAllSongs() 
        {
            var songs = new List<Song>();

            using (var conn = new SqlConnection(ConnStr)) {
                conn.Open();
                string sql = @"
            SELECT SongId, Title, Artist, Album, DurationSeconds, FilePath, CoverPath 
            FROM Songs 
            ORDER BY Title";

                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        songs.Add(new Song {
                            SongId = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Artist = reader.GetString(2),
                            Album = reader.GetString(3),
                            DurationSeconds = reader.GetInt32(4),
                            FilePath = reader.GetString(5),
                            CoverPath = reader.IsDBNull(6) ? "Covers\\null.png" : reader.GetString(6)
                        });
                    }
                }
            }

            return songs;
        }
    }
}
