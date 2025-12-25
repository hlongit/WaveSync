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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public LoginForm() {
            InitializeComponent();
        }
        public static class LoginSession
        {
            public static int UserID { get; set; }
            public static string Username { get; set; }
            public static string Password { get; set; } = string.Empty;
        }
        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
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
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi đăng nhập");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message);
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

        private void panelTab_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
