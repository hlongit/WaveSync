using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using TagLib;

namespace MusicPlayer {
    public static class DatabaseHelper {
        private static string ConnStr => ConfigurationManager.ConnectionStrings["WaveSyncDB"].ConnectionString;

        public static void AddSongFromFile(string mp3Path, string coverPath = null) {
            try {
                var taglibFile = TagLib.File.Create(mp3Path);

                string title = taglibFile.Tag.Title ?? Path.GetFileNameWithoutExtension(mp3Path);
                string artist = taglibFile.Tag.FirstPerformer ?? taglibFile.Tag.FirstAlbumArtist ?? "Unknown Artist";
                string album = taglibFile.Tag.Album ?? "Unknown Album";
                int duration = (int)taglibFile.Properties.Duration.TotalSeconds;

                // Copy MP3 and cover to project folders
                string newMp3Name = Guid.NewGuid() + ".mp3";
                string newCoverName = Guid.NewGuid() + ".jpg";
                string finalMp3Path = Path.Combine("Music", newMp3Name);
                string finalCoverPath = Path.Combine("Covers", newCoverName);

                System.IO.File.Copy(mp3Path, finalMp3Path, true);
                if (!string.IsNullOrEmpty(coverPath) && System.IO.File.Exists(coverPath))
                    System.IO.File.Copy(coverPath, finalCoverPath, true);
                else if (taglibFile.Tag.Pictures.Length > 0) {
                    var pic = taglibFile.Tag.Pictures[0];
                    System.IO.File.WriteAllBytes(finalCoverPath, pic.Data.Data);
                }

                // Insert into database
                using (SqlConnection conn = new SqlConnection(ConnStr)) {
                    conn.Open();
                    string sql = @"INSERT INTO Songs (Title, Artist, Album, DurationSeconds, FilePath, CoverPath)
                                   VALUES (@Title, @Artist, @Album, @Duration, @FilePath, @CoverPath)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Artist", artist);
                        cmd.Parameters.AddWithValue("@Album", album);
                        cmd.Parameters.AddWithValue("@Duration", duration);
                        cmd.Parameters.AddWithValue("@FilePath", finalMp3Path);
                        cmd.Parameters.AddWithValue("@CoverPath", finalCoverPath);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error adding song: " + ex.Message);
            }
        }
    }
}