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
using MusicPlayer.Core;

namespace MusicPlayer.Forms
{
    public partial class UserSettingForm : Form
    {
        public UserSettingForm()
        {
            InitializeComponent();

            string avatarFile;
            try
            {
                avatarFile = DatabaseHelper.GetActiveAvatar(CurrentUser.UserID);
            }
            catch
            {
                avatarFile = null;
            }

            // Load into AvatarBox using helper that avoids file-locking and handles paths
            LoadAvatarIntoBox(avatarFile);
        }

        private void LoadAvatarIntoBox(string avatarFile)
        {
            string avatarPath;
            if (string.IsNullOrWhiteSpace(avatarFile))
            {
                avatarPath = Path.Combine(Application.StartupPath, "Avatars", "default.png");
            }
            else if (Path.IsPathRooted(avatarFile))
            {
                avatarPath = avatarFile;
            }
            else
            {
                // Some DB entries store only the filename (e.g. "user1.png")
                // or a relative path like "Avatars\\user1.png" — handle both.
                if (avatarFile.IndexOf("Avatars", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    avatarPath = Path.Combine(Application.StartupPath, avatarFile);
                }
                else
                {
                    avatarPath = Path.Combine(Application.StartupPath, "Avatars", avatarFile);
                }
            }

            // If file is missing, use default image (avoid throwing)
            if (File.Exists(avatarPath))
            {
                AvatarBox.Image = Image.FromFile(avatarPath);
            }
            else
            {
                // Use a bundled default or leave null
                string defaultPath = Path.Combine(Application.StartupPath, "Avatars", "default.png");
                AvatarBox.Image = File.Exists(defaultPath) ? Image.FromFile(defaultPath) : null;
            }
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images|*.png;*.jpg;*.jpeg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string newFile = Path.Combine("Avatars", CurrentUser.Username + ".png");
                File.Copy(dlg.FileName, newFile, true);

                // cập nhật database
                CurrentUser.AvatarPath = newFile;
                DatabaseHelper.UpdateAvatar(CurrentUser.UserID, newFile);
                MessageBox.Show("Avatar updated!");
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentUser.Username = txtUsername.Text;
        }
    }
}
