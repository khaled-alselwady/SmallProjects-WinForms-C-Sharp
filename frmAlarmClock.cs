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
    public partial class frmAlarmClock : Form
    {
        public frmAlarmClock()
        {
            InitializeComponent();
        }

        private byte NumberofHours = 0;
        private byte NumberofMinutes = 0;
        private byte NumberofSeconds = 0;
       

        private void frmAlarmClock_Load(object sender, EventArgs e)
        {
            timerSec.Enabled = true;
            timerMin.Enabled = true;
            timerHour.Enabled = true;
        }


        private void timerSec_Tick_1(object sender, EventArgs e)
        {
            byte NumberOfSec = (byte)DateTime.Now.Second;

            if (NumberOfSec < 10)
            {
                lblSec.Text = "0" + NumberOfSec.ToString();
                return;
            }

            lblSec.Text = NumberOfSec.ToString();

            
        }

        private void timerMin_Tick(object sender, EventArgs e)
        {
            byte NumberOfMin = (byte)DateTime.Now.Minute;

            if (NumberOfMin < 10)
            {
                lblMin.Text = "0" + NumberOfMin.ToString();
                return;
            }

            lblMin.Text = NumberOfMin.ToString();

            
        }

        private void timerHour_Tick(object sender, EventArgs e)
        {
            byte NumberOfHour = (byte)DateTime.Now.Hour;

            if (NumberOfHour > 12)
            {
                NumberOfHour -= 12;

                lblHour.Text = "0" + NumberOfHour.ToString();
                return;
            }

            lblHour.Text = NumberOfHour.ToString();

        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            TimerSet.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            NumberofHours = (byte)dateTimePicker1.Value.Hour;

            if (NumberofHours > 12)
            {
                NumberofHours -= 12;
            }

            NumberofMinutes = (byte)dateTimePicker1.Value.Minute;
            NumberofSeconds = (byte)dateTimePicker1.Value.Second;
        }

        private void TimerSet_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt16(lblSec.Text) == NumberofSeconds &&
                Convert.ToInt16(lblMin.Text) == NumberofMinutes &&
                Convert.ToInt16(lblHour.Text) == NumberofHours)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Alarm";
                notifyIcon1.BalloonTipText = "Wake Upppp!";
                notifyIcon1.ShowBalloonTip(1000);
                TimerSet.Enabled = false;
            }
        }
    }
}
