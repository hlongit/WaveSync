using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Forms {
    public partial class AddMusicForm : Form {
        private readonly int _userId;

        public AddMusicForm(int userId = 0) {
            InitializeComponent();
            _userId = userId; // currently not used for song adding (shared library), but kept if you want later
        }

        // Browse MP3
        private void MusicPathButton_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Filter = "MP3 Files (*.mp3)|*.mp3|All Files (*.*)|*.*";
                ofd.Title = "Select Music File";

                if (ofd.ShowDialog() == DialogResult.OK) {
                    txtPath.Text = ofd.FileName;

                    // Auto-fill from tags if fields are empty
                    try {
                        var tfile = TagLib.File.Create(ofd.FileName);

                        if (string.IsNullOrWhiteSpace(txtTitle.Text))
                            txtTitle.Text = tfile.Tag.Title ?? Path.GetFileNameWithoutExtension(ofd.FileName);

                        if (string.IsNullOrWhiteSpace(txtArtist.Text))
                            txtArtist.Text = tfile.Tag.FirstPerformer ?? tfile.Tag.FirstAlbumArtist ?? "Unknown Artist";

                        if (string.IsNullOrWhiteSpace(txtAlbum.Text))
                            txtAlbum.Text = tfile.Tag.Album ?? "Unknown Album";
                    }
                    catch {
                        // Ignore tag reading errors
                    }
                }
            }
        }

        // Browse Cover
        private void CoverPathButton_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select Cover Image (optional)";

                if (ofd.ShowDialog() == DialogResult.OK) {
                    CoverPath.Text = ofd.FileName;
                }
            }
        }

        // ADD SONG BUTTON (this is your old button1)
        private void button1_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtPath.Text) || !File.Exists(txtPath.Text)) {
                MessageBox.Show("Please select a valid MP3 file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Directory.CreateDirectory("Music");
            Directory.CreateDirectory("Covers");

            string coverToUse = null;
            if (!string.IsNullOrWhiteSpace(CoverPath.Text) && File.Exists(CoverPath.Text))
                coverToUse = CoverPath.Text;

            string manualTitle = string.IsNullOrWhiteSpace(txtTitle.Text) ? null : txtTitle.Text.Trim();
            string manualArtist = string.IsNullOrWhiteSpace(txtArtist.Text) ? null : txtArtist.Text.Trim();
            string manualAlbum = string.IsNullOrWhiteSpace(txtAlbum.Text) ? null : txtAlbum.Text.Trim();

            try {
                DatabaseHelper.AddSongFromFile(txtPath.Text, coverToUse, manualTitle, manualArtist, manualAlbum);

                MessageBox.Show("Song added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form
                txtTitle.Text = txtArtist.Text = txtAlbum.Text = txtPath.Text = CoverPath.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Cancel button (your old button or close)
        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Unused events — safe to leave empty
        private void label5_Click(object sender, EventArgs e) { }
    }
}