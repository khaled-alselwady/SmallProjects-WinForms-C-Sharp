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
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == txtUserName.Tag.ToString())
            {
                txtUserName.Text = "";
            }

        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = txtUserName.Tag.ToString();
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassword.Tag.ToString())
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = txtPassword.Tag.ToString();
                txtPassword.PasswordChar = default;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassword.Tag.ToString())
            {
                txtPassword.PasswordChar = default;
            }

            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtUserName.Text == txtUserName.Tag.ToString())
            {
                if (txtPassword.Text == "" || txtPassword.Text == txtPassword.Tag.ToString())
                {
                    //lbError.Text = "Please Fill The Form!";
                    if (MessageBox.Show("Please Fill The Form!", "Error",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    {
                        txtUserName.Text = txtUserName.Tag.ToString();
                        txtPassword.Text = txtPassword.Tag.ToString();
                        txtPassword.PasswordChar = default;
                    }
                }

                else
                {
                    //lbError.Text = "Please Fill The Email or Number Phone!";

                    if (MessageBox.Show("Please Fill The Email!", "Error",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    {
                        txtUserName.Text = txtUserName.Tag.ToString();
                        txtPassword.Text = txtPassword.Tag.ToString();
                        txtPassword.PasswordChar = default;
                    }

                }

            }

            else
            {
                if (txtPassword.Text == "" || txtPassword.Text == txtPassword.Tag.ToString())
                {
                    //lbError.Text = "Please Fill The Password!";

                    if (MessageBox.Show("Please Fill The Password!", "Error",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    {
                        txtUserName.Text = txtUserName.Tag.ToString();
                        txtPassword.Text = txtPassword.Tag.ToString();
                        txtPassword.PasswordChar = default;
                    }

                }

                else
                {
                    MessageBox.Show("Logged in successfully :)", "", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                }
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = default;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (!(txtPassword.Text == txtPassword.Tag.ToString())) 
            {
                txtPassword.PasswordChar = '*';
            }
                
        }

        
    }
}
