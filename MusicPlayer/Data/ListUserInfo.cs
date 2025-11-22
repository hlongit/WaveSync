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
    public partial class ListUserInfo : Form {
        public ListUserInfo() {
            InitializeComponent();
        }

        private void ListUserInfo_Load(object sender, EventArgs e) {
            dgvUsers.DataSource = DatabaseHelper.GetAllUsersDataTable();

            // Make it beautiful and readable
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvUsers.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvUsers.ForeColor = Color.Black;
            dgvUsers.GridColor = Color.FromArgb(60, 60, 60);
            //dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsers.DefaultCellStyle.Padding = new Padding(5);

            // Hide password column (security + clean look)
            if (dgvUsers.Columns["Password"] != null)
                dgvUsers.Columns["Password"].Visible = true;

            // Format CreatedAt as nice date
            if (dgvUsers.Columns["Created Date"] != null)
                dgvUsers.Columns["Created Date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            // Stylish header
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            //dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvUsers.EnableHeadersVisualStyles = false;
        }
    }
}
