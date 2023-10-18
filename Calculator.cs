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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string PerformCalculator()
        {
            
            switch (textBox4.Text)
            {

                case "+":
                    {
                        label2.Text = Convert.ToString((Convert.ToDouble(textBox1.Text)
                            + Convert.ToDouble(textBox2.Text)));
                        break;
                    }

                case "-":
                    {
                        label2.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) 
                            - Convert.ToDouble(textBox2.Text)));
                        break;
                    }

                case "*":
                    {
                        label2.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) 
                            * Convert.ToDouble(textBox2.Text)));
                        break;
                    }

                case "/":
                    {

                        if (Convert.ToDouble(textBox2.Text) == 0)
                        {
                            label2.Text = "0";
                        }

                        else
                        {
                            label2.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) 
                                / Convert.ToDouble(textBox2.Text)));
                        }


                        break;
                    }

                case "%":
                    {
                        if (Convert.ToDouble(textBox2.Text) == 0)
                        {
                            label2.Text = textBox1.Text;
                        }
                        else
                        {
                            label2.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) 
                                % Convert.ToDouble(textBox2.Text)));
                        }

                        break;
                    }

            }

            return label2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "*";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = "%";

            
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = PerformCalculator();
        }

      
        private void btnRest_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label2.Text = "";
            textBox4.Text = "";
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            label4.ForeColor = Color.DarkTurquoise;
            label2.ForeColor = Color.DarkTurquoise;
            button6.FlatAppearance.MouseDownBackColor = Color.Red;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
