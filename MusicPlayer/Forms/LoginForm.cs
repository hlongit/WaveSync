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
using MusicPlayer.Core;

namespace MusicPlayer.Forms {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
            // Drag Control
            guna2DragControl1.TargetControl = panelTab;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please input username and password!");
                return;
            }

            string sql = "SELECT UserId, AvatarPath FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnStr))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                // Only pass Username and Password (we are looking FOR the Id)
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    con.Open();

                    // Execute and Read
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // reader.Read() returns true if a row is found (Login Success)
                        if (reader.Read())
                        {
                            // GET DATA FROM DATABASE
                            int dbId = reader.GetInt32(0); // Index 0 is UserId
                            string dbAvatar = reader.IsDBNull(1) ? "" : reader.GetString(1); // Index 1 is AvatarPath

                            // UPDATE GLOBAL USER
                            CurrentUser.UserID = dbId;
                            CurrentUser.Username = username;
                            CurrentUser.Password = password;
                            CurrentUser.AvatarPath = dbAvatar;

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            // reader.Read() returned false (No user found)
                            MessageBox.Show("Wrong username or password!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception Error! " + ex.Message);
                }
            }
        }
        public string UserName
        {
            get { return txtUser.Text; }
        }
        public int UserID
        {
            get { return CurrentUser.UserID; }
        }
        public string Password
            {
            get { return txtPass.Text; }
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
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

        private void LoginForm_KeyDown(object sender, KeyEventArgs e) {
            //If enter, trigger login button click
            if (e.KeyCode == Keys.Enter) {
                btnRegister.PerformClick();
            }
        }

        
    }
}
