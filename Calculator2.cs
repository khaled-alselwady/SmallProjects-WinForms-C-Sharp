using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class Calculator2 : Form
    {
        public Calculator2()
        {
            InitializeComponent();
        }

        static double Number1 = 0, Number2 = 0;
        static string Op = "+";
        static bool NegativeNumber = false;

        double GetResult()
        {
           double Result = 0;

            switch (Op)
            {

                case "+":
                    {
                        Result = (Number1 + Number2);
                        break;
                    }

                case "-":
                    {
                        Result = (Number1 - Number2);
                        break;
                    }

                case "*":
                    {
                        Result = (Number1 * Number2);
                        break;
                    }

                case "/":
                    {
                        if (Number2 == 0)
                            Result = 0;

                        else
                            Result = (Number1 / Number2);

                        break;
                    }

                //case "%":
                //    {
                //        if (Number2 == 0)
                //            Result = 0;

                //        else
                //            Result = (Number1 % Number2);

                //        break;
                //    }



            }

            return Result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(Op))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

            Number1 = Convert.ToDouble(textBox1.Text);
            
            textBox1.Text += "+";
            Op = "+";
            NegativeNumber = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains(Op))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

            Number1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text += "-";
            Op = "-";
            NegativeNumber = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(Op))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

            Number1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text += "*";
            Op = "*";
            NegativeNumber = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1] != Convert.ToChar(Op))
            {
                Number2 = Convert.ToDouble(textBox1.Text.Substring((textBox1.Text.LastIndexOf(Op) + 1),
                    (textBox1.Text.Length - (textBox1.Text.LastIndexOf(Op) + 1))));

                if (NegativeNumber && Op == "-")
                {
                    Number2 *= -1;
                }


                if (Number2 == 0 && Op == "/") 
                {
                    textBox1.Text = "Error";
                }

                else
                {
                    textBox1.Text = Convert.ToString(GetResult());
                }
                
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Contains(Op))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

            Number1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text += "/";
            Op = "/";
            NegativeNumber = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Number1 = 0;
            Number2 = 0;
            Op = "+";
            NegativeNumber = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            NegativeNumber = true;

            if (!textBox1.Text.Contains(Op)) 
            {
                textBox1.Text= textBox1.Text.Insert(0, "-");
            }

            else
            {
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.IndexOf(Op) + 1, "-");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }
    }
}
