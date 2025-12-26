using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace MusicPlayer.Forms {
    public partial class LoginForm : Form {

        public LoginForm() {
            InitializeComponent();
            guna2DragControl1.TargetControl = panelTab;
        }
        public static class LoginSession
        {
            public static int UserID { get; set; }
            public static string Username { get; set; }
            public static string Password { get; set; } = string.Empty;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Both username and password are required.");
                return;
            }

            string sql = "SELECT UserId, Username FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnStr))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Gán thông tin người dùng vào LoginSession
                        LoginSession.UserID = Convert.ToInt32(reader["UserId"]);
                        LoginSession.Username = reader["Username"].ToString();

                        // Mở form chính và ẩn form đăng nhập
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Error.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during login: " + ex.Message);
                }
            }
        }
        public string UserName
        {
            get { return txtUser.Text; }
        }
        public int UserID
        {
            get { return LoginSession.UserID; }
        }
        public string Password
            {
            get { return txtPass.Text; }
        }

        private void LoginForm_Load(object sender, EventArgs e)
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

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
