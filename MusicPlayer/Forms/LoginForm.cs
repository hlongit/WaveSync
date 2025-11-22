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

namespace MusicPlayer.Forms {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnStr))
            {
                con.Open();

                string sql = "SELECT Username FROM Users WHERE Username=@u AND Password=@p";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@u", txtUser.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtPass.Text.Trim());

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    // Lưu Username để trả về MainForm
                    txtUser.Text = result.ToString();

                    // Trả về kết quả đăng nhập thành công
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai username hoặc password!");
                }
            }
        }


        public string UserName
        {
            get { return txtUser.Text; }
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
    }
}
