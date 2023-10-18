namespace MyFirstWinFormsProject
{
    partial class frmMathQuiz_StartQuizScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalNumberOfQuestion = new System.Windows.Forms.Label();
            this.lblNumberOfCorrectAnswer = new System.Windows.Forms.Label();
            this.lblNumberOfWrongAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberOfMin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumberOfSec = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.btnChoice3 = new System.Windows.Forms.Button();
            this.btnChoice4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyFirstWinFormsProject.Properties.Resources.sand_clock;
            this.pictureBox1.Location = new System.Drawing.Point(639, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(263, 450);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 49);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(481, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 49);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUESTION :";
            // 
            // lblNumberOfQuestion
            // 
            this.lblNumberOfQuestion.AutoSize = true;
            this.lblNumberOfQuestion.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfQuestion.Location = new System.Drawing.Point(453, 22);
            this.lblNumberOfQuestion.Name = "lblNumberOfQuestion";
            this.lblNumberOfQuestion.Size = new System.Drawing.Size(33, 35);
            this.lblNumberOfQuestion.TabIndex = 4;
            this.lblNumberOfQuestion.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // lblTotalNumberOfQuestion
            // 
            this.lblTotalNumberOfQuestion.AutoSize = true;
            this.lblTotalNumberOfQuestion.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumberOfQuestion.Location = new System.Drawing.Point(525, 22);
            this.lblTotalNumberOfQuestion.Name = "lblTotalNumberOfQuestion";
            this.lblTotalNumberOfQuestion.Size = new System.Drawing.Size(33, 35);
            this.lblTotalNumberOfQuestion.TabIndex = 6;
            this.lblTotalNumberOfQuestion.Text = "0";
            // 
            // lblNumberOfCorrectAnswer
            // 
            this.lblNumberOfCorrectAnswer.AutoSize = true;
            this.lblNumberOfCorrectAnswer.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCorrectAnswer.Location = new System.Drawing.Point(139, 169);
            this.lblNumberOfCorrectAnswer.Name = "lblNumberOfCorrectAnswer";
            this.lblNumberOfCorrectAnswer.Size = new System.Drawing.Size(33, 35);
            this.lblNumberOfCorrectAnswer.TabIndex = 7;
            this.lblNumberOfCorrectAnswer.Text = "0";
            // 
            // lblNumberOfWrongAnswer
            // 
            this.lblNumberOfWrongAnswer.AutoSize = true;
            this.lblNumberOfWrongAnswer.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfWrongAnswer.Location = new System.Drawing.Point(139, 274);
            this.lblNumberOfWrongAnswer.Name = "lblNumberOfWrongAnswer";
            this.lblNumberOfWrongAnswer.Size = new System.Drawing.Size(33, 35);
            this.lblNumberOfWrongAnswer.TabIndex = 8;
            this.lblNumberOfWrongAnswer.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(738, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            // 
            // lblNumberOfMin
            // 
            this.lblNumberOfMin.AutoSize = true;
            this.lblNumberOfMin.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfMin.Location = new System.Drawing.Point(750, 204);
            this.lblNumberOfMin.Name = "lblNumberOfMin";
            this.lblNumberOfMin.Size = new System.Drawing.Size(51, 35);
            this.lblNumberOfMin.TabIndex = 11;
            this.lblNumberOfMin.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(792, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = ":";
            // 
            // lblNumberOfSec
            // 
            this.lblNumberOfSec.AutoSize = true;
            this.lblNumberOfSec.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfSec.Location = new System.Drawing.Point(804, 204);
            this.lblNumberOfSec.Name = "lblNumberOfSec";
            this.lblNumberOfSec.Size = new System.Drawing.Size(51, 35);
            this.lblNumberOfSec.TabIndex = 13;
            this.lblNumberOfSec.Text = "60";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumber1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.ForeColor = System.Drawing.Color.White;
            this.lblNumber1.Location = new System.Drawing.Point(344, 98);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(33, 35);
            this.lblNumber1.TabIndex = 14;
            this.lblNumber1.Text = "0";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumber2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.ForeColor = System.Drawing.Color.White;
            this.lblNumber2.Location = new System.Drawing.Point(344, 149);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(33, 35);
            this.lblNumber2.TabIndex = 15;
            this.lblNumber2.Text = "0";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.BackColor = System.Drawing.Color.Transparent;
            this.lblOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOperation.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.ForeColor = System.Drawing.Color.White;
            this.lblOperation.Location = new System.Drawing.Point(267, 124);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(39, 35);
            this.lblOperation.TabIndex = 16;
            this.lblOperation.Text = "+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(288, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 35);
            this.label9.TabIndex = 17;
            this.label9.Text = "_______";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(344, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 35);
            this.label10.TabIndex = 18;
            this.label10.Text = "?";
            // 
            // btnChoice1
            // 
            this.btnChoice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChoice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice1.Location = new System.Drawing.Point(264, 260);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(83, 38);
            this.btnChoice1.TabIndex = 23;
            this.btnChoice1.Tag = "0";
            this.btnChoice1.Text = "0";
            this.btnChoice1.UseVisualStyleBackColor = false;
            this.btnChoice1.Click += new System.EventHandler(this.btnChoice1_Click);
            // 
            // btnChoice2
            // 
            this.btnChoice2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChoice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice2.Location = new System.Drawing.Point(367, 260);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(83, 38);
            this.btnChoice2.TabIndex = 24;
            this.btnChoice2.Tag = "0";
            this.btnChoice2.Text = "0";
            this.btnChoice2.UseVisualStyleBackColor = false;
            this.btnChoice2.Click += new System.EventHandler(this.btnChoice2_Click);
            // 
            // btnChoice3
            // 
            this.btnChoice3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChoice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice3.Location = new System.Drawing.Point(264, 320);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Size = new System.Drawing.Size(83, 38);
            this.btnChoice3.TabIndex = 25;
            this.btnChoice3.Tag = "0";
            this.btnChoice3.Text = "0";
            this.btnChoice3.UseVisualStyleBackColor = false;
            this.btnChoice3.Click += new System.EventHandler(this.btnChoice3_Click);
            // 
            // btnChoice4
            // 
            this.btnChoice4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChoice4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice4.Location = new System.Drawing.Point(367, 320);
            this.btnChoice4.Name = "btnChoice4";
            this.btnChoice4.Size = new System.Drawing.Size(83, 38);
            this.btnChoice4.TabIndex = 26;
            this.btnChoice4.Tag = "0";
            this.btnChoice4.Text = "0";
            this.btnChoice4.UseVisualStyleBackColor = false;
            this.btnChoice4.Click += new System.EventHandler(this.btnChoice4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "CORRECT :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "WRONG :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMathQuiz_StartQuizScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyFirstWinFormsProject.Properties.Resources.StartQuiz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(868, 523);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChoice4);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblNumberOfSec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNumberOfMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumberOfWrongAnswer);
            this.Controls.Add(this.lblNumberOfCorrectAnswer);
            this.Controls.Add(this.lblTotalNumberOfQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Name = "frmMathQuiz_StartQuizScreen";
            this.Text = "frmMathQuiz_StartQuizScreen";
            this.Load += new System.EventHandler(this.frmMathQuiz_StartQuizScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumberOfMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumberOfSec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnChoice1;
        private System.Windows.Forms.Button btnChoice2;
        private System.Windows.Forms.Button btnChoice3;
        private System.Windows.Forms.Button btnChoice4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblNumberOfCorrectAnswer;
        public System.Windows.Forms.Label lblNumberOfWrongAnswer;
        public System.Windows.Forms.Label lblTotalNumberOfQuestion;
        public System.Windows.Forms.Label lblNumber1;
        public System.Windows.Forms.Label lblNumber2;
        public System.Windows.Forms.Label lblOperation;
    }
}