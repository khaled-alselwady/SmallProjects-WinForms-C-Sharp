using MyFirstWinFormsProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MyFirstWinFormsProject
{
    public partial class frmErrorProviderAndProgressBarExercise : Form
    {
        public frmErrorProviderAndProgressBarExercise()
        {
            InitializeComponent();
        }

        private bool IsPasswordContainNumbers(string Password)
        {
            for (byte i = 0; i < Password.Length; i++)
            {
                if (char.IsDigit(Password[i]))
                    return true;
            }

            return false;
        }

        private bool IsPasswordOrEmailContainLetters(string Password)
        {
            for (byte i = 0; i < Password.Length; i++)
            {
                if (char.IsLetter(Password[i]))
                    return true;
            }

            return false;
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                errorProvider1.SetError(((TextBox)sender), "Required");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(((TextBox)sender), "");
                progressBar1.Value += 16;
                lblValueOfProgressBar.Text = progressBar1.Value.ToString() + "%";
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                errorProvider1.SetError(((TextBox)sender), "Required");
                return;
            }

            if ((!txtEmail.Text.Contains('@') || !IsPasswordOrEmailContainLetters(txtEmail.Text)) && !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                errorProvider1.SetError(((TextBox)sender), "Invalid Email");
                return;
            }

            e.Cancel = false;
            errorProvider1.SetError(((TextBox)sender), "");
            progressBar1.Value += 16;
            lblValueOfProgressBar.Text = progressBar1.Value.ToString() + "%";
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                errorProvider1.SetError(((TextBox)sender), "Required");
                return;
            }

            if (!IsPasswordContainNumbers(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                errorProvider1.SetError(((TextBox)sender), "Required Number");
                return;
            }

            if (!IsPasswordOrEmailContainLetters(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                errorProvider1.SetError(((TextBox)sender), "Required Letter");
                return;
            }

            e.Cancel = false;
            errorProvider1.SetError(((TextBox)sender), "");
            progressBar1.Value += 16;
            lblValueOfProgressBar.Text = progressBar1.Value.ToString() + "%";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Boy;
            progressBar1.Value += 20;
            lblValueOfProgressBar.Text = progressBar1.Value.ToString() + "%";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value += 16;
            lblValueOfProgressBar.Text = progressBar1.Value.ToString() + "%";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblFinalResults.Text = "First Name: " + txtFirstName.Text + Environment.NewLine +
                 "Last Name: " + txtLastName.Text + Environment.NewLine +
                 "Date Of Birth: " + dateTimePicker1.Value.ToString("g") + Environment.NewLine +
                 "Email: " + txtEmail.Text + Environment.NewLine +
                 "Password: " + txtPassword.Text + Environment.NewLine;

        }
    }
}
