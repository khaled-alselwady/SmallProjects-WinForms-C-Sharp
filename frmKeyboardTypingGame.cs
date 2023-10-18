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
    public partial class frmKeyboardTypingGame : Form
    {
        public frmKeyboardTypingGame()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        enum enType { Characters, Numbers}
        enType Choice = enType.Characters;

        enum enLevel { Easy, Medium,Hard}
        enLevel Level = enLevel.Easy;

        private Random random = new Random();
        private int y = 0;
        private int x= 0;
        private byte CounterScore = 0;
        private string CopyScoreText = "";
        private bool OpenKeyDown = false;
        private byte NumberOfSec = 21;

        private void GetRandom()
        {
            y = 0;
            x = random.Next(0, panel1.ClientSize.Width - lblRandomKey.Width);
        
            if (Choice == enType.Characters)
            {
                byte SmallOrLCapital = (byte)random.Next(1, 3);
                if (SmallOrLCapital == 1)
                {
                    lblRandomKey.Text = ((char)random.Next(65, 90)).ToString();
                }
                else
                {
                    lblRandomKey.Text = ((char)random.Next(97, 122)).ToString();
                }

                OpenKeyDown = false;
            }
            else
            {
                lblRandomKey.Text = ((char)random.Next(49, 57)).ToString();
                OpenKeyDown = true;
            }

            switch(Level)
            {
                case enLevel.Easy:
                    timer1.Interval = 130;
                    break;

                case enLevel.Medium:
                    timer1.Interval = 70;
                    break;

                default:
                    timer1.Interval = 30;
                    break;
            }

            timer1.Start();
            timer2.Start();
        }

        private void Clear()
        {
            timer1.Stop();
            timer2.Stop();
            CounterScore = 0;
            CopyScoreText = "";
            OpenKeyDown = false;
            y = 0;
            x = 0;
            lblKeyboardPassed.Text = "";
            lblRandomKey.Text = "";
            lblScore.Text = "Score0";
            lblTimer.Text = "00:00";
            cboxLevel.Tag = 0;
            cboxType.Tag = 0;
            NumberOfSec = 21;
            lblTimer.ForeColor = Color.Black;
            cboxType.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRandomKey.Location = new Point(x, y);
            y += 5;

            if (y >= 326)
            {
                lblKeyboardPassed.BackColor = Color.Red;
                GetRandom();

                if (CounterScore != 0)
                {
                    CounterScore--;
                }

                lblScore.Text = CopyScoreText + CounterScore;
                lblScore.ForeColor = Color.Red;
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            CopyScoreText = lblScore.Text.Substring(0, lblScore.Text.Length - 1);
            lblKeyboardPassed.BackColor = Color.White;
            lblScore.ForeColor = Color.Black;

            if (cboxType.SelectedIndex == 0)
                Choice = enType.Characters;
            else
                Choice = enType.Numbers;

            switch(cboxLevel.SelectedIndex)
            {
                case 0:
                    Level = enLevel.Easy;
                    break;

                case 1:
                    Level = enLevel.Medium;
                    break;

                default:
                    Level = enLevel.Hard;
                    break;
            }

            if (cboxLevel.Tag.ToString() != "0" && cboxType.Tag.ToString() != "0") 
                GetRandom();
           
            
        }

        private void frmKeyboardTypingGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                if (char.IsUpper(e.KeyChar))
                {
                    lblKeyboardPassed.Text = "" + e.KeyChar;
                }
                else
                {
                    lblKeyboardPassed.Text = "" + char.ToLower(e.KeyChar);
                }

                if (cboxLevel.Tag.ToString() != "0" && cboxType.Tag.ToString() != "0")
                {
                    if (e.KeyChar == Convert.ToChar(lblRandomKey.Text))
                    {
                        lblKeyboardPassed.BackColor = Color.Green;
                        GetRandom();
                        CounterScore++;
                        lblScore.Text = CopyScoreText + CounterScore;
                        lblScore.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblKeyboardPassed.BackColor = Color.Red;
                        GetRandom();

                        if (CounterScore != 0)
                        {
                            CounterScore--;
                        }

                        lblScore.Text = CopyScoreText + CounterScore;
                        lblScore.ForeColor = Color.Red;
                    }
                }
               
                
            }

            
        }

        private void frmKeyboardTypingGame_KeyDown(object sender, KeyEventArgs e)
        {
           if (OpenKeyDown)
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                        lblKeyboardPassed.Text = "0";
                        break;

                    case Keys.D1:
                        lblKeyboardPassed.Text = "1";
                        break;

                    case Keys.D2:
                        lblKeyboardPassed.Text = "2";
                        break;

                    case Keys.D3:
                        lblKeyboardPassed.Text = "3";
                        break;

                    case Keys.D4:
                        lblKeyboardPassed.Text = "4";
                        break;

                    case Keys.D5:
                        lblKeyboardPassed.Text = "5";
                        break;

                    case Keys.D6:
                        lblKeyboardPassed.Text = "6";
                        break;

                    case Keys.D7:
                        lblKeyboardPassed.Text = "7";
                        break;

                    case Keys.D8:
                        lblKeyboardPassed.Text = "8";
                        break;

                    case Keys.D9:
                        lblKeyboardPassed.Text = "9";
                        break;
                }

                if (cboxLevel.Tag.ToString() != "0" && cboxType.Tag.ToString() != "0")
                {
                    if (lblKeyboardPassed.Text == lblRandomKey.Text)
                    {
                        lblKeyboardPassed.BackColor = Color.Green;
                        GetRandom();
                        CounterScore++;
                        lblScore.Text = CopyScoreText + CounterScore;
                        lblScore.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblKeyboardPassed.BackColor = Color.Red;
                        GetRandom();

                        if (CounterScore != 0)
                        {
                            CounterScore--;
                        }

                        lblScore.Text = CopyScoreText + CounterScore;
                        lblScore.ForeColor = Color.Red;
                    }
                }
                
            }
            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            NumberOfSec--;

            if (NumberOfSec < 10)
            {
                lblTimer.ForeColor = Color.Red;
                lblTimer.Text = "00:0" + NumberOfSec;
            }
            else
            {
                lblTimer.Text = "00:" + NumberOfSec;
            }

            if (NumberOfSec == 0)
            {
                timer2.Stop();
                timer1.Stop();
                MessageBox.Show("Times up!" + Environment.NewLine + $"Your Score is {CounterScore} ",
                    "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

        private void cboxType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboxType.Text))
            {
                e.Cancel = true;
                cboxType.Focus();
                errorProvider1.SetError(cboxType, "Choose Type");
                cboxType.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboxType, "");
                cboxType.Tag = 1;
            }
        }

        private void cboxLevel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboxLevel.Text))
            {
                e.Cancel = true;
                cboxLevel.Focus();
                errorProvider1.SetError(cboxLevel, "Choose Type");
                cboxLevel.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboxLevel, "");
                cboxLevel.Tag = 1;
            }
        }
    }
}
