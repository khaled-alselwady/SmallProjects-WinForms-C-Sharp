namespace MyFirstWinFormsProject
{
    partial class frmKeyboardTypingGame
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRandomKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKeyboardPassed = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.cboxLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblRandomKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 373);
            this.panel1.TabIndex = 0;
            // 
            // lblRandomKey
            // 
            this.lblRandomKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRandomKey.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomKey.ForeColor = System.Drawing.Color.Green;
            this.lblRandomKey.Location = new System.Drawing.Point(83, 9);
            this.lblRandomKey.Name = "lblRandomKey";
            this.lblRandomKey.Size = new System.Drawing.Size(55, 47);
            this.lblRandomKey.TabIndex = 8;
            this.lblRandomKey.Text = "A";
            this.lblRandomKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Type:";
            // 
            // cboxType
            // 
            this.cboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            "Characters",
            "Numbers"});
            this.cboxType.Location = new System.Drawing.Point(125, 382);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(121, 24);
            this.cboxType.TabIndex = 0;
            this.cboxType.Tag = "0";
            this.cboxType.Validating += new System.ComponentModel.CancelEventHandler(this.cboxType_Validating);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(5, 461);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(107, 39);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Tag = "";
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(118, 461);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(76, 39);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(200, 461);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(76, 39);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Keyboard Passed:";
            // 
            // lblKeyboardPassed
            // 
            this.lblKeyboardPassed.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyboardPassed.Location = new System.Drawing.Point(439, 444);
            this.lblKeyboardPassed.Name = "lblKeyboardPassed";
            this.lblKeyboardPassed.Size = new System.Drawing.Size(42, 41);
            this.lblKeyboardPassed.TabIndex = 7;
            this.lblKeyboardPassed.Text = "A";
            this.lblKeyboardPassed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(667, 421);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(127, 39);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Zilla Slab", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(913, 407);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(80, 32);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "00:00";
            // 
            // cboxLevel
            // 
            this.cboxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxLevel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLevel.FormattingEnabled = true;
            this.cboxLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cboxLevel.Location = new System.Drawing.Point(125, 411);
            this.cboxLevel.Name = "cboxLevel";
            this.cboxLevel.Size = new System.Drawing.Size(121, 24);
            this.cboxLevel.TabIndex = 1;
            this.cboxLevel.Tag = "0";
            this.cboxLevel.Validating += new System.ComponentModel.CancelEventHandler(this.cboxLevel_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choose Level:";
            // 
            // frmKeyboardTypingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 504);
            this.Controls.Add(this.cboxLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblKeyboardPassed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmKeyboardTypingGame";
            this.Text = "frmGameKeyboardTyping";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKeyboardTypingGame_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmKeyboardTypingGame_KeyPress);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRandomKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKeyboardPassed;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox cboxLevel;
        private System.Windows.Forms.Label label3;
    }
}