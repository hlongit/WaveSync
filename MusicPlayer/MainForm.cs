using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; 
namespace MusicPlayer {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            try {
                string connStr = System.Configuration.ConfigurationManager
                                 .ConnectionStrings["WaveSyncDB"].ConnectionString;

                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connStr)) {
                    conn.Open();
                    var cmd = new System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM Songs", conn);
                    int count = (int)cmd.ExecuteScalar();
                    MessageBox.Show($"Database connected! Songs in library: {count}", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
                    }
    }

}