using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Core {
    public class CurrentUser {
    public static string AvatarPath { get; set; } = "";
    public static string Username { get; set; } = "";
    public static int UserID { get; set; } = -1;
    public void UpdateUser(string username, string avatarPath, int userID) {
        Username = username;
        AvatarPath = avatarPath;
        UserID = userID;
        }
    }
}
