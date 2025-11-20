using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseHelper.ConnStr = ConfigurationManager.ConnectionStrings["WaveSyncDB"].ConnectionString;
            DatabaseHelper.SeedFourTestSongsIfEmpty();
            AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);
            Application.Run(new MainForm());
        }
    }
}
