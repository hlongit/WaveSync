using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MusicPlayer;
using MusicPlayer.Core;
using MusicPlayer.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public partial class UserInfoControl : UserControl
{
    public string AvatarFolder = "Avatars";
    public string DefaultAvatar = "default.png";

    public UserInfoControl()
    {
        InitializeComponent();
        LoadUserInfo();
    }

    public void LoadUserInfo()
    {
        // For Guest User
        if (CurrentUser.UserID <= 0) {
            lblUsername.Text = "Guest";
            picAvatar.Image = Image.FromFile(Path.Combine(AvatarFolder, "default.png")); // Or null
            return;
        }

        //For Logged-in User
        string username = CurrentUser.Username;       
        string avatarPath = CurrentUser.AvatarPath;

        lblUsername.Text = username;

        string path = string.IsNullOrEmpty(avatarPath)
                        ? Path.Combine(AvatarFolder, DefaultAvatar)
                        : avatarPath;

        if (File.Exists(path))
            picAvatar.Image = Image.FromFile(path);
        else
            picAvatar.Image = Image.FromFile(Path.Combine(AvatarFolder, DefaultAvatar));
    }
    public void LoadAvatarIntoBox(string avatarFile)
    {
        string fullPath;

        if (string.IsNullOrWhiteSpace(avatarFile))
        {
            fullPath = Path.Combine(avatarFile, "default.png");
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
                fullPath = Path.Combine("Avatars", avatarFile);
            }
        }

        // Fallback avatar
        if (!File.Exists(fullPath))
        {
            fullPath = Path.Combine("Avatars", "default.png");
        }

        if (File.Exists(fullPath))
        {
            // Load ảnh không khóa file
            using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
            {
                picAvatar.Image = Image.FromStream(stream);
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
            string destPath = Path.Combine("Avatars", newAvatarName);

            File.Copy(dlg.FileName, destPath, true);

            // Lưu vào DB chỉ tên file
            CurrentUser.AvatarPath = newAvatarName;
            DatabaseHelper.UpdateAvatar(CurrentUser.UserID, newAvatarName);

            MessageBox.Show("Avatar updated!");

            LoadAvatarIntoBox(newAvatarName);
        }
    }
    private void btnChangeName_Click(object sender, EventArgs e)
    {
        var changeNameForm = new ChangeNameForm();
        changeNameForm.ShowDialog();
        lblUsername.Text = CurrentUser.Username;
    }
    private void btnChangePassword_Click(object sender, EventArgs e)
    {
        var changePasswordForm = new ChangePasswordForm();
        changePasswordForm.ShowDialog();
    }
}
