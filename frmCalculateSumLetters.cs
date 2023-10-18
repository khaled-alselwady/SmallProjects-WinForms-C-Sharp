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
    public partial class frmCalculateSumLetters : Form
    {
        public frmCalculateSumLetters()
        {
            InitializeComponent();
        }

        private int _CalculateAllLetterSum()
        {
            int _Sum = 0;
            int _LetterIndex = 0;

            for (int i = 0; i < txtText.Text.Length; i++)
            {

                if (char.IsLetter(txtText.Text[i])) 
                {
                    _LetterIndex = char.ToLower(txtText.Text[i]) - 'a' + 1;
                    _Sum += _LetterIndex;
                }

            }

            return _Sum;
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtText.Text))
                lblLetterSum.Text = string.Empty;

            else
                lblLetterSum.Text = _CalculateAllLetterSum().ToString();
        }
    }
}
