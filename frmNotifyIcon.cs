using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmNotifyIcon : Form
    {
        public frmNotifyIcon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.BalloonTipTitle = "This is a title";
            notifyIcon1.BalloonTipText = "This is a message";
            notifyIcon1.ShowBalloonTip(10000);
        }

      

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("BaloonTip Clicked");
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            MessageBox.Show("BaloonTip Closed");
        }
    }
}
