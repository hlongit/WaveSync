using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MusicPlayer.Core;

namespace MusicPlayer.Forms
{
    public partial class UserSettingForm : Form
    {
        private readonly string avatarsFolder;

        public UserSettingForm()
        {
            InitializeComponent();

            // -------------------------------
            //  LẤY THƯ MỤC GỐC CỦA PROJECT
            // -------------------------------
            avatarsFolder = Path.Combine(
                Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName,
                "Avatars"
            );

            Directory.CreateDirectory(avatarsFolder);    // đảm bảo thư mục tồn tại

            // Load avatar
            string avatarFile;
            try { avatarFile = DatabaseHelper.GetActiveAvatar(CurrentUser.UserID); }
            catch { avatarFile = null; }

            LoadAvatarIntoBox(avatarFile);
        }

        // ============================================
        //            HÀM LOAD AVATAR
        // ============================================
        private void LoadAvatarIntoBox(string avatarFile)
        {
            string fullPath;

            if (string.IsNullOrWhiteSpace(avatarFile))
            {
                fullPath = Path.Combine(avatarsFolder, "default.png");
            }
            else
            {
                // avatarFile có thể là: "user1.png", "Avatars/user1.png", hoặc full path
                if (Path.IsPathRooted(avatarFile))
                {
                    fullPath = avatarFile;
                }
                else if (avatarFile.Contains("Avatars"))
                {
                    // Trường hợp database lưu "Avatars/user1.png"
                    fullPath = Path.Combine(
                        Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName,
                        avatarFile
                    );
                }
                else
                {
                    // Trường hợp DB chỉ lưu "user1.png"
                    fullPath = Path.Combine(avatarsFolder, avatarFile);
                }
            }

            // Fallback avatar
            if (!File.Exists(fullPath))
            {
                fullPath = Path.Combine(avatarsFolder, "default.png");
            }

            if (File.Exists(fullPath))
            {
                // Load ảnh không khóa file
                using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    AvatarBox.Image = Image.FromStream(stream);
                }
            }
        }

        // ============================================
        //               ĐỔI AVATAR
        // ============================================
        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images|*.png;*.jpg;*.jpeg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string newAvatarName = CurrentUser.Username + Path.GetExtension(dlg.FileName);
                string destPath = Path.Combine(avatarsFolder, newAvatarName);

                File.Copy(dlg.FileName, destPath, true);

                // Lưu vào DB chỉ tên file
                CurrentUser.AvatarPath = newAvatarName;
                DatabaseHelper.UpdateAvatar(CurrentUser.UserID, newAvatarName);

                MessageBox.Show("Avatar updated!");

                LoadAvatarIntoBox(newAvatarName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentUser.Username = txtUsername.Text;
            MessageBox.Show("Saved!");
        }
    }
}
