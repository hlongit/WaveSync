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
    }
}
