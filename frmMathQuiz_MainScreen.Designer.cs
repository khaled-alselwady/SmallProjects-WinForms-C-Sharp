namespace MyFirstWinFormsProject
{
    partial class frmMathQuiz_MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericNumberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.combLevel = new System.Windows.Forms.ComboBox();
            this.combOperation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMBER OF QUESTIONS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(227, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUIZ LEVEl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "OPERATION TYPE";
            // 
            // numericNumberOfQuestions
            // 
            this.numericNumberOfQuestions.BackColor = System.Drawing.Color.Brown;
            this.numericNumberOfQuestions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNumberOfQuestions.Location = new System.Drawing.Point(470, 27);
            this.numericNumberOfQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumberOfQuestions.Name = "numericNumberOfQuestions";
            this.numericNumberOfQuestions.Size = new System.Drawing.Size(48, 27);
            this.numericNumberOfQuestions.TabIndex = 3;
            this.numericNumberOfQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // combLevel
            // 
            this.combLevel.BackColor = System.Drawing.Color.Brown;
            this.combLevel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combLevel.FormattingEnabled = true;
            this.combLevel.Items.AddRange(new object[] {
            "EASY",
            "MEDIUM",
            "HARD",
            "MIXED"});
            this.combLevel.Location = new System.Drawing.Point(357, 68);
            this.combLevel.Name = "combLevel";
            this.combLevel.Size = new System.Drawing.Size(137, 27);
            this.combLevel.TabIndex = 4;
            // 
            // combOperation
            // 
            this.combOperation.BackColor = System.Drawing.Color.Brown;
            this.combOperation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combOperation.FormattingEnabled = true;
            this.combOperation.Items.AddRange(new object[] {
            "SUBTRACTION",
            "ADDITION",
            "MULTIPLICATION",
            "DIVISION",
            "MIXED"});
            this.combOperation.Location = new System.Drawing.Point(398, 110);
            this.combOperation.Name = "combOperation";
            this.combOperation.Size = new System.Drawing.Size(137, 27);
            this.combOperation.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(307, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start Quiz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMathQuiz_MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyFirstWinFormsProject.Properties.Resources.BackgroundMathQuiz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combOperation);
            this.Controls.Add(this.combLevel);
            this.Controls.Add(this.numericNumberOfQuestions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMathQuiz_MainScreen";
            this.Text = "frmMathQuiz_MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown numericNumberOfQuestions;
        public System.Windows.Forms.ComboBox combLevel;
        public System.Windows.Forms.ComboBox combOperation;
    }
}