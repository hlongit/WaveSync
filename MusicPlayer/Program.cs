using System;
using System.Collections.Generic;
using System.Configuration;   // Needed to read App.config connection strings
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer {
    /// <summary>
    /// Application entry point — this is where your program starts!
    /// </summary>
    internal static class Program {
        [STAThread]   // ← VERY IMPORTANT for WinForms!
        static void Main() {
            // Make the app look modern (buttons, text, etc. use current Windows theme)
            Application.EnableVisualStyles();

            // Fix text rendering in certain controls (legacy compatibility)
            // Must be called before any forms are created
            Application.SetCompatibleTextRenderingDefault(false);

            // SUPER IMPORTANT for LocalDB + |DataDirectory| !
            // Tells .NET: "When you see |DataDirectory| in the connection string,
            // replace it with the folder where the .exe is located"
            AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);

            // Load the database connection string from App.config
            // ConnStr is set here so that DatabaseHelper can use it right away
            DatabaseHelper.ConnStr = ConfigurationManager.ConnectionStrings["WaveSyncDB"].ConnectionString;

            // Auto-fill the app with 4 demo songs if the Songs table is empty
            // Runs only once (or when < 4 songs exist)
            DatabaseHelper.SeedFourTestSongsIfEmpty();

            // Finally, start the main window and run the message loop
            Application.Run(new MainForm());
        }
    }
}