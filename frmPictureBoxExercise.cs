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

namespace MyFirstWinFormsProject
{
    public partial class frmPictureBoxExercise : Form
    {
        public frmPictureBoxExercise()
        {
            InitializeComponent();
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBoy.Checked)
            {
                pictureBox1.Image = Resources.Boy;
                lblTitle.Text = ((RadioButton)sender).Tag.ToString();
            }

        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGirl.Checked)
            {
                pictureBox1.Image = Resources.Girl;
                lblTitle.Text = ((RadioButton)sender).Tag.ToString();
            }
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                pictureBox1.Image = Resources.Book;
                lblTitle.Text = ((RadioButton)sender).Tag.ToString();
            }
        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPen.Checked)
            {
                pictureBox1.Image = Resources.Pen;
                lblTitle.Text = ((RadioButton)sender).Tag.ToString();
            }
        }

       
    }
}
