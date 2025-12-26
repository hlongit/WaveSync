using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MusicPlayer.Forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            guna2DragControl1.TargetControl = panelTab;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            string pass2 = txtPass2.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("All required information must be provided.");
                return;
            }

            if (pass != pass2)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnStr))
            {
                con.Open();

                // Kiểm tra xem username đã tồn tại?
                string checkSql = "SELECT COUNT(*) FROM Users WHERE Username=@u";
                SqlCommand checkCmd = new SqlCommand(checkSql, con);
                checkCmd.Parameters.AddWithValue("@u", user);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Username already exists.");
                    return;
                }

                // Thêm user mới
                string sql = "INSERT INTO Users (Username, Password) VALUES (@u, @p)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account created successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SignInForm_Load(object sender, EventArgs e)
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

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPass2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}

