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
    public partial class frmGenerateRandomCharacters : Form
    {
        public frmGenerateRandomCharacters()
        {
            InitializeComponent();
        }

        enum enTypeCharacter { enLetter = 1, enSymbol, enNumbers, enMix }

        Random RandomCharacter = new Random();

        enTypeCharacter TypeCharacter;

        void ResetMode()
        {
            txtText.Text = "";
            chkLetters.Visible = false;
            chkSymbols.Visible = false;
            chkNumbers.Visible = false;
            chkMix.Visible = false;
            lblNumberOfDigits.Visible = false;
            txtNumberOfDigits.Visible = false;
            btnGenerate.Enabled = false;
            txtNumberOfDigits.Text = "";
            chkLetters.Checked = false;
            chkSymbols.Checked = false;
            chkNumbers.Checked = false;
            chkMix.Checked = false;
            lblCopy.Visible = false;
        }

        void GenerateRandomLetters()
        {

            string Text = "";
            ushort NumberOfDigits = Convert.ToUInt16(txtNumberOfDigits.Text);

            for (ushort i = 1; i <= NumberOfDigits; i++)
            {
                Text += (char)RandomCharacter.Next(65, 91);
            }

            txtText.Text = Text;
        }

        void GenerateRandomSymbols()
        {

            string Text = "";
            ushort NumberOfDigits = Convert.ToUInt16(txtNumberOfDigits.Text);

            for (ushort i = 1; i <= NumberOfDigits; i++)
            {
                Text += (char)RandomCharacter.Next(33, 48);
            }

            txtText.Text = Text;
        }

        void GenerateRandomNumbers()
        {
            string Text = "";
            ushort NumberOfDigits = Convert.ToUInt16(txtNumberOfDigits.Text);

            for (ushort i = 1; i <= NumberOfDigits; i++)
            {
                Text += (char)RandomCharacter.Next(48, 58);
            }

            txtText.Text = Text;
        }

        void GenerateRandomMix()
        {
            string Text = "";
            ushort NumberOfDigits = Convert.ToUInt16(txtNumberOfDigits.Text);

            for (ushort i = 1; i <= NumberOfDigits; i++)
            {
                Text += (char)RandomCharacter.Next(33, 128);
            }

            txtText.Text = Text;
        }

        void GenerateRandomCharacter()
        {
            //if (TypeCharacter == enTypeCharacter.enMix)
            //{
            //    TypeCharacter = (enTypeCharacter)RandomCharacter.Next(1, 4);
            //}


            switch (TypeCharacter)
            {
                case enTypeCharacter.enLetter:
                    {
                        GenerateRandomLetters();
                        break;
                    }

                case enTypeCharacter.enSymbol:
                    {
                        GenerateRandomSymbols();
                        break;
                    }

                case enTypeCharacter.enNumbers:
                    {
                        GenerateRandomNumbers();
                        break;
                    }

                case enTypeCharacter.enMix:
                    {
                        GenerateRandomMix();
                        break;
                    }

            }

        }

        private void frmGenerateRandomCharacters_Load(object sender, EventArgs e)
        {
            ResetMode();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            chkLetters.Visible = true;
            chkSymbols.Visible = true;
            chkNumbers.Visible = true;
            chkMix.Visible = true;
            lblNumberOfDigits.Visible = true;
            txtNumberOfDigits.Visible = true;
        }

        private void chkMix_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMix.Checked)
            {
                TypeCharacter = enTypeCharacter.enMix;
                chkLetters.Enabled = false;
                chkSymbols.Enabled = false;
                chkNumbers.Enabled = false;
                btnGenerate.Enabled = true;
            }

            else
            {
                chkLetters.Enabled = true;
                chkSymbols.Enabled = true;
                chkNumbers.Enabled = true;
                btnGenerate.Enabled = false;
            }
        }

        private void chkLetters_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLetters.Checked)
            {
                TypeCharacter = enTypeCharacter.enLetter;
                chkSymbols.Enabled = false;
                chkNumbers.Enabled = false;
                chkMix.Enabled = false;
                btnGenerate.Enabled = true;
            }

            else
            {
                chkSymbols.Enabled = true;
                chkNumbers.Enabled = true;
                chkMix.Enabled = true;
                btnGenerate.Enabled = false;
            }
        }

        private void chkNumbers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNumbers.Checked)
            {
                TypeCharacter = enTypeCharacter.enNumbers;
                chkSymbols.Enabled = false;
                chkLetters.Enabled = false;
                chkMix.Enabled = false;
                btnGenerate.Enabled = true;
            }

            else
            {
                chkSymbols.Enabled = true;
                chkLetters.Enabled = true;
                chkMix.Enabled = true;
                btnGenerate.Enabled = false;
            }
        }

        private void chkSymbols_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSymbols.Checked)
            {
                TypeCharacter = enTypeCharacter.enSymbol;
                chkLetters.Enabled = false;
                chkNumbers.Enabled = false;
                chkMix.Enabled = false;
                btnGenerate.Enabled = true;
            }

            else
            {
                chkLetters.Enabled = true;
                chkNumbers.Enabled = true;
                chkMix.Enabled = true;
                btnGenerate.Enabled = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!(txtNumberOfDigits.Text == ""))
            {
                GenerateRandomCharacter();
                lblCopy.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetMode();
        }

        private void lblCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtText.Text))
            {
                // Copy the text to the clipboard
                Clipboard.SetText(txtText.Text);

                MessageBox.Show("The text has been copied.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
