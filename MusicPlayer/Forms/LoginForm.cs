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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Drawing2D;


namespace MusicPlayer.Forms {
    public partial class LoginForm : Form {
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

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
