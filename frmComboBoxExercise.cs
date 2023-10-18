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
    public partial class frmComboBoxExercise : Form
    {
        public frmComboBoxExercise()
        {
            InitializeComponent();
        }

        private void cbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cbChoice.SelectedItem.ToString().ToUpper())
            {

                case "BOOK":
                    pb1.Image = Resources.Book;
                    lblTitle.Text = "Book";
                    break;

                case "BOY":
                    pb1.Image = Resources.Boy;
                    lblTitle.Text = "Boy";
                    break;

                case "GIRL":
                    pb1.Image = Resources.Girl;
                    lblTitle.Text = "Girl";
                    break;

                case "PEN":
                    pb1.Image = Resources.Pen;
                    lblTitle.Text = "Pen";
                    break;


            }


        }
    }
}
