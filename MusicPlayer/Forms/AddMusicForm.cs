using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MusicPlayer.Forms {
    public partial class AddMusicForm : Form {
        int _userId;
        public AddMusicForm(int userId) {
            InitializeComponent();
            _userId = userId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "MP3 files|*.mp3";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnStr))
            {
                con.Open();

                string sql =
                @"INSERT INTO Music (Title, Artist, Album, FilePath, UserId)
                  VALUES (@t, @a, @al, @p, @uid)";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@t", txtTitle.Text);
                cmd.Parameters.AddWithValue("@a", txtArtist.Text);
                cmd.Parameters.AddWithValue("@al", txtAlbum.Text);
                cmd.Parameters.AddWithValue("@p", txtPath.Text);
                cmd.Parameters.AddWithValue("@uid", _userId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã thêm bài nhạc vào database!");
        }
    }
}
