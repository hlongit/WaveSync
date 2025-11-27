using System;
using System.Data;
using System.Windows.Forms;

namespace MusicPlayer.Data
{
    public partial class PlayHistoryForm : Form
    {
        public PlayHistoryForm()
        {
            InitializeComponent();
        }

        private void PlayHistoryForm_Load(object sender, EventArgs e)
        {
            DataTable dt = DatabaseHelper.GetPlayHistoryDataTable();
            dgvHistory.DataSource = dt;

            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ReadOnly = true;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHistory.DefaultCellStyle.Padding = new Padding(5);

            // Tối ưu GUI
            SetColWidth("ID", 50);
            SetColWidth("Username", 130);
            SetColWidth("SongName", 200);
            SetColWidth("PlayTime", 200);

            SetWrap("SongPath", 100);
            SetWrap("CoverPath", 100);
        }

        private void SetColWidth(string col, int width)
        {
            if (dgvHistory.Columns[col] != null)
                dgvHistory.Columns[col].Width = width;
        }
        private void SetWrap(string col, int width)
        {
            if (dgvHistory.Columns[col] != null)
            {
                dgvHistory.Columns[col].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvHistory.Columns[col].Width = width;
            }
        }
    }
}
