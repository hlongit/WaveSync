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

namespace MusicPlayer.Forms
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            string pass2 = txtPass2.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (pass != pass2)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
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
                    MessageBox.Show("Username đã tồn tại!");
                    return;
                }

                // Thêm user mới
                string sql = "INSERT INTO Users (Username, Password) VALUES (@u, @p)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Đăng ký thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

