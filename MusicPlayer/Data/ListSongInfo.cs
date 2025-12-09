using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Data {
    public partial class ListSongInfo : Form {
        public ListSongInfo() {
            InitializeComponent();
        }

        // Load song info into DataGridView when form loads, using DatabaseHelper.getAllSongsDataTable(), differentiate it with GetAllSongs() which returns a List<Song>
        private void ListSongInfo_Load(object sender, EventArgs e) {
            dgvSongs.DataSource = DatabaseHelper.GetAllSongsDataTable();

            // Make it pretty
            dgvSongs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSongs.ReadOnly = true;
            dgvSongs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvSongs.BackgroundColor = Color.FromArgb(30, 30, 30);
            //dgvSongs.ForeColor = Color.White;
            //dgvSongs.GridColor = Color.FromArgb(60, 60, 60);
            //dgvSongs.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);

            dgvSongs.Columns["ID"].Width = 30;
            dgvSongs.Columns["Title"].Width = 150;
            dgvSongs.Columns["Duration (sec)"].Width = 70;
            // WRAP TEXT 
            if (dgvSongs.Columns["File Path"] != null) {
                dgvSongs.Columns["File Path"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvSongs.Columns["File Path"].Width = 300; // give it space
            }

            if (dgvSongs.Columns["Cover Path"] != null) {
                dgvSongs.Columns["Cover Path"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvSongs.Columns["Cover Path"].Width = 300;
            }

            // Make rows tall enough to show wrapped text
            dgvSongs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSongs.DefaultCellStyle.Padding = new Padding(5);
        }
    }
}