using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MusicPlayer.Core;
using MusicPlayer.Forms;

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
        string username = CurrentUser.Username;       // Lấy từ biến global
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

    private void btnSettings_Click(object sender, EventArgs e)
    {
        Form settings = new UserSettingForm();
        settings.ShowDialog();
    }
}
