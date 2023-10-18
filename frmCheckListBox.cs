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
    public partial class frmCheckListBox : Form
    {
        public frmCheckListBox()
        {
            InitializeComponent();
        }

       

        void ShowNotifyIcon(string Title)
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Open Forms";
            notifyIcon1.BalloonTipText = Title;
            notifyIcon1.ShowBalloonTip(1000);

        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                if (checkedListBox1.CheckedItems[i].ToString() == ((Button)sender).Tag.ToString()) 
                {
                    MessageBox.Show("You can open this form :-)");
                    ShowNotifyIcon(((Button)sender).Tag.ToString());
                    return;
                }
            }

            MessageBox.Show("You can NOT open this form :-)");
        }


    }
}
