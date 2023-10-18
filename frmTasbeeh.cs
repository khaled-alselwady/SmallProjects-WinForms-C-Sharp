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
    public partial class frmTasbeeh : Form
    {
        public frmTasbeeh()
        {
            InitializeComponent();
        }

        private ushort Counter = 0;
        private ushort Counter2 = 0;

        void ShowNotifyIcon()
        {
            string[] arrTasbeeh = { "سبحان الله","اللهم صل على سيدنا محمد", "لا حول ولا قوة الا بالله",
                "الحمد لله", "لا اله الا الله", "الله اكبر", "استغفر الله", };

            Random Rand = new Random();
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipText = arrTasbeeh[Rand.Next(0, 7)];
            notifyIcon1.ShowBalloonTip(1000);
        }

        void Clear()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            Counter2 = 0;
            Counter = 0;
            lblNumberOfSec.Text = "0";
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtNumberOfSec.Text != "")
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;

            if (Counter == Convert.ToInt16(txtNumberOfSec.Text))
            {
                ShowNotifyIcon();
                Counter = 0;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblNumberOfSec.ForeColor = default;
            Counter2++;
            lblNumberOfSec.Text = Counter2.ToString();

            if (Counter2 == Convert.ToInt16(txtNumberOfSec.Text))
            {
                lblNumberOfSec.ForeColor = Color.Red; 
                Counter2 = 0;
            }
        }

        private void txtNumberOfSec_TextChanged(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
