using MyFirstWinFormsProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmLoginScreenForThreeTimes : Form
    {
        public frmLoginScreenForThreeTimes()
        {
            InitializeComponent();
        }

        private byte NumberOfClick = 0;
        byte Counter = 30;

        void ShowNotifyIcon()
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "You are logged in" + Environment.NewLine 
                + DateTime.Now.ToString();
            notifyIcon1.BalloonTipTitle = "Login";
            notifyIcon1.ShowBalloonTip(1000);
        }

        void Clear()
        {
            lblYouHave.Visible = false;
            lblTriesLeft.Visible = false;
            lblNumberOfTrials.Visible = false;
            progressBar1.Visible = false;
            lblShowSecondsLeft.Visible = false;

            lblNumberOfTrials.Text = lblNumberOfTrials.Tag.ToString();
            Counter = 30;

            txtEmail.Text = "";
            txtPassword.Text = "";


            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
            btnLogin.Enabled = true;
            pbShowAndHidePassword.Enabled = true;
            pbShowAndHidePassword.Visible = false;

            NumberOfClick = 0;
        }

        bool CheckEmailAndPassword()
        {
            return (txtEmail.Text == txtEmail.Tag.ToString() &&
                txtPassword.Text == txtPassword.Tag.ToString());
        }

        void ShowProgressBar()
        {
            progressBar1.Visible = true;
            lblShowSecondsLeft.Visible = true;
            

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 125;
            progressBar1.Value = 125;

            for (ushort i = 1; i <= 80; i++)
            {

                if (progressBar1.Value > progressBar1.Minimum)
                {
                    Thread.Sleep(1000);

                    if (progressBar1.Value < 2)
                    {
                        return;
                    }

                    progressBar1.Value -= 4;

                    lblShowSecondsLeft.Text = Counter + "  Seconds Left";
                    Counter--;

                    progressBar1.Refresh();
                    lblShowSecondsLeft.Refresh();
    

                }

                else
                {
                    return;
                }

            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckEmailAndPassword())
            {
                lblYouHave.Visible = false;
                lblTriesLeft.Visible = false;
                lblNumberOfTrials.Visible = false;
                progressBar1.Visible = false;
                lblShowSecondsLeft.Visible = false;
                lblNumberOfTrials.Text = lblNumberOfTrials.Tag.ToString();
                Counter = 30;
                MessageBox.Show("Logged in successfully", "Success");

                ShowNotifyIcon();
            }

            else
            {
                if (Convert.ToSByte(lblNumberOfTrials.Text) <= 0)
                {
                    MessageBox.Show("Login Failed Three Time You Have To Wait 30 Seconed" +
                        " Before You Can Try Again!", "Login Failed");

                    lblNumberOfTrials.Text = (Convert.ToByte(lblNumberOfTrials.Text) + 1).ToString();
                    ShowProgressBar();
                    Clear();
                    return;
                }

                lblNumberOfTrials.Text = (Convert.ToByte(lblNumberOfTrials.Text) - 1).ToString();
                lblYouHave.Visible = true;
                lblTriesLeft.Visible = true;
                lblNumberOfTrials.Visible = true;
            }
        }

        
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                pbShowAndHidePassword.Visible = true;
            }

            else
            {
                pbShowAndHidePassword.Visible = false;
            }
        }

        private void pbShowAndHidePassword_Click(object sender, EventArgs e)
        {
            NumberOfClick++;

            if (NumberOfClick % 2 == 0) 
            {
                pbShowAndHidePassword.Image = Resources.HidePassword;
                txtPassword.PasswordChar = '*';
                return;
            }

            pbShowAndHidePassword.Image = Resources.ShowPassword;
            txtPassword.PasswordChar = default;

        }

        private void frmLoginScreenForThreeTimes_Load(object sender, EventArgs e)
        {
            timerSec.Start();
            timerMin.Start();
            timerHour.Start();
            lblDate.Text = DateTime.Today.ToString("MM-dd-yyyy");
        }

        private void timerSec_Tick(object sender, EventArgs e)
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
                lblAMorPM.Text = "PM";
                NumberOfHour -= 12;
            }

            else
            {
                lblAMorPM.Text = "AM";
            }

            if (NumberOfHour < 10)
            {
                lblHour.Text = "0" + NumberOfHour.ToString();
                return;
            }

            lblHour.Text = NumberOfHour.ToString();
        }
    }
}
