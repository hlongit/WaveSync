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
        /// <summary>
        /// Checks if SQL Server LocalDB is installed and accessible.
        /// </summary>
        private static bool CheckLocalDbInstalled() {
            try {
                // Try connecting to the generic LocalDB instance without attaching a specific DB file.
                // We set a short timeout (e.g., 5 seconds) so the app doesn't hang too long if it's missing.
                string checkConnectionString = "Server=(localdb)\\MSSQLLocalDB;Integrated Security=true;Connection Timeout=5;";

                using (var conn = new System.Data.SqlClient.SqlConnection(checkConnectionString)) {
                    conn.Open(); // If this succeeds, LocalDB is installed and running
                    return true;
                }
            }
            catch {
                return false; // Connection failed, implies LocalDB is missing or broken
            }
        }
        [STAThread]   // ← VERY IMPORTANT for WinForms!
        static void Main() {
            // Make the app look modern (buttons, text, etc. use current Windows theme)
            Application.EnableVisualStyles();

            // Fix text rendering in certain controls (legacy compatibility)
            // Must be called before any forms are created
            Application.SetCompatibleTextRenderingDefault(false);

            // --- FORCE LOCALDB INSTALLATION CHECK ---
            if (!CheckLocalDbInstalled()) {
                DialogResult result = MessageBox.Show(
                    "SQL Server LocalDB 2022 chưa được cài đặt.\n\n" +
                    "Ứng dụng này cần Microsoft LocalDB 2022 để chạy, bạn có muốn tải về và cài đặt không?",
                    "Thiếu SQL LocalDB 2022.",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error
                );

                if (result == DialogResult.Yes) {
                    // Opens the official Microsoft download page for SQL Server Express / LocalDB
                    System.Diagnostics.Process.Start("https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb");
                }

                // Force close the application so they cannot use it without the DB
                return;
            }

            // SUPER IMPORTANT for LocalDB + |DataDirectory| !
            // Tells .NET: "When you see |DataDirectory| in the connection string,
            // replace it with the folder where the .exe is located"
            AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);

            // Load the database connection string from App.config
            // ConnStr is set here so that DatabaseHelper can use it right away
            DatabaseHelper.ConnStr = ConfigurationManager.ConnectionStrings["WaveSyncDB"].ConnectionString;

            //Seed fake users if Users table is empty
            DatabaseHelper.SeedFakeUsersIfEmpty();

            // Finally, start the main window and run the message loop
            //Application.Run(new MainForm());
            Application.Run(new MainFormUI());
        }
    }
}