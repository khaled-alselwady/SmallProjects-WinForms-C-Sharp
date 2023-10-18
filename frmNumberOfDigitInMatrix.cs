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
    public partial class frmNumberOfDigitInMatrix : Form
    {
        public frmNumberOfDigitInMatrix()
        {
            InitializeComponent();
        }

        Random RandomNumber = new Random();

        short[] arrNumbers = new short[36];
        void FillTheLabelNumber()
        {

            lbl1.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl2.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl3.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl4.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl5.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl6.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl7.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl8.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl9.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl10.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl11.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl12.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl13.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl14.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl15.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl16.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl17.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl18.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl19.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl20.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl21.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl22.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl23.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl24.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl25.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl26.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl27.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl28.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl29.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl30.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl31.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl32.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl33.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl34.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl35.Text = Convert.ToString(RandomNumber.Next(1, 10));
            lbl36.Text = Convert.ToString(RandomNumber.Next(1, 10));

            arrNumbers[0] = Convert.ToInt16(lbl1.Text);
            arrNumbers[1] = Convert.ToInt16(lbl2.Text);
            arrNumbers[2] = Convert.ToInt16(lbl3.Text);
            arrNumbers[3] = Convert.ToInt16(lbl4.Text);
            arrNumbers[4] = Convert.ToInt16(lbl5.Text);
            arrNumbers[5] = Convert.ToInt16(lbl6.Text);
            arrNumbers[6] = Convert.ToInt16(lbl7.Text);
            arrNumbers[7] = Convert.ToInt16(lbl8.Text);
            arrNumbers[8] = Convert.ToInt16(lbl9.Text);
            arrNumbers[9] = Convert.ToInt16(lbl10.Text);
            arrNumbers[10] = Convert.ToInt16(lbl11.Text);
            arrNumbers[11] = Convert.ToInt16(lbl12.Text);
            arrNumbers[12] = Convert.ToInt16(lbl13.Text);
            arrNumbers[13] = Convert.ToInt16(lbl14.Text);
            arrNumbers[14] = Convert.ToInt16(lbl15.Text);
            arrNumbers[15] = Convert.ToInt16(lbl16.Text);
            arrNumbers[16] = Convert.ToInt16(lbl17.Text);
            arrNumbers[17] = Convert.ToInt16(lbl18.Text);
            arrNumbers[18] = Convert.ToInt16(lbl19.Text);
            arrNumbers[19] = Convert.ToInt16(lbl20.Text);
            arrNumbers[20] = Convert.ToInt16(lbl21.Text);
            arrNumbers[21] = Convert.ToInt16(lbl22.Text);
            arrNumbers[22] = Convert.ToInt16(lbl23.Text);
            arrNumbers[23] = Convert.ToInt16(lbl24.Text);
            arrNumbers[24] = Convert.ToInt16(lbl25.Text);
            arrNumbers[25] = Convert.ToInt16(lbl26.Text);
            arrNumbers[26] = Convert.ToInt16(lbl27.Text);
            arrNumbers[27] = Convert.ToInt16(lbl28.Text);
            arrNumbers[28] = Convert.ToInt16(lbl29.Text);
            arrNumbers[29] = Convert.ToInt16(lbl30.Text);
            arrNumbers[30] = Convert.ToInt16(lbl31.Text);
            arrNumbers[31] = Convert.ToInt16(lbl32.Text);
            arrNumbers[32] = Convert.ToInt16(lbl33.Text);
            arrNumbers[33] = Convert.ToInt16(lbl34.Text);
            arrNumbers[34] = Convert.ToInt16(lbl35.Text);
            arrNumbers[35] = Convert.ToInt16(lbl36.Text);
        }

        byte RightAnswer()
        {
            byte Counter = 0;

            foreach (short sh in arrNumbers)
            {
                if (Convert.ToInt16(lblNumberToCheck.Text) == sh)
                {
                    Counter++;
                }
            }

            return Counter;
        }

        bool CheckNumberInMatrix()
        {
            if (RightAnswer() == Convert.ToInt16(txtAnswer.Text))
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        void PrintResult()
        {
            if (CheckNumberInMatrix())
            {
                lblWrongOrRight.Text = "Correct :-)";
                lblWrongOrRight.ForeColor = Color.Green;
            }
            
            else
            {
                
                lblWrongOrRight.Text = "Wrong";
                lblWrongOrRight.ForeColor = Color.Red;
                string s = "\a";
                Console.WriteLine(s+"\a");
            }
        }

        private void frmNumberOfDigitInMatrix_Load(object sender, EventArgs e)
        {
            lblNumberToCheck.Text = Convert.ToString(RandomNumber.Next(1, 10));
            
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblNumberToCheck.Text = Convert.ToString(RandomNumber.Next(1, 10));
            FillTheLabelNumber();
            txtAnswer.Text = "";
            lblWrongOrRight.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text != "")
            {
                PrintResult();
            }

        }
    }
}
