using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace MusicPlayer.Forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            // Drag Control
            guna2DragControl1.TargetControl = panelTab;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user = guna2txtUser.Text.Trim();
            string pass = guna2txtPass.Text.Trim();
            string pass2 = guna2txtPass2.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please input necessary information!");
                return;
            }

            if (pass != pass2)
            {
                MessageBox.Show("2 passwords aren't matched!");
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
                    MessageBox.Show("Username already exists!");
                    return;
                }

                // Thêm user mới
                string sql = "INSERT INTO Users (Username, Password) VALUES (@u, @p)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Register Successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            
        }


        private void CenterContent()
        {
            panelContent.Left = (roundedPanelMain.Width - panelContent.Width) / 2;
            panelContent.Top = (roundedPanelMain.Height - panelContent.Height) / 2;
        }
        private void roundedPanelMain_Resize(object sender, EventArgs e)
        {
            CenterContent();
        }
        private void CenterPanel()
        {
            roundedPanelMain.Left = (this.ClientSize.Width - roundedPanelMain.Width) / 2;
            roundedPanelMain.Top = 100;
        }
        private void SignInForm_Shown(object sender, EventArgs e)
        {
            CenterPanel();
            CenterContent();
        }

        private void SignInForm_SizeChanged(object sender, EventArgs e)
        {
            CenterPanel();
            CenterContent();
        }

        private void guna2txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2txtUser_TextChanged(object sender, EventArgs e)
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
    }
}

