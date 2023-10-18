using MyFirstWinFormsProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmMemoryGame : Form
    {
        public frmMemoryGame()
        {
            InitializeComponent();
        }

        private byte NumberOfSec = 61;
        private byte NumberOfMoves = 0;
        private byte NumberOfWins = 0;
        private byte Counter = 0;

        private void CheckTwoPictuers()
        {
            if (pictureBox1.Tag.ToString() == "?" || pictureBox7.Tag.ToString() == "?") 
            {
                pictureBox1.Image = Resources.Question_mark;
                pictureBox7.Image = Resources.Question_mark;
                pictureBox1.Tag = "?";
                pictureBox7.Tag = "?";
            }

            else
            {
                if (pictureBox1.Tag.ToString() == "Corn")
                {
                    NumberOfWins++;
                    pictureBox1.Tag = "!";
                }
            }

            if (pictureBox2.Tag.ToString() == "?" || pictureBox10.Tag.ToString() == "?")
            {
                pictureBox2.Image = Resources.Question_mark;
                pictureBox10.Image = Resources.Question_mark;
                pictureBox2.Tag = "?";
                pictureBox10.Tag = "?";
            }

            else
            {
                if (pictureBox2.Tag.ToString() == "Kiwi")
                {
                    NumberOfWins++;
                    pictureBox2.Tag = "!";
                }
            }

            if (pictureBox3.Tag.ToString() == "?" || pictureBox9.Tag.ToString() == "?")
            {
                pictureBox3.Image = Resources.Question_mark;
                pictureBox9.Image = Resources.Question_mark;
                pictureBox3.Tag = "?";
                pictureBox9.Tag = "?";
            }

            else
            {
                if (pictureBox3.Tag.ToString() == "Watermelon")
                {
                    NumberOfWins++;
                    pictureBox3.Tag = "!";
                }
            }

            if (pictureBox4.Tag.ToString() == "?" || pictureBox11.Tag.ToString() == "?")
            {
                pictureBox4.Image = Resources.Question_mark;
                pictureBox11.Image = Resources.Question_mark;
                pictureBox4.Tag = "?";
                pictureBox11.Tag = "?";
            }

            else
            {
                if (pictureBox4.Tag.ToString() == "Orange")
                {
                    NumberOfWins++;
                    pictureBox4.Tag = "!";
                }
            }

            if (pictureBox5.Tag.ToString() == "?" || pictureBox12.Tag.ToString() == "?")
            {
                pictureBox5.Image = Resources.Question_mark;
                pictureBox12.Image = Resources.Question_mark;
                pictureBox5.Tag = "?";
                pictureBox12.Tag = "?";
            }

            else
            {
                if (pictureBox5.Tag.ToString() == "Strawberry")
                {
                    NumberOfWins++;
                    pictureBox5.Tag = "!";
                }
            }

            if (pictureBox6.Tag.ToString() == "?" || pictureBox8.Tag.ToString() == "?")
            {
                pictureBox6.Image = Resources.Question_mark;
                pictureBox8.Image = Resources.Question_mark;
                pictureBox6.Tag = "?";
                pictureBox8.Tag = "?";
            }

            else
            {
                if (pictureBox6.Tag.ToString() == "Pear")
                {
                    NumberOfWins++;
                    pictureBox6.Tag = "!";
                }
            }

            VisableStare();
        }

        private void ResetPictureBox(PictureBox pictureBox)
        {
            pictureBox.Image = Resources.Question_mark;
            pictureBox.Tag = "?";
        }

        private void ResetGame()
        {
            ResetPictureBox(pictureBox1);
            ResetPictureBox(pictureBox2);
            ResetPictureBox(pictureBox3);
            ResetPictureBox(pictureBox4);
            ResetPictureBox(pictureBox5);
            ResetPictureBox(pictureBox6);
            ResetPictureBox(pictureBox7);
            ResetPictureBox(pictureBox8);
            ResetPictureBox(pictureBox9);
            ResetPictureBox(pictureBox10);
            ResetPictureBox(pictureBox11);
            ResetPictureBox(pictureBox12);

            NumberOfSec = 61;
            NumberOfMoves = 0;
            NumberOfWins = 0;
            Counter = 0;

            lblMoves.Text = "0";

            pbStar1.Visible = false;
            pbStar2.Visible = false;
            pbStar3.Visible = false;
            pbStar4.Visible = false;
            pbStar5.Visible = false;
            pbStar6.Visible = false;

            lblNumberOfMin.ForeColor = Color.White;
            lblNumberOfSec.ForeColor = Color.White;
            label5.ForeColor = Color.White;
        }

        private void VisableStare()
        {

            switch (NumberOfWins)
            {
                case 1:
                    pbStar1.Visible = true;
                    break;

                case 2:
                    pbStar2.Visible = true;
                    break;

                case 3:
                    pbStar3.Visible = true;
                    break;

                case 4:
                    pbStar4.Visible = true;
                    break;

                case 5:
                    pbStar5.Visible = true;
                    break;

                case 6:
                    pbStar6.Visible = true;
                    timer1.Stop();
                    timer2.Stop();

                    MessageBox.Show("Congratulations", "You Won", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    return;

            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (NumberOfSec > 10)
            {
                lblNumberOfSec.Text = (NumberOfSec - 1).ToString();

            }
            else
            {
                lblNumberOfMin.ForeColor = Color.Red;
                lblNumberOfSec.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                lblNumberOfSec.Text = "0" + (NumberOfSec - 1).ToString();
            }

            NumberOfSec--;
            lblMoves.Text = NumberOfMoves.ToString();


            if (NumberOfSec == 0)
            {
                timer1.Stop();   
                MessageBox.Show("Try Again", "You Lost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timer2.Stop();
                
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VisableStare();
            Counter++;
            NumberOfMoves++;
            pictureBox1.Image = Resources.corn;
            pictureBox1.Tag = "Corn";

            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Counter++;
            NumberOfMoves++;
            pictureBox2.Image = Resources.kiwi;
            pictureBox2.Tag = "Kiwi";

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Counter++;
            NumberOfMoves++;
            pictureBox3.Image = Resources.watermelon;
            pictureBox3.Tag = "Watermelon";

            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Counter++;
            NumberOfMoves++;
            pictureBox4.Image = Resources.orange;
            pictureBox4.Tag = "Orange";
           

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Counter++;
            NumberOfMoves++;
            pictureBox5.Image = Resources.strawberry;
            pictureBox5.Tag = "Strawberry";
            

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Counter++;
            NumberOfMoves++;
            pictureBox6.Image = Resources.pear;
            pictureBox6.Tag = "Pear";
            

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Counter++;
            NumberOfMoves++;
            pictureBox7.Image = Resources.corn;
            pictureBox7.Tag = "Corn";
            

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Counter++;
            NumberOfMoves++;
            pictureBox8.Image = Resources.pear;
            pictureBox8.Tag = "Pear";
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Counter++;
            NumberOfMoves++;
            pictureBox9.Image = Resources.watermelon;
            pictureBox9.Tag = "Watermelon";

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Counter++;
            NumberOfMoves++;
            pictureBox10.Image = Resources.kiwi;
            pictureBox10.Tag = "Kiwi";
            

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Counter++;
            NumberOfMoves++;
            pictureBox11.Image = Resources.orange;
            pictureBox11.Tag = "Orange";
            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Counter++;
            NumberOfMoves++;
            pictureBox12.Image = Resources.strawberry;
            pictureBox12.Tag = "Strawberry";
            
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.White;
        }
     
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Black;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Counter % 2 == 0)
            {
                CheckTwoPictuers();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
            timer1.Start();
            timer2.Start();
            
        }

        
    }
}
