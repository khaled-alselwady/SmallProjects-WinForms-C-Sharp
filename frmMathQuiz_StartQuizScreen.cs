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
    public partial class frmMathQuiz_StartQuizScreen : Form
    {
        public frmMathQuiz_StartQuizScreen()
        {
            InitializeComponent();
        }

        enum enLevel { Easy, Medium,Hard,Mixed }
        enum enType { Subtracion, Addition, Multiplication, Division, Mixed }

        struct stQuizInfo
        {
            public byte NumberOfCorrectAnswer;
            public byte NumberOfWrongAnswer;
            public byte NumberOfQuestion;
            public short CorrectAnswer;
            public enLevel Level;
            public enType Type;
        }

        private stQuizInfo QuizInfo = new stQuizInfo();

       private frmMathQuiz_MainScreen copy = Application.OpenForms["frmMathQuiz_MainScreen"] as frmMathQuiz_MainScreen;

        private byte NumberOfSec = 61;

        private Random Rand = new Random();

        private enLevel ChooseLevel()
        {
            switch (copy.combLevel.Text)
            {
                case "EASY":
                    return enLevel.Easy;

                case "MEDIUM":
                    return enLevel.Medium;

                case "HARD":
                    return enLevel.Hard;

                default:
                    return enLevel.Mixed;
            }
        }

        private enType ChooseType()
        {
            switch (copy.combOperation.Text)
            {
                case "SUBTRACTION":
                    return enType.Subtracion;

                case "ADDITION":
                    return enType.Addition;

                case "MULTIPLICATION":
                    return enType.Multiplication;

                case "DIVISION":
                    return enType.Division;

                default:
                    return enType.Mixed;
            }
        }

        private void ChooseNumbers()
        {
            if (copy.combLevel.Text == "MIXED")
            {
                QuizInfo.Level = (enLevel)Rand.Next(0, 3);
            }

            switch (QuizInfo.Level)
            {
                
                case enLevel.Easy:
                    lblNumber1.Text = (Rand.Next(0, 10)).ToString();
                    lblNumber2.Text = (Rand.Next(0, 10)).ToString();
                    break;

                case enLevel.Medium:
                    lblNumber1.Text = (Rand.Next(10, 100)).ToString();
                    lblNumber2.Text = (Rand.Next(10, 100)).ToString();
                    break;

                case enLevel.Hard:
                    lblNumber1.Text = (Rand.Next(-20, 500)).ToString();
                    lblNumber2.Text = (Rand.Next(-20, 500)).ToString();
                    break;

            }





        }

        private void ChooseOperationType()
        {
            if (copy.combOperation.Text == "MIXED")
            {
                QuizInfo.Type = (enType)Rand.Next(0, 4);
            }

            switch (QuizInfo.Type)
            {

                case enType.Subtracion:
                    lblOperation.Text = "-";
                    QuizInfo.CorrectAnswer = (short)(Convert.ToInt16(lblNumber1.Text) - Convert.ToInt16(lblNumber2.Text));
                    break;

                case enType.Addition:
                    lblOperation.Text = "+";
                    QuizInfo.CorrectAnswer = (short)(Convert.ToInt16(lblNumber1.Text) + Convert.ToInt16(lblNumber2.Text));
                    break;

                case enType.Multiplication:
                    lblOperation.Text = "*";
                    QuizInfo.CorrectAnswer = (short)(Convert.ToInt16(lblNumber1.Text) * Convert.ToInt16(lblNumber2.Text));
                    break;

                case enType.Division:
                    lblOperation.Text = "/";
                    if (lblNumber2.Text == "0")
                    {
                        lblNumber2.Text = "1";
                    }
                    QuizInfo.CorrectAnswer = (short)(Convert.ToInt16(lblNumber1.Text) / Convert.ToInt16(lblNumber2.Text));
                    break;

            }

        }

        private string FillTheOtherChoices(Button btn)
        {
            
            switch (QuizInfo.Level)
            {

                case enLevel.Easy:
                    btn.Text = Rand.Next(0, 10).ToString();
                    break;


                case enLevel.Medium:
                    btn.Text = Rand.Next(10, 100).ToString();
                    break;


                case enLevel.Hard:
                    btn.Text = Rand.Next(-20, 500).ToString();
                    break;

            }

            return btn.Text;
        }

        private void FillTheChoices()
        {
            byte IndexOfCorrectAnswer = (byte)Rand.Next(1, 5);

            switch (IndexOfCorrectAnswer)
            {
                case 1:
                    btnChoice1.Text = QuizInfo.CorrectAnswer.ToString();
                    btnChoice2.Text = FillTheOtherChoices(btnChoice2);
                    btnChoice3.Text = FillTheOtherChoices(btnChoice3);
                    btnChoice4.Text = FillTheOtherChoices(btnChoice4);

                    if (btnChoice1.Text == btnChoice2.Text || btnChoice1.Text == btnChoice3.Text ||
                        btnChoice1.Text == btnChoice4.Text || btnChoice2.Text == btnChoice3.Text ||
                        btnChoice2.Text == btnChoice4.Text || btnChoice3.Text == btnChoice4.Text)
                    {
                        btnChoice1.Text = QuizInfo.CorrectAnswer.ToString();
                        btnChoice2.Text = FillTheOtherChoices(btnChoice2);
                        btnChoice3.Text = FillTheOtherChoices(btnChoice3);
                        btnChoice4.Text = FillTheOtherChoices(btnChoice4);
                    }
                    btnChoice1.Tag = 1;
                    break;

                case 2:
                    btnChoice1.Text = FillTheOtherChoices(btnChoice1);
                    btnChoice2.Text = QuizInfo.CorrectAnswer.ToString();
                    btnChoice3.Text = FillTheOtherChoices(btnChoice3);
                    btnChoice4.Text = FillTheOtherChoices(btnChoice4);

                    if (btnChoice1.Text == btnChoice2.Text || btnChoice1.Text == btnChoice3.Text ||
                        btnChoice1.Text == btnChoice4.Text || btnChoice2.Text == btnChoice3.Text ||
                        btnChoice2.Text == btnChoice4.Text || btnChoice3.Text == btnChoice4.Text)
                    {
                        btnChoice1.Text = FillTheOtherChoices(btnChoice1);
                        btnChoice2.Text = QuizInfo.CorrectAnswer.ToString();
                        btnChoice3.Text = FillTheOtherChoices(btnChoice3);
                        btnChoice4.Text = FillTheOtherChoices(btnChoice4);
                    }

                        btnChoice2.Tag = 1;
                    break;

                case 3:
                    btnChoice1.Text = FillTheOtherChoices(btnChoice1);
                    btnChoice2.Text = FillTheOtherChoices(btnChoice2);
                    btnChoice3.Text = QuizInfo.CorrectAnswer.ToString();
                    btnChoice4.Text = FillTheOtherChoices(btnChoice4);

                    if (btnChoice1.Text == btnChoice2.Text || btnChoice1.Text == btnChoice3.Text ||
                        btnChoice1.Text == btnChoice4.Text || btnChoice2.Text == btnChoice3.Text ||
                        btnChoice2.Text == btnChoice4.Text || btnChoice3.Text == btnChoice4.Text)
                    {
                        btnChoice1.Text = FillTheOtherChoices(btnChoice1);
                        btnChoice2.Text = FillTheOtherChoices(btnChoice2);
                        btnChoice3.Text = QuizInfo.CorrectAnswer.ToString();
                        btnChoice4.Text = FillTheOtherChoices(btnChoice4);
                    }

                        btnChoice3.Tag = 1;
                    break;

                default:
                    btnChoice1.Text = FillTheOtherChoices(btnChoice1);
                    btnChoice2.Text = FillTheOtherChoices(btnChoice2);
                    btnChoice3.Text = FillTheOtherChoices(btnChoice3);
                    btnChoice4.Text = QuizInfo.CorrectAnswer.ToString();

                    if (btnChoice1.Text == btnChoice2.Text || btnChoice1.Text == btnChoice3.Text ||
                        btnChoice1.Text == btnChoice4.Text || btnChoice2.Text == btnChoice3.Text ||
                        btnChoice2.Text == btnChoice4.Text || btnChoice3.Text == btnChoice4.Text)
                    {
                        btnChoice1.Text = FillTheOtherChoices(btnChoice1);
                        btnChoice2.Text = FillTheOtherChoices(btnChoice2);
                        btnChoice3.Text = FillTheOtherChoices(btnChoice3);
                        btnChoice4.Text = QuizInfo.CorrectAnswer.ToString();
                    }

                        btnChoice4.Tag = 1;
                    break;
                    
            }
        }

        private void StartQuiz()
        {

            QuizInfo.NumberOfQuestion++;
            lblNumberOfQuestion.Text = QuizInfo.NumberOfQuestion.ToString();

            ChooseNumbers();
            ChooseOperationType();
            FillTheChoices();

        }

        private void DisabledItems()
        {
            label1.Enabled = false;
            lblNumberOfQuestion.Enabled = false;
            label2.Enabled = false;
            lblTotalNumberOfQuestion.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            lblNumberOfMin.Enabled = false;
            label6.Enabled = false;
            lblNumberOfSec.Enabled = false;
            label5.Enabled = false;
            label7.Enabled = false;
            lblNumberOfCorrectAnswer.Enabled = false;
            lblNumberOfWrongAnswer.Enabled = false;
            btnChoice1.Enabled = false;
            btnChoice2.Enabled = false;
            btnChoice3.Enabled = false;
            btnChoice4.Enabled = false;
            lblOperation.Enabled = false;
            lblNumber1.Enabled = false;
            lblNumber2.Enabled = false;
            label9.Enabled = false;
            label10.Enabled = false;

        }

        private void frmMathQuiz_StartQuizScreen_Load(object sender, EventArgs e)
        {

            lblTotalNumberOfQuestion.Text = copy.numericNumberOfQuestions.Value.ToString();

            QuizInfo.Level = ChooseLevel();

            QuizInfo.Type = ChooseType();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (NumberOfSec < 11)
            {
                lblNumberOfSec.Text = "0" + (NumberOfSec - 1).ToString();
            }
            else
            {
                lblNumberOfSec.Text = (NumberOfSec - 1).ToString();
            }

            NumberOfSec--;

            if (NumberOfSec == 0)
            {
                timer1.Stop();

                if (QuizInfo.NumberOfQuestion < copy.numericNumberOfQuestions.Value)
                {
                    MessageBox.Show("Times up!", "Game Over");
                    DisabledItems();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            StartQuiz();
        }

        private void btnChoice1_Click(object sender, EventArgs e)
        {
            if (QuizInfo.NumberOfQuestion <= copy.numericNumberOfQuestions.Value)
            {
                if (btnChoice1.Tag.ToString() == "1")
                {
                    MessageBox.Show("Your Answer is Correct", "Great!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    QuizInfo.NumberOfCorrectAnswer++;
                    lblNumberOfCorrectAnswer.Text = QuizInfo.NumberOfCorrectAnswer.ToString();

                    btnChoice1.Tag = 0;
                }
                else
                {
                    MessageBox.Show("Your Answer is Wrong", "Try Again!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    QuizInfo.NumberOfWrongAnswer++;

                    lblNumberOfWrongAnswer.Text = QuizInfo.NumberOfWrongAnswer.ToString();
                }

                StartQuiz();

                if (QuizInfo.NumberOfQuestion > copy.numericNumberOfQuestions.Value)
                {
                    DisabledItems();
                    this.Hide();
                    Form frm = new frmMathQuiz_ResultsScreen();
                    frm.Show();
                }

            }

            

            
        }

        private void btnChoice2_Click(object sender, EventArgs e)
        {
            if (QuizInfo.NumberOfQuestion <= copy.numericNumberOfQuestions.Value)
            {
                if (btnChoice2.Tag.ToString() == "1")
                {
                    MessageBox.Show("Your Answer is Correct", "Great!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    QuizInfo.NumberOfCorrectAnswer++;
                    lblNumberOfCorrectAnswer.Text = QuizInfo.NumberOfCorrectAnswer.ToString();

                    btnChoice2.Tag = 0;
                }
                else
                {
                    MessageBox.Show("Your Answer is Wrong", "Try Again!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    QuizInfo.NumberOfWrongAnswer++;
                    lblNumberOfWrongAnswer.Text = QuizInfo.NumberOfWrongAnswer.ToString();
                }

                StartQuiz();

                if (QuizInfo.NumberOfQuestion > copy.numericNumberOfQuestions.Value)
                {
                    DisabledItems();
                    this.Hide();
                    Form frm = new frmMathQuiz_ResultsScreen();
                    frm.Show();
                }
            }

            

        }

        private void btnChoice3_Click(object sender, EventArgs e)
        {
            if (QuizInfo.NumberOfQuestion <= copy.numericNumberOfQuestions.Value)
            {

                if (btnChoice3.Tag.ToString() == "1")
                {
                    MessageBox.Show("Your Answer is Correct", "Great!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    QuizInfo.NumberOfCorrectAnswer++;
                    lblNumberOfCorrectAnswer.Text = QuizInfo.NumberOfCorrectAnswer.ToString();

                    btnChoice3.Tag = 0;
                }
                else
                {
                    MessageBox.Show("Your Answer is Wrong", "Try Again!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    QuizInfo.NumberOfWrongAnswer++;
                    lblNumberOfWrongAnswer.Text = QuizInfo.NumberOfWrongAnswer.ToString();
                }

                StartQuiz();

                if (QuizInfo.NumberOfQuestion > copy.numericNumberOfQuestions.Value)
                {
                    DisabledItems();
                    this.Hide();
                    Form frm = new frmMathQuiz_ResultsScreen();
                    frm.Show();
                }
            }

            

        }

        private void btnChoice4_Click(object sender, EventArgs e)
        {
            if (QuizInfo.NumberOfQuestion <= copy.numericNumberOfQuestions.Value)
            {
                if (btnChoice4.Tag.ToString() == "1")
                {
                    MessageBox.Show("Your Answer is Correct", "Great!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    QuizInfo.NumberOfCorrectAnswer++;
                    lblNumberOfCorrectAnswer.Text = QuizInfo.NumberOfCorrectAnswer.ToString();

                    btnChoice4.Tag = 0;
                }
                else
                {
                    MessageBox.Show("Your Answer is Wrong", "Try Again!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    QuizInfo.NumberOfWrongAnswer++;
                    lblNumberOfWrongAnswer.Text = QuizInfo.NumberOfWrongAnswer.ToString();
                }

                StartQuiz();

                if (QuizInfo.NumberOfQuestion > copy.numericNumberOfQuestions.Value)
                {
                    DisabledItems();
                    this.Hide();
                    Form frm = new frmMathQuiz_ResultsScreen();
                    frm.Show();
                }
            }

           

        }
    }
}
