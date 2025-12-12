using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Core {
    internal class CurrentUser
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string DisplayName { get; set; }
        public static string AvatarPath { get; set; }
    }
}
