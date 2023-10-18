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
    public partial class frmBilliardClub : Form
    {
        public frmBilliardClub()
        {
            InitializeComponent();
        }

        private byte[] NumberOfSec = new byte[10];
        private byte[] NumberOfMin = new byte[10];
        private float Price = 0f;
        
        private void GetPrice(Button btn)
        {
            Price = Convert.ToSingle(numericUpDown1.Value * Convert.ToDecimal(btn.Tag));

            MessageBox.Show("Game Over!" + Environment.NewLine + $"The price = {Price} $", "The Bill",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Price = 0f;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblNameTable1.Text))
            {
                lblNameTable1.Text = txtNamePlayer.Text;
                btnStartTable1.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(lblNameTable2.Text))
            {
                lblNameTable2.Text = txtNamePlayer.Text;
                btnStartTable2.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(lblNameTable3.Text))
            {
                lblNameTable3.Text = txtNamePlayer.Text;
                btnStartTable3.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(lblNameTable4.Text))
            {
                lblNameTable4.Text = txtNamePlayer.Text;
                btnStartTable4.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(lblNameTable5.Text))
            {
                lblNameTable5.Text = txtNamePlayer.Text;
                btnStartTable5.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(lblNameTable6.Text))
            {
                lblNameTable6.Text = txtNamePlayer.Text;
                btnStartTable6.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(lblNameTable7.Text))
            {
                lblNameTable7.Text = txtNamePlayer.Text;
                btnStartTable7.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(lblNameTable8.Text))
            {
                lblNameTable8.Text = txtNamePlayer.Text;
                btnStartTable8.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(lblNameTable9.Text))
            {
                lblNameTable9.Text = txtNamePlayer.Text;
                btnStartTable9.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(lblNameTable10.Text))
            {
                lblNameTable10.Text = txtNamePlayer.Text;
                btnStartTable10.Enabled = true;
                return;
            }

            else
            {
                MessageBox.Show("All Talbels are busy :-(", "Club Busy",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStartTable1_Click(object sender, EventArgs e)
        {

            if (btnStartTable1.Text == "Resume")
            {
                btnStartTable1.Text = "Start";
            }

            pbTable1.BackColor = Color.DarkGreen;
            timer1.Start();
            btnStartTable1.Enabled = false;
            btnPauseTable1.Enabled = true;
            btnEndTable1.Enabled = true;
            btnPauseTable1.Focus();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NumberOfSec[0]++;

            if (NumberOfSec[0] == 60)
            {
                NumberOfSec[0] = 0;
                NumberOfMin[0]++;
                btnEndTable1.Tag = NumberOfMin[0];
            }

            if (NumberOfSec[0] < 10)
            {
                if (NumberOfMin[0] < 10)
                {
                    lblTimeTable1.Text = "0" + NumberOfMin[0] + ":0" + NumberOfSec[0];
                }

                else
                {
                    lblTimeTable1.Text = NumberOfMin[0] + ":0" + NumberOfSec[0];
                }

            }
            else
            {
                if (NumberOfMin[0] < 10)
                {
                    lblTimeTable1.Text = "0" + NumberOfMin[0] + ":" + NumberOfSec[0];
                }
                else
                {
                    lblTimeTable1.Text = NumberOfMin[0] + ":" + NumberOfSec[0];
                }
            }


        }

        private void btnPauseTable1_Click(object sender, EventArgs e)
        {
            pbTable1.BackColor = Color.Yellow;
            btnStartTable1.Text = "Resume";
            btnStartTable1.Enabled = true;
            btnPauseTable1.Enabled = false;
            btnEndTable1.Enabled = true;
            timer1.Stop();
            btnStartTable1.Focus();
        }

        private void btnEndTable1_Click(object sender, EventArgs e)
        {
            pbTable1.BackColor = Color.Transparent;
            btnStartTable1.Text = "Start";
            btnStartTable1.Enabled = false;
            btnPauseTable1.Enabled = false;
            btnEndTable1.Enabled = false;
            lblNameTable1.Text = "";
            timer1.Stop();
            NumberOfSec[0] = 0;
            NumberOfMin[0] = 0;
            lblTimeTable1.Text = "00:00";

            GetPrice(((Button)sender));
        }

        private void btnStartTable2_Click(object sender, EventArgs e)
        {
            if (btnStartTable2.Text == "Resume")
            {
                btnStartTable2.Text = "Start";
            }

            pbTable2.BackColor = Color.DarkGreen;
            timer2.Start();
            btnStartTable2.Enabled = false;
            btnPauseTable2.Enabled = true;
            btnEndTable2.Enabled = true;
            btnPauseTable2.Focus();
        }

        private void btnPauseTable2_Click(object sender, EventArgs e)
        {
            pbTable2.BackColor = Color.Yellow;
            btnStartTable2.Text = "Resume";
            btnStartTable2.Enabled = true;
            btnPauseTable2.Enabled = false;
            btnEndTable2.Enabled = true;
            timer2.Stop();
            btnStartTable2.Focus();
        }

        private void btnEndTable2_Click(object sender, EventArgs e)
        {
            pbTable2.BackColor = Color.Transparent;
            btnStartTable2.Text = "Start";
            btnStartTable2.Enabled = false;
            btnPauseTable2.Enabled = false;
            btnEndTable2.Enabled = false;
            lblNameTable2.Text = "";
            timer2.Stop();
            NumberOfSec[1] = 0;
            NumberOfMin[1] = 0;
            lblTimeTable2.Text = "00:00";
            GetPrice(((Button)sender));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            NumberOfSec[1]++;

            if (NumberOfSec[1] == 60)
            {
                NumberOfSec[1] = 0;
                NumberOfMin[1]++;
                btnEndTable2.Tag = NumberOfMin[1];
            }

            if (NumberOfSec[1] < 10)
            {
                if (NumberOfMin[1] < 10)
                {
                    lblTimeTable2.Text = "0" + NumberOfMin[1] + ":0" + NumberOfSec[1];
                }

                else
                {
                    lblTimeTable2.Text = NumberOfMin[1] + ":0" + NumberOfSec[1];
                }

            }
            else
            {
                if (NumberOfMin[1] < 10)
                {
                    lblTimeTable2.Text = "0" + NumberOfMin[1] + ":" + NumberOfSec[1];
                }
                else
                {
                    lblTimeTable2.Text = NumberOfMin[1] + ":" + NumberOfSec[1];
                }
            }
        }

        private void btnStartTable3_Click(object sender, EventArgs e)
        {
            if (btnStartTable3.Text == "Resume")
            {
                btnStartTable3.Text = "Start";
            }

            pbTable3.BackColor = Color.DarkGreen;
            timer3.Start();
            btnStartTable3.Enabled = false;
            btnPauseTable3.Enabled = true;
            btnEndTable3.Enabled = true;
            btnPauseTable3.Focus();
        }

        private void btnPauseTable3_Click(object sender, EventArgs e)
        {
            pbTable3.BackColor = Color.Yellow;
            btnStartTable3.Text = "Resume";
            btnStartTable3.Enabled = true;
            btnPauseTable3.Enabled = false;
            btnEndTable3.Enabled = true;
            timer3.Stop();
            btnStartTable3.Focus();
        }

        private void btnEndTable3_Click(object sender, EventArgs e)
        {
            pbTable3.BackColor = Color.Transparent;
            btnStartTable3.Text = "Start";
            btnStartTable3.Enabled = false;
            btnPauseTable3.Enabled = false;
            btnEndTable3.Enabled = false;
            lblNameTable3.Text = "";
            timer3.Stop();
            NumberOfSec[2] = 0;
            NumberOfMin[2] = 0;
            lblTimeTable3.Text = "00:00";
            GetPrice(((Button)sender));
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            NumberOfSec[2]++;

            if (NumberOfSec[2] == 60)
            {
                NumberOfSec[2] = 0;
                NumberOfMin[2]++;
                btnEndTable3.Tag = NumberOfMin[2];
            }

            if (NumberOfSec[2] < 10)
            {
                if (NumberOfMin[2] < 10)
                {
                    lblTimeTable3.Text = "0" + NumberOfMin[2] + ":0" + NumberOfSec[2];
                }

                else
                {
                    lblTimeTable3.Text = NumberOfMin[2] + ":0" + NumberOfSec[2];
                }

            }
            else
            {
                if (NumberOfMin[2] < 10)
                {
                    lblTimeTable3.Text = "0" + NumberOfMin[2] + ":" + NumberOfSec[2];
                }
                else
                {
                    lblTimeTable3.Text = NumberOfMin[2] + ":" + NumberOfSec[2];
                }
            }
        }

        private void btnStartTable4_Click(object sender, EventArgs e)
        {
            if (btnStartTable4.Text == "Resume")
            {
                btnStartTable4.Text = "Start";
            }

            pbTable4.BackColor = Color.DarkGreen;
            timer4.Start();
            btnStartTable4.Enabled = false;
            btnPauseTable4.Enabled = true;
            btnEndTable4.Enabled = true;
            btnPauseTable4.Focus();
        }

        private void btnPauseTable4_Click(object sender, EventArgs e)
        {
            pbTable4.BackColor = Color.Yellow;
            btnStartTable4.Text = "Resume";
            btnStartTable4.Enabled = true;
            btnPauseTable4.Enabled = false;
            btnEndTable4.Enabled = true;
            timer4.Stop();
            btnStartTable4.Focus();
        }

        private void btnEndTable4_Click(object sender, EventArgs e)
        {
            pbTable4.BackColor = Color.Transparent;
            btnStartTable4.Text = "Start";
            btnStartTable4.Enabled = false;
            btnPauseTable4.Enabled = false;
            btnEndTable4.Enabled = false;
            lblNameTable4.Text = "";
            timer4.Stop();
            NumberOfSec[3] = 0;
            NumberOfMin[3] = 0;
            lblTimeTable4.Text = "00:00";
            GetPrice(((Button)sender));
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            NumberOfSec[3]++;

            if (NumberOfSec[3] == 60)
            {
                NumberOfSec[3] = 0;
                NumberOfMin[3]++;
                btnEndTable4.Tag = NumberOfMin[3];
            }

            if (NumberOfSec[3] < 10)
            {
                if (NumberOfMin[3] < 10)
                {
                    lblTimeTable4.Text = "0" + NumberOfMin[3] + ":0" + NumberOfSec[3];
                }

                else
                {
                    lblTimeTable4.Text = NumberOfMin[3] + ":0" + NumberOfSec[3];
                }

            }
            else
            {
                if (NumberOfMin[3] < 10)
                {
                    lblTimeTable4.Text = "0" + NumberOfMin[3] + ":" + NumberOfSec[3];
                }
                else
                {
                    lblTimeTable4.Text = NumberOfMin[3] + ":" + NumberOfSec[3];
                }
            }
        }

        private void btnStartTable5_Click(object sender, EventArgs e)
        {
            if (btnStartTable5.Text == "Resume")
            {
                btnStartTable5.Text = "Start";
            }

            pbTable5.BackColor = Color.DarkGreen;
            timer5.Start();
            btnStartTable5.Enabled = false;
            btnPauseTable5.Enabled = true;
            btnEndTable5.Enabled = true;
            btnPauseTable5.Focus();
        }

        private void btnPauseTable5_Click(object sender, EventArgs e)
        {
            pbTable5.BackColor = Color.Yellow;
            btnStartTable5.Text = "Resume";
            btnStartTable5.Enabled = true;
            btnPauseTable5.Enabled = false;
            btnEndTable5.Enabled = true;
            timer5.Stop();
            btnStartTable5.Focus();
        }

        private void btnEndTable5_Click(object sender, EventArgs e)
        {
            pbTable5.BackColor = Color.Transparent;
            btnStartTable5.Text = "Start";
            btnStartTable5.Enabled = false;
            btnPauseTable5.Enabled = false;
            btnEndTable5.Enabled = false;
            lblNameTable5.Text = "";
            timer5.Stop();
            NumberOfSec[4] = 0;
            NumberOfMin[4] = 0;
            lblTimeTable5.Text = "00:00";
            GetPrice(((Button)sender));
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            NumberOfSec[4]++;

            if (NumberOfSec[4] == 60)
            {
                NumberOfSec[4] = 0;
                NumberOfMin[4]++;
                btnEndTable5.Tag = NumberOfMin[4];
            }

            if (NumberOfSec[4] < 10)
            {
                if (NumberOfMin[4] < 10)
                {
                    lblTimeTable5.Text = "0" + NumberOfMin[4] + ":0" + NumberOfSec[4];
                }

                else
                {
                    lblTimeTable5.Text = NumberOfMin[4] + ":0" + NumberOfSec[4];
                }

            }
            else
            {
                if (NumberOfMin[4] < 10)
                {
                    lblTimeTable5.Text = "0" + NumberOfMin[4] + ":" + NumberOfSec[4];
                }
                else
                {
                    lblTimeTable5.Text = NumberOfMin[4] + ":" + NumberOfSec[4];
                }
            }
        }

        private void btnStartTable6_Click(object sender, EventArgs e)
        {
            if (btnStartTable6.Text == "Resume")
            {
                btnStartTable6.Text = "Start";
            }

            pbTable6.BackColor = Color.DarkGreen;
            timer6.Start();
            btnStartTable6.Enabled = false;
            btnPauseTable6.Enabled = true;
            btnEndTable6.Enabled = true;
            btnPauseTable6.Focus();
        }

        private void btnPauseTable6_Click(object sender, EventArgs e)
        {
            pbTable6.BackColor = Color.Yellow;
            btnStartTable6.Text = "Resume";
            btnStartTable6.Enabled = true;
            btnPauseTable6.Enabled = false;
            btnEndTable6.Enabled = true;
            timer6.Stop();
            btnStartTable6.Focus();
        }

        private void btnEndTable6_Click(object sender, EventArgs e)
        {
            pbTable6.BackColor = Color.Transparent;
            btnStartTable6.Text = "Start";
            btnStartTable6.Enabled = false;
            btnPauseTable6.Enabled = false;
            btnEndTable6.Enabled = false;
            lblNameTable6.Text = "";
            timer6.Stop();
            NumberOfSec[5] = 0;
            NumberOfMin[5] = 0;
            lblTimeTable6.Text = "00:00";
            GetPrice(((Button)sender));
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            NumberOfSec[5]++;

            if (NumberOfSec[5] == 60)
            {
                NumberOfSec[5] = 0;
                NumberOfMin[5]++;
                btnEndTable6.Tag = NumberOfMin[5];
            }

            if (NumberOfSec[5] < 10)
            {
                if (NumberOfMin[5] < 10)
                {
                    lblTimeTable6.Text = "0" + NumberOfMin[5] + ":0" + NumberOfSec[5];
                }

                else
                {
                    lblTimeTable6.Text = NumberOfMin[5] + ":0" + NumberOfSec[5];
                }

            }
            else
            {
                if (NumberOfMin[5] < 10)
                {
                    lblTimeTable6.Text = "0" + NumberOfMin[5] + ":" + NumberOfSec[5];
                }
                else
                {
                    lblTimeTable6.Text = NumberOfMin[5] + ":" + NumberOfSec[5];
                }
            }
        }

        private void btnStartTable7_Click(object sender, EventArgs e)
        {
            if (btnStartTable7.Text == "Resume")
            {
                btnStartTable7.Text = "Start";
            }

            pbTable7.BackColor = Color.DarkGreen;
            timer7.Start();
            btnStartTable7.Enabled = false;
            btnPauseTable7.Enabled = true;
            btnEndTable7.Enabled = true;
            btnPauseTable7.Focus();
        }

        private void btnPauseTable7_Click(object sender, EventArgs e)
        {
            pbTable7.BackColor = Color.Yellow;
            btnStartTable7.Text = "Resume";
            btnStartTable7.Enabled = true;
            btnPauseTable7.Enabled = false;
            btnEndTable7.Enabled = true;
            timer7.Stop();
            btnStartTable7.Focus();
        }

        private void btnEndTable7_Click(object sender, EventArgs e)
        {
            pbTable7.BackColor = Color.Transparent;
            btnStartTable7.Text = "Start";
            btnStartTable7.Enabled = false;
            btnPauseTable7.Enabled = false;
            btnEndTable7.Enabled = false;
            lblNameTable7.Text = "";
            timer7.Stop();
            NumberOfSec[6] = 0;
            NumberOfMin[6] = 0;
            lblTimeTable7.Text = "00:00";
            GetPrice(((Button)sender));
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            NumberOfSec[6]++;

            if (NumberOfSec[6] == 60)
            {
                NumberOfSec[6] = 0;
                NumberOfMin[6]++;
                btnEndTable7.Tag = NumberOfMin[6];
            }

            if (NumberOfSec[6] < 10)
            {
                if (NumberOfMin[6] < 10)
                {
                    lblTimeTable7.Text = "0" + NumberOfMin[6] + ":0" + NumberOfSec[6];
                }

                else
                {
                    lblTimeTable7.Text = NumberOfMin[6] + ":0" + NumberOfSec[6];
                }

            }
            else
            {
                if (NumberOfMin[6] < 10)
                {
                    lblTimeTable7.Text = "0" + NumberOfMin[6] + ":" + NumberOfSec[6];
                }
                else
                {
                    lblTimeTable7.Text = NumberOfMin[6] + ":" + NumberOfSec[6];
                }
            }
        }

        private void btnStartTable8_Click(object sender, EventArgs e)
        {
            if (btnStartTable8.Text == "Resume")
            {
                btnStartTable8.Text = "Start";
            }

            pbTable8.BackColor = Color.DarkGreen;
            timer8.Start();
            btnStartTable8.Enabled = false;
            btnPauseTable8.Enabled = true;
            btnEndTable8.Enabled = true;
            btnPauseTable8.Focus();
        }

        private void btnPauseTable8_Click(object sender, EventArgs e)
        {
            pbTable8.BackColor = Color.Yellow;
            btnStartTable8.Text = "Resume";
            btnStartTable8.Enabled = true;
            btnPauseTable8.Enabled = false;
            btnEndTable8.Enabled = true;
            timer8.Stop();
            btnStartTable8.Focus();
        }

        private void btnEndTable8_Click(object sender, EventArgs e)
        {
            pbTable8.BackColor = Color.Transparent;
            btnStartTable8.Text = "Start";
            btnStartTable8.Enabled = false;
            btnPauseTable8.Enabled = false;
            btnEndTable8.Enabled = false;
            lblNameTable8.Text = "";
            timer8.Stop();
            NumberOfSec[7] = 0;
            NumberOfMin[7] = 0;
            lblTimeTable8.Text = "00:00";
            GetPrice(((Button)sender));
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            NumberOfSec[7]++;

            if (NumberOfSec[7] == 60)
            {
                NumberOfSec[7] = 0;
                NumberOfMin[7]++;
                btnEndTable8.Tag = NumberOfMin[7];
            }

            if (NumberOfSec[7] < 10)
            {
                if (NumberOfMin[7] < 10)
                {
                    lblTimeTable8.Text = "0" + NumberOfMin[7] + ":0" + NumberOfSec[7];
                }

                else
                {
                    lblTimeTable8.Text = NumberOfMin[7] + ":0" + NumberOfSec[7];
                }

            }
            else
            {
                if (NumberOfMin[7] < 10)
                {
                    lblTimeTable8.Text = "0" + NumberOfMin[7] + ":" + NumberOfSec[7];
                }
                else
                {
                    lblTimeTable8.Text = NumberOfMin[7] + ":" + NumberOfSec[7];
                }
            }
        }

        private void btnStartTable9_Click(object sender, EventArgs e)
        {
            if (btnStartTable9.Text == "Resume")
            {
                btnStartTable9.Text = "Start";
            }

            pbTable9.BackColor = Color.DarkGreen;
            timer9.Start();
            btnStartTable9.Enabled = false;
            btnPauseTable9.Enabled = true;
            btnEndTable9.Enabled = true;
            btnPauseTable9.Focus();
        }

        private void btnPauseTable9_Click(object sender, EventArgs e)
        {
            pbTable9.BackColor = Color.Yellow;
            btnStartTable9.Text = "Resume";
            btnStartTable9.Enabled = true;
            btnPauseTable9.Enabled = false;
            btnEndTable9.Enabled = true;
            timer9.Stop();
            btnStartTable9.Focus();
        }

        private void btnEndTable9_Click(object sender, EventArgs e)
        {
            pbTable9.BackColor = Color.Transparent;
            btnStartTable9.Text = "Start";
            btnStartTable9.Enabled = false;
            btnPauseTable9.Enabled = false;
            btnEndTable9.Enabled = false;
            lblNameTable9.Text = "";
            timer9.Stop();
            NumberOfSec[8] = 0;
            NumberOfMin[8] = 0;
            lblTimeTable9.Text = "00:00";
            GetPrice(((Button)sender));
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            NumberOfSec[8]++;

            if (NumberOfSec[8] == 60)
            {
                NumberOfSec[8] = 0;
                NumberOfMin[8]++;
                btnEndTable9.Tag = NumberOfMin[8];
            }

            if (NumberOfSec[8] < 10)
            {
                if (NumberOfMin[8] < 10)
                {
                    lblTimeTable9.Text = "0" + NumberOfMin[8] + ":0" + NumberOfSec[8];
                }

                else
                {
                    lblTimeTable9.Text = NumberOfMin[8] + ":0" + NumberOfSec[8];
                }

            }
            else
            {
                if (NumberOfMin[8] < 10)
                {
                    lblTimeTable9.Text = "0" + NumberOfMin[8] + ":" + NumberOfSec[8];
                }
                else
                {
                    lblTimeTable9.Text = NumberOfMin[8] + ":" + NumberOfSec[8];
                }
            }
        }

        private void btnStartTable10_Click(object sender, EventArgs e)
        {
            if (btnStartTable10.Text == "Resume")
            {
                btnStartTable10.Text = "Start";
            }

            pbTable10.BackColor = Color.DarkGreen;
            timer10.Start();
            btnStartTable10.Enabled = false;
            btnPauseTable10.Enabled = true;
            btnEndTable10.Enabled = true;
            btnPauseTable10.Focus();
        }

        private void btnPauseTable10_Click(object sender, EventArgs e)
        {
            pbTable10.BackColor = Color.Yellow;
            btnStartTable10.Text = "Resume";
            btnStartTable10.Enabled = true;
            btnPauseTable10.Enabled = false;
            btnEndTable10.Enabled = true;
            timer10.Stop();
            btnStartTable10.Focus();
        }

        private void btnEndTable10_Click(object sender, EventArgs e)
        {
            pbTable10.BackColor = Color.Transparent;
            btnStartTable10.Text = "Start";
            btnStartTable10.Enabled = false;
            btnPauseTable10.Enabled = false;
            btnEndTable10.Enabled = false;
            lblNameTable10.Text = "";
            timer10.Stop();
            NumberOfSec[9] = 0;
            NumberOfMin[9] = 0;
            lblTimeTable10.Text = "00:00";
            GetPrice(((Button)sender));
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            NumberOfSec[9]++;

            if (NumberOfSec[9] == 60)
            {
                NumberOfSec[9] = 0;
                NumberOfMin[9]++;
                btnEndTable10.Tag = NumberOfMin[9];
            }

            if (NumberOfSec[9] < 10)
            {
                if (NumberOfMin[9] < 10)
                {
                    lblTimeTable10.Text = "0" + NumberOfMin[9] + ":0" + NumberOfSec[9];
                }

                else
                {
                    lblTimeTable10.Text = NumberOfMin[9] + ":0" + NumberOfSec[9];
                }

            }
            else
            {
                if (NumberOfMin[9] < 10)
                {
                    lblTimeTable10.Text = "0" + NumberOfMin[9] + ":" + NumberOfSec[9];
                }
                else
                {
                    lblTimeTable10.Text = NumberOfMin[9] + ":" + NumberOfSec[9];
                }
            }
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy  hh:mm:ss tt");
        }

        private void frmBilliardClub_Load(object sender, EventArgs e)
        {
            timerDateTime.Start();
        }
    }
}
