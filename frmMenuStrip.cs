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
    public partial class frmMenuStrip : Form
    {
        public frmMenuStrip()
        {
            InitializeComponent();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUserScreen frmAddNewUserScreen = new frmAddNewUserScreen();
            frmAddNewUserScreen.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
      
        private void tsmColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
                textBox2.BackColor = colorDialog1.Color;
            }
        }

        private void tsmFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;

                textBox2.Font = fontDialog1.Font;
                textBox2.ForeColor = fontDialog1.Color;
            }
        }

        private void tsmClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
