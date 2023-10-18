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
    public partial class frmMathQuiz_ResultsScreen : Form
    {
        public frmMathQuiz_ResultsScreen()
        {
            InitializeComponent();
        }

        private frmMathQuiz_MainScreen CopyFromMainScreen = Application.OpenForms["frmMathQuiz_MainScreen"] as frmMathQuiz_MainScreen;

       private frmMathQuiz_StartQuizScreen CopyFromStartQuizScreen = Application.OpenForms["frmMathQuiz_StartQuizScreen"] as frmMathQuiz_StartQuizScreen;

        private void frmMathQuiz_ResultsScreen_Load(object sender, EventArgs e)
        {
            lblNumberOfTotalCorrectAnswer.Text = CopyFromStartQuizScreen.lblNumberOfCorrectAnswer.Text;
            lblNumberOfTotalWrongAnswer.Text = CopyFromStartQuizScreen.lblNumberOfWrongAnswer.Text;
            lblLevel.Text = CopyFromMainScreen.combLevel.Text;
            lblType.Text = CopyFromMainScreen.combOperation.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
