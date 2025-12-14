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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MusicPlayer.Forms
{
    public partial class ChangeNameForm : Form
    {
        public ChangeNameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseHelper.UpdateUsername(CurrentUser.UserID, textBox1.Text.Trim());
            CurrentUser.Username = textBox1.Text.Trim();
            MessageBox.Show("Username changed successfully!");
            this.Close();
        }
    }
}
