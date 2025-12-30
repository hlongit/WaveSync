using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MusicPlayer.Forms {
    public partial class AddMusicForm : Form {
        private readonly int _userId;

        public AddMusicForm(int userId = 0) {
            InitializeComponent();
            _userId = userId;
            //retain for future user-specific features
            // Drag Control
            guna2DragControl1.TargetControl = panelTab;
        }

        // Browse MP3
        private void MusicPathButton_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                //open a file dialog to select mp3 files
                ofd.Filter = "MP3 Files (*.mp3)|*.mp3|All Files (*.*)|*.*";
                ofd.Title = "Select Music File";
                
                if (ofd.ShowDialog() == DialogResult.OK) {
                    //If user selects a mp3 file successfully,
                    //set textbox to the file path
                    txtPath.Text = ofd.FileName;

                    // Auto-fill from tags if fields are empty
                    try {
                        // Use TagLib# to read tags
                        var tfile = TagLib.File.Create(ofd.FileName);

                        // Only fill remaining textbox if empty
                        // Usually Title, Artist, Album are stored in the tags
                        

                        if (string.IsNullOrWhiteSpace(txtTitle.Text))
                            //if tfile.Tag.Title is null, use file name without extension. 
                            // similar for txtArtist and txtAlbum below.
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
                //open a file dialog to select image files
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select Cover Image (optional)";

                if (ofd.ShowDialog() == DialogResult.OK) {
                    //set textbox to the file path
                    CoverPath.Text = ofd.FileName;
                }
            }
        }
        
        // ADD SONG BUTTON 
        private void btnAddMusic_Click(object sender, EventArgs e) {
            //If no valid mp3 file selected, show error
            if (string.IsNullOrWhiteSpace(txtPath.Text) || !File.Exists(txtPath.Text)) {
                MessageBox.Show("Please select a valid MP3 file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure directories exist
            Directory.CreateDirectory("Music");
            Directory.CreateDirectory("Covers");

            // Determine cover to use
            string coverToUse = null;
            if (!string.IsNullOrWhiteSpace(CoverPath.Text) && File.Exists(CoverPath.Text))
                coverToUse = CoverPath.Text;

            // Manual metadata entries
            string manualTitle = string.IsNullOrWhiteSpace(txtTitle.Text) ? null : txtTitle.Text.Trim();
            string manualArtist = string.IsNullOrWhiteSpace(txtArtist.Text) ? null : txtArtist.Text.Trim();
            string manualAlbum = string.IsNullOrWhiteSpace(txtAlbum.Text) ? null : txtAlbum.Text.Trim();

            // Add song to database using AddSongFromFile method from DatabaseHelper.cs 
            try {
                DatabaseHelper.AddSongFromFile(txtPath.Text, coverToUse, manualTitle, manualArtist, manualAlbum);

                MessageBox.Show("Song added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form for next entry
                txtTitle.Text = txtArtist.Text = txtAlbum.Text = txtPath.Text = CoverPath.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void guna2btnMinimizeToTray_Click(object sender, EventArgs e)
        {
            this.Hide();                   // Hides the form from the screen AND taskbar
            notifyIconApp.Visible = true;  // Show the icon in the system tray

            // Optional: Show a little popup bubble
            notifyIconApp.ShowBalloonTip(2000, "WaveSync", "Running in background", ToolTipIcon.Info);
        }
        private void notifyIconApp_Click(object sender, EventArgs e)
        {
            this.Show();                   // Bring form back
            this.WindowState = FormWindowState.Normal; // Ensure it's not minimized
            notifyIconApp.Visible = false; // Hide the tray icon again
        }

        private void guna2btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}