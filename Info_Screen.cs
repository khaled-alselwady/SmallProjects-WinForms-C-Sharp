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
    public partial class Info_Screen : Form
    {
        public Info_Screen()
        {
            InitializeComponent();
        }

        static bool SaveInfo = false;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool boolean = (MessageBox.Show("Are you sure you want to save this information?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes);

            if (boolean && maskedTextBox1.MaskFull && maskedTextBox2.MaskFull)
            {

                textBox14.Text = textBox1.Text;
                textBox13.Text = textBox2.Text;
                textBox12.Text = textBox4.Text;
                textBox11.Text = maskedTextBox2.Text;
                textBox10.Text = textBox5.Text;
                textBox9.Text = maskedTextBox1.Text;
                textBox8.Text = textBox6.Text;

                MessageBox.Show("Information has been updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SaveInfo = true;
            }

            if (boolean && (!maskedTextBox1.MaskFull || !maskedTextBox2.MaskFull))
            {
                MessageBox.Show("Please Complete the information ..", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox4.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(!SaveInfo)
            {
                if (MessageBox.Show("Are you sure you want to close before saving Information?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            else
            {
                this.Close();
            }
 
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            textBox15.PasswordChar = default;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            textBox15.PasswordChar = '*';
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox4.Text = textBox1.Text + " " + textBox2.Text;
        }
    }
}
