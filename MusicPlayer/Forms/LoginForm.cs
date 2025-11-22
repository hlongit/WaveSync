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

        private void guna2TileButton1_Click(object sender, EventArgs e) {
            using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnStr))
            {
                con.Open();

                string sql =
                    "SELECT UserId FROM Users WHERE Username=@u AND Password=@p";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@u", txtUser.Text);
                cmd.Parameters.AddWithValue("@p", txtPass.Text);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int userId = Convert.ToInt32(result);

                    AddMusicForm f = new AddMusicForm(userId);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai username hoặc password!");
                }
            }
        }
    }
}
