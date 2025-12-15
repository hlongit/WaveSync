using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer.Data {
    partial class ListSongs {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSongs
            // 
            this.dgvSongs.AllowUserToAddRows = false;
            this.dgvSongs.AllowUserToDeleteRows = false;
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSongs.Location = new System.Drawing.Point(0, 0);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowHeadersWidth = 51;
            this.dgvSongs.Size = new System.Drawing.Size(800, 500);
            this.dgvSongs.TabIndex = 0;

            // Style the DataGridView to match your Dark Theme
            dgvSongs.BorderStyle = BorderStyle.None;
            dgvSongs.RowHeadersVisible = false; // Hide the ugly left selector column

            // Header Styles
            this.dgvSongs.EnableHeadersVisualStyles = false;
            this.dgvSongs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvSongs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 29, 29);
            this.dgvSongs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvSongs.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.dgvSongs.ColumnHeadersHeight = 40;

            // Row Styles
            //dgvSongs.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            this.dgvSongs.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvSongs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215); // Blue selection
            this.dgvSongs.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgvSongs.RowTemplate.Height = 35;

            // Column Sizing
            this.dgvSongs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // ListSongs (UserControl Properties)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSongs);
            this.Name = "ListSongs";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.ListSongs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSongs;
    }
}
