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
    public partial class ListSongs : UserControl {
        public ListSongs() {
            InitializeComponent();
        }

        // This runs when the UserControl is added to the panel
        private void ListSongs_Load(object sender, EventArgs e) {
            RefreshData();
        }

        public void RefreshData() {
            dgvSongs.DataSource = DatabaseHelper.GetAllSongsDataTable();

            if (dgvSongs.Columns["ID"] != null) dgvSongs.Columns["ID"].Width = 40;
            if (dgvSongs.Columns["Duration (sec)"] != null) dgvSongs.Columns["Duration (sec)"].Width = 80;
        }
    }
}
