using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlayer.Core;

namespace MusicPlayer.Forms
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
            guna2DragControl1.TargetControl = panelTab;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                DatabaseHelper.UpdatePassword(CurrentUser.UserID, textBox1.Text.Trim());
                MessageBox.Show("Password changed successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error changing password.");
            }
        }

        private void guna2btnMinimizeToTray_Click(object sender, EventArgs e)
        {
            this.Hide();                   // Hides the form from the screen AND taskbar
            notifyIconApp.Visible = true;  // Show the icon in the system tray

            // Optional: Show a little popup bubble
            notifyIconApp.ShowBalloonTip(2000, "WaveSync", "Running in background", ToolTipIcon.Info);
        }
        private void notifyIconApp_Click(object sender, EventArgs e)
        {
            this.Show();                   // Bring form back
            this.WindowState = FormWindowState.Normal; // Ensure it's not minimized
            notifyIconApp.Visible = false; // Hide the tray icon again
        }

        private void guna2btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
