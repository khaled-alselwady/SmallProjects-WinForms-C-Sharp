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
    public partial class frmPrintReverseString : Form
    {
        public frmPrintReverseString()
        {
            InitializeComponent();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string CurrentWord = "";
            string ReverseSentense = "";

            txtOriginal.Text = txtOriginal.Text.Trim();

            for (ushort i = 0; i < txtOriginal.Text.Length; i++)
            {
                if (txtOriginal.Text[i] == ' ')
                {

                    for (int j = (CurrentWord.Length - 1); j >= 0; j--) 
                    {
                        ReverseSentense += CurrentWord[j];
                    }

                    ReverseSentense += " ";
                    CurrentWord = "";

                }

                else
                {
                    CurrentWord += txtOriginal.Text[i];
                }

            }

            if (CurrentWord != "")
            {
                for (int j = (CurrentWord.Length - 1); j >= 0; j--)
                {
                    ReverseSentense += CurrentWord[j];
                }
            }

            ReverseSentense = ReverseSentense.Trim();

            txtReverse.Text = ReverseSentense;   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOriginal.Text = "";
            txtReverse.Text = "";
            
        }
    }
}
