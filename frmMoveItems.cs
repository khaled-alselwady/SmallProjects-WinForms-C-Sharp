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
    public partial class frmMoveItems : Form
    {
        public frmMoveItems()
        {
            InitializeComponent();
        }

        private void btnToListBox_Click(object sender, EventArgs e)
        {
            if (cboxChoices.SelectedIndex == -1)
                return;

            listBox1.Items.Add(cboxChoices.SelectedItem);
            cboxChoices.Items.Remove(cboxChoices.SelectedItem);

            if (cboxChoices.Items.Count > 0)
                cboxChoices.SelectedIndex = 0;

            else
                cboxChoices.Text = "";


        }

        private void frmMoveItems_Load(object sender, EventArgs e)
        {
            cboxChoices.SelectedIndex = 0;
        }

        private void btnToComboBox_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0 || listBox1.SelectedIndex == -1) 
                return;

            cboxChoices.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);

        }
    }
}
