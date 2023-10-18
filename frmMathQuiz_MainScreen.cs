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
    public partial class frmMathQuiz_MainScreen : Form
    {
        public frmMathQuiz_MainScreen()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmStartQuizz = new frmMathQuiz_StartQuizScreen();
            frmStartQuizz.Show();
        }
    }
}
