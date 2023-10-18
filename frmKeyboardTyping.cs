using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyFirstWinFormsProject
{
    public partial class frmKeyboardTyping : Form
    {
        public frmKeyboardTyping()
        {
            InitializeComponent();
        }


        string[] arrTexts = new string[1000];
        int i = 0;
        bool Stop = true;
        bool StartChallenge = false;
        double Correct = 0;
        double Error = 0;

        void ChangeColorBackSpace()
        {
            if ((i - 2) >= 0)
            {

                if (arrTexts[i - 2].Length > txtText.Text.Length)
                {
                    lblBackSpace.BackColor = Color.Red;
                    txtText.MaxLength += 10000;
                    Stop = false;

                }
                else
                {
                    lblBackSpace.BackColor = default;
                    Stop = true;
                }

            }
        }

        void ChangeColorKeyboard()
        {
            ChangeColorBackSpace();


            if ((txtText.Text.EndsWith("Q") || txtText.Text.EndsWith("q")) && Stop)
            {

                lblQ.BackColor = Color.Red;


            }
            else
            {
                lblQ.BackColor = default;
            }



            if ((txtText.Text.EndsWith("W") || txtText.Text.EndsWith("w")) && Stop)
            {

                lblW.BackColor = Color.Red;

            }
            else
            {
                lblW.BackColor = default;
            }



            if ((txtText.Text.EndsWith("E") || txtText.Text.EndsWith("e")) && Stop)
            {

                lblE.BackColor = Color.Red;

            }
            else
            {
                lblE.BackColor = default;
            }



            if ((txtText.Text.EndsWith("R") || txtText.Text.EndsWith("r")) && Stop)
            {
                lblR.BackColor = Color.Red;
            }
            else
            {
                lblR.BackColor = default;
            }



            if ((txtText.Text.EndsWith("T") || txtText.Text.EndsWith("t")) && Stop)
            {
                lblT.BackColor = Color.Red;
            }
            else
            {
                lblT.BackColor = default;
            }



            if ((txtText.Text.EndsWith("Y") || txtText.Text.EndsWith("y")) && Stop)
            {
                lblY.BackColor = Color.Red;
            }
            else
            {
                lblY.BackColor = default;
            }



            if ((txtText.Text.EndsWith("U") || txtText.Text.EndsWith("u")) && Stop)
            {
                lblU.BackColor = Color.Red;
            }
            else
            {
                lblU.BackColor = default;
            }



            if ((txtText.Text.EndsWith("I") || txtText.Text.EndsWith("i")) && Stop)
            {
                lblI.BackColor = Color.Red;
            }
            else
            {
                lblI.BackColor = default;
            }



            if ((txtText.Text.EndsWith("O") || txtText.Text.EndsWith("o")) && Stop)
            {
                lblO.BackColor = Color.Red;
            }
            else
            {
                lblO.BackColor = default;
            }



            if ((txtText.Text.EndsWith("P") || txtText.Text.EndsWith("p")) && Stop)
            {
                lblP.BackColor = Color.Red;
            }
            else
            {
                lblP.BackColor = default;
            }



            if ((txtText.Text.EndsWith("{") || txtText.Text.EndsWith("[")) && Stop)
            {
                lblSymbol1.BackColor = Color.Red;
            }
            else
            {
                lblSymbol1.BackColor = default;
            }



            if ((txtText.Text.EndsWith("}") || txtText.Text.EndsWith("]")) && Stop)
            {
                lblSymbol2.BackColor = Color.Red;
            }
            else
            {
                lblSymbol2.BackColor = default;
            }



            if ((txtText.Text.EndsWith("A") || txtText.Text.EndsWith("a")) && Stop)
            {
                lblA.BackColor = Color.Red;
            }
            else
            {
                lblA.BackColor = default;
            }



            if ((txtText.Text.EndsWith("S") || txtText.Text.EndsWith("s")) && Stop)
            {
                lblS.BackColor = Color.Red;
            }
            else
            {
                lblS.BackColor = default;
            }



            if ((txtText.Text.EndsWith("D") || txtText.Text.EndsWith("d")) && Stop)
            {
                lblD.BackColor = Color.Red;
            }
            else
            {
                lblD.BackColor = default;

            }



            if ((txtText.Text.EndsWith("F") || txtText.Text.EndsWith("f")) && Stop)
            {
                lblF.BackColor = Color.Red;
            }
            else
            {
                lblF.BackColor = default;

            }



            if ((txtText.Text.EndsWith("G") || txtText.Text.EndsWith("g")) && Stop)
            {
                lblG.BackColor = Color.Red;
            }
            else
            {
                lblG.BackColor = default;

            }



            if ((txtText.Text.EndsWith("H") || txtText.Text.EndsWith("h")) && Stop)
            {
                lblH.BackColor = Color.Red;
            }
            else
            {
                lblH.BackColor = default;

            }



            if ((txtText.Text.EndsWith("J") || txtText.Text.EndsWith("j")) && Stop)
            {
                lblJ.BackColor = Color.Red;
            }
            else
            {
                lblJ.BackColor = default;

            }



            if ((txtText.Text.EndsWith("K") || txtText.Text.EndsWith("k")) && Stop)
            {
                lblK.BackColor = Color.Red;
            }
            else
            {
                lblK.BackColor = default;

            }



            if ((txtText.Text.EndsWith("L") || txtText.Text.EndsWith("l")) && Stop)
            {
                lblL.BackColor = Color.Red;
            }
            else
            {
                lblL.BackColor = default;

            }




            if ((txtText.Text.EndsWith(";") || txtText.Text.EndsWith(":")) && Stop)
            {
                lblSemeColon.BackColor = Color.Red;
            }
            else
            {
                lblSemeColon.BackColor = default;

            }



            if ((txtText.Text.EndsWith("\'") || txtText.Text.EndsWith("\"")) && Stop)
            {
                lblSingleQuetation.BackColor = Color.Red;
            }
            else
            {
                lblSingleQuetation.BackColor = default;

            }



            if ((txtText.Text.EndsWith("Z") || txtText.Text.EndsWith("z")) && Stop)
            {
                lblZ.BackColor = Color.Red;
            }
            else
            {
                lblZ.BackColor = default;

            }



            if ((txtText.Text.EndsWith("X") || txtText.Text.EndsWith("x")) && Stop)
            {
                lblX.BackColor = Color.Red;
            }
            else
            {
                lblX.BackColor = default;

            }



            if ((txtText.Text.EndsWith("C") || txtText.Text.EndsWith("c")) && Stop)
            {
                lblC.BackColor = Color.Red;
            }
            else
            {
                lblC.BackColor = default;

            }



            if ((txtText.Text.EndsWith("V") || txtText.Text.EndsWith("v")) && Stop)
            {
                lblV.BackColor = Color.Red;
            }
            else
            {
                lblV.BackColor = default;

            }



            if ((txtText.Text.EndsWith("B") || txtText.Text.EndsWith("b")) && Stop)
            {
                lblB.BackColor = Color.Red;
            }
            else
            {
                lblB.BackColor = default;

            }



            if ((txtText.Text.EndsWith("N") || txtText.Text.EndsWith("n")) && Stop)
            {
                lblN.BackColor = Color.Red;
            }
            else
            {
                lblN.BackColor = default;

            }



            if ((txtText.Text.EndsWith("M") || txtText.Text.EndsWith("m")) && Stop)
            {
                lblM.BackColor = Color.Red;
            }
            else
            {
                lblM.BackColor = default;

            }




            if ((txtText.Text.EndsWith(",") || txtText.Text.EndsWith("<")) && Stop)
            {
                lblComma.BackColor = Color.Red;
            }
            else
            {
                lblComma.BackColor = default;

            }



            if ((txtText.Text.EndsWith(".") || txtText.Text.EndsWith(">")) && Stop)
            {
                lblDot.BackColor = Color.Red;
            }
            else
            {
                lblDot.BackColor = default;

            }



            if ((txtText.Text.EndsWith("/") || txtText.Text.EndsWith("?")) && Stop)
            {
                lblSlash.BackColor = Color.Red;
            }
            else
            {
                lblSlash.BackColor = default;

            }



            if (txtText.Text.EndsWith(" ") && Stop)
            {
                lblSpace.BackColor = Color.Red;
            }
            else
            {
                lblSpace.BackColor = default;

            }

        }

        void Compare()
        {
            if ((txtText.Text.Length > 0) && (txtChallengeText.Text.Length >= txtText.Text.Length)) 
            {

                char LastCharInTextType = txtText.Text[txtText.Text.Length - 1];
                
                char FirstCharInChallengeText = txtChallengeText.Text[txtText.Text.Length - 1];

                if (LastCharInTextType != FirstCharInChallengeText)
                {
                    txtText.BackColor = Color.Red;
                    Error++;
                }
                else
                {
                    txtText.BackColor = default;
                    Correct++;
                }

                
            }
            
            
        }

        double GetAccuracy()
        {
            return Convert.ToDouble((Correct / (Correct + Error)) * 100);
        }

        void Reset()
        {
            txtChallengeText.ReadOnly = false;
            txtChallengeText.Enabled = true;
            txtChallengeText.Text = "";
            txtText.Text = "";
            StartChallenge = false;
            Error = 0;
            Correct = 0;
            i = 0;
            Stop = true;
            arrTexts = new string[1000];
            txtChallengeText.Cursor = Cursors.IBeam;
            txtText.MaxLength = 100000;
            txtText.BackColor = default;
            txtText.ReadOnly = false;
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            arrTexts[i] = txtText.Text;
            i++;
            
            ChangeColorKeyboard();

            if (StartChallenge) 
            {
                if (!(txtChallengeText.Text.Length >= txtText.Text.Length))
                {
                    txtText.Text = txtText.Text.Remove(txtText.Text.Length - 1, 1);

                    MessageBox.Show("You finshed the challenge text! Please enter on submit to show your result.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtText.ReadOnly = true;
                }

                Compare();
            }
            
        }

        private void btnAutofill_Click(object sender, EventArgs e)
        {
            txtChallengeText.Text = "ProgrammingAdvice.com is the best website ever for learning programming.";
        }

        private void btnStartChallenge_Click(object sender, EventArgs e)
        {
            if (txtChallengeText.Text == "")
            {
                MessageBox.Show("Please enter a text or press on Autofill.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                txtText.Text = "";
                txtChallengeText.ReadOnly = true;
                txtChallengeText.Cursor = Cursors.Default;
                StartChallenge = true;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtChallengeText.Text == "" || txtText.Text == "") 
            {
                MessageBox.Show("Please go to start challenge First.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double Accuracy = GetAccuracy();

            if (Accuracy >= 85)
            {
                MessageBox.Show($"Excellent, Your Accuracy {Accuracy}", "Accuracy",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (Accuracy < 85 && Accuracy > 60)
            {
                MessageBox.Show($"Good, Your Accuracy {Accuracy}", "Accuracy",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show($"Not Good, Your Accuracy {Accuracy}", "Accuracy",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            StartChallenge = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
