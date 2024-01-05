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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Text = "My Form";
        }

      
        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "Mohammed Abu-Hadhoud";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            button1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Visible = true;
            textBox1.BackColor = Color.White;
        }

        private void btnShowCalculator_Click(object sender, EventArgs e)
        {
            Form F = new Calculator();

            F.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowCalculator2_Click(object sender, EventArgs e)
        {
            Form F = new Calculator2();

            F.Show();
        }

        private void btnShowInfoScreen_Click(object sender, EventArgs e)
        {
            Form F = new Info_Screen();

            F.Show();
        }


        private void btnLoginScreen_Click(object sender, EventArgs e)
        {
            Form F = new frmLoginScreen();
            F.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form F = new frmGenerateRandomCharacters();
            F.Show();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            Form F = new frmNumberOfDigitInMatrix();
            F.Show();  
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form f = new frmAddNewUserScreen();
            f.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form F = new frmKeyboardTyping();
            F.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form F = new frmPictureBox();
            F.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form F = new frmPictureBoxExercise();
            F.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                this.BackColor = Color.DarkBlue;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Very large");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form F = new frmComboBoxExercise();
            F.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(@"http://programmingadvices.com/");

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form F = new frmCheckListBox();
            F.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form F = new frmDateTimePicker();
            F.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form F = new frmMonthCalander();
            F.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form F = new frmTimer();
            F.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form F = new frmNotifyIcon();
            F.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Form F = new frmAlarmClock();
            F.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Form F = new frmTasbeeh();
            F.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Form F = new frmLoginScreenForThreeTimes();
            F.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Form F = new frmTicTacToeUpdate();
            F.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Form F = new frmPrintReverseString();
            F.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Form F = new frmTreeviewAndImageliat();
            F.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Form F = new frmProgressBar();
            F.Show();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Form F = new frmListView();
            F.Show();
            
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Form F = new frmTrackBar();
            F.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Form F = new frmTabControl();
            F.Show();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Form F = new frmTreeviewExercise();
            F.Show();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Form F = new frmListViewAndTabControlExercise();
            F.Show();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Form F = new frmMemoryGame();
            F.Show();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Form F = new frmDialogs();
            //F.MdiParent = this;
            F.Show();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Form F = new frmMenuStrip();
            F.Show();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Form F = new frmToDoList();
            F.Show();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Form F = new frmMathQuiz_MainScreen();
            F.Show();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Form F = new frmBilliardClub();
            F.Show();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Form F = new frmAthkaar();
            F.Show();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Form F = new frmKeyboardTypingGame();
            F.Show();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Form F = new frmMoveItems();
            F.Show();           
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Form F = new frmGetPermissions();
            F.Show();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Form F = new frmTreeviewAndImageliatExercise();
            F.Show();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Form F = new frmGetPermissions2();
            F.Show();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Form F = new frmErrorProviderAndProgressBarExercise();
            F.Show();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Form F = new frmCalculateSumLetters();
            F.Show();
        }
    }
}
