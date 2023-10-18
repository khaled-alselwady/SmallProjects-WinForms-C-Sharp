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
    public partial class frmAthkaar : Form
    {
        public frmAthkaar()
        {
            InitializeComponent();
        }


        private void btnMainEvening_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpEvening;
        }

        private void btnMainMorning_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpMorning;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            pictureBox1.BackColor = Color.Red;
            label6.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBox1.Tag.ToString() == "1")
            {
                button1.BackColor = Color.MediumSeaGreen;
                pictureBox1.BackColor = Color.MediumSeaGreen;
                label6.BackColor = Color.MediumSeaGreen;
            }

            else
            {
                button1.BackColor = Color.DodgerBlue;
                pictureBox1.BackColor = Color.DodgerBlue;
                label6.BackColor = Color.DodgerBlue;
            }
            
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            pictureBox2.BackColor = Color.Red;
            label7.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBox2.Tag.ToString() == "1")
            {
                button2.BackColor = Color.MediumSeaGreen;
                pictureBox2.BackColor = Color.MediumSeaGreen;
                label7.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                button2.BackColor = Color.DodgerBlue;
                pictureBox2.BackColor = Color.DodgerBlue;
                label7.BackColor = Color.DodgerBlue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "0" + (Convert.ToByte(button1.Tag) - 1).ToString();

            if (button1.Text == "00")
            {
                pictureBox1.Tag = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "00")
            {
                button2.Text = "0" + (Convert.ToByte(button2.Tag) - 1).ToString();
                button2.Tag = Convert.ToByte(button2.Tag) - 1;
            }

            else
            {
                pictureBox2.Tag = 0;
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
            label11.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBox3.Tag.ToString() == "1")
            {
                button3.BackColor = Color.MediumSeaGreen;
                pictureBox3.BackColor = Color.MediumSeaGreen;
                label11.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                button3.BackColor = Color.DodgerBlue;
                pictureBox3.BackColor = Color.DodgerBlue;
                label11.BackColor = Color.DodgerBlue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "00")
            {
                if (Convert.ToByte(button3.Tag) <= 10)
                {
                    button3.Text = "0" + (Convert.ToByte(button3.Tag) - 1).ToString();
                }
                else
                {
                    button3.Text = (Convert.ToByte(button3.Tag) - 1).ToString();

                }

                button3.Tag = Convert.ToByte(button3.Tag) - 1;
            }
            else
            {
                pictureBox3.Tag = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button1.Text = "0" + button1.Tag.ToString();
            pictureBox1.Tag = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button2.Tag = 3;
            button2.Text = "0" + button2.Tag.ToString();
            pictureBox2.Tag = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button3.Tag = 100;
            button3.Text = button3.Tag.ToString();
            pictureBox3.Tag = 1;
        }
    }
}
