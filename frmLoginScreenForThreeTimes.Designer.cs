namespace MyFirstWinFormsProject
{
    partial class frmLoginScreenForThreeTimes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblYouHave = new System.Windows.Forms.Label();
            this.lblNumberOfTrials = new System.Windows.Forms.Label();
            this.lblTriesLeft = new System.Windows.Forms.Label();
            this.pbShowAndHidePassword = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblHour = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timerSec = new System.Windows.Forms.Timer(this.components);
            this.timerMin = new System.Windows.Forms.Timer(this.components);
            this.timerHour = new System.Windows.Forms.Timer(this.components);
            this.lblAMorPM = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblShowSecondsLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowAndHidePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(239, 267);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 31);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Tag = "khalidsliman2014@gmail.com";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(239, 341);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(330, 31);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Tag = "2522001soso";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(298, 396);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 42);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblYouHave
            // 
            this.lblYouHave.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouHave.ForeColor = System.Drawing.Color.Red;
            this.lblYouHave.Location = new System.Drawing.Point(237, 22);
            this.lblYouHave.Name = "lblYouHave";
            this.lblYouHave.Size = new System.Drawing.Size(121, 44);
            this.lblYouHave.TabIndex = 3;
            this.lblYouHave.Text = "You Have";
            this.lblYouHave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYouHave.Visible = false;
            // 
            // lblNumberOfTrials
            // 
            this.lblNumberOfTrials.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTrials.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfTrials.Location = new System.Drawing.Point(340, 22);
            this.lblNumberOfTrials.Name = "lblNumberOfTrials";
            this.lblNumberOfTrials.Size = new System.Drawing.Size(52, 44);
            this.lblNumberOfTrials.TabIndex = 4;
            this.lblNumberOfTrials.Tag = "3";
            this.lblNumberOfTrials.Text = "3";
            this.lblNumberOfTrials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumberOfTrials.Visible = false;
            // 
            // lblTriesLeft
            // 
            this.lblTriesLeft.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriesLeft.ForeColor = System.Drawing.Color.Red;
            this.lblTriesLeft.Location = new System.Drawing.Point(373, 22);
            this.lblTriesLeft.Name = "lblTriesLeft";
            this.lblTriesLeft.Size = new System.Drawing.Size(121, 44);
            this.lblTriesLeft.TabIndex = 5;
            this.lblTriesLeft.Text = "Tries Left";
            this.lblTriesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTriesLeft.Visible = false;
            // 
            // pbShowAndHidePassword
            // 
            this.pbShowAndHidePassword.BackColor = System.Drawing.SystemColors.Window;
            this.pbShowAndHidePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbShowAndHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowAndHidePassword.Image = global::MyFirstWinFormsProject.Properties.Resources.HidePassword;
            this.pbShowAndHidePassword.Location = new System.Drawing.Point(535, 341);
            this.pbShowAndHidePassword.Name = "pbShowAndHidePassword";
            this.pbShowAndHidePassword.Size = new System.Drawing.Size(34, 31);
            this.pbShowAndHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowAndHidePassword.TabIndex = 8;
            this.pbShowAndHidePassword.TabStop = false;
            this.pbShowAndHidePassword.Visible = false;
            this.pbShowAndHidePassword.Click += new System.EventHandler(this.pbShowAndHidePassword_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblHour
            // 
            this.lblHour.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(10, 7);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(39, 31);
            this.lblHour.TabIndex = 9;
            this.lblHour.Text = "00";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSec
            // 
            this.lblSec.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(89, 7);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(39, 31);
            this.lblSec.TabIndex = 10;
            this.lblSec.Text = "00";
            this.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            this.lblMin.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(49, 7);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(39, 31);
            this.lblMin.TabIndex = 11;
            this.lblMin.Text = "00";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = ":";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSec
            // 
            this.timerSec.Interval = 1000;
            this.timerSec.Tick += new System.EventHandler(this.timerSec_Tick);
            // 
            // timerMin
            // 
            this.timerMin.Interval = 1000;
            this.timerMin.Tick += new System.EventHandler(this.timerMin_Tick);
            // 
            // timerHour
            // 
            this.timerHour.Interval = 1000;
            this.timerHour.Tick += new System.EventHandler(this.timerHour_Tick);
            // 
            // lblAMorPM
            // 
            this.lblAMorPM.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMorPM.Location = new System.Drawing.Point(125, 7);
            this.lblAMorPM.Name = "lblAMorPM";
            this.lblAMorPM.Size = new System.Drawing.Size(39, 31);
            this.lblAMorPM.TabIndex = 14;
            this.lblAMorPM.Text = "AM";
            this.lblAMorPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(149, 41);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "00-00-0000";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(210, 184);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(350, 45);
            this.progressBar1.TabIndex = 17;
            this.progressBar1.Visible = false;
            // 
            // lblShowSecondsLeft
            // 
            this.lblShowSecondsLeft.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowSecondsLeft.Location = new System.Drawing.Point(287, 117);
            this.lblShowSecondsLeft.Name = "lblShowSecondsLeft";
            this.lblShowSecondsLeft.Size = new System.Drawing.Size(274, 53);
            this.lblShowSecondsLeft.TabIndex = 18;
            this.lblShowSecondsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShowSecondsLeft.Visible = false;
            // 
            // frmLoginScreenForThreeTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShowSecondsLeft);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAMorPM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.pbShowAndHidePassword);
            this.Controls.Add(this.lblTriesLeft);
            this.Controls.Add(this.lblYouHave);
            this.Controls.Add(this.lblNumberOfTrials);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLoginScreenForThreeTimes";
            this.Text = "frmLoginScreenForThreeTimes";
            this.Load += new System.EventHandler(this.frmLoginScreenForThreeTimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowAndHidePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblYouHave;
        private System.Windows.Forms.Label lblNumberOfTrials;
        private System.Windows.Forms.Label lblTriesLeft;
        private System.Windows.Forms.PictureBox pbShowAndHidePassword;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerSec;
        private System.Windows.Forms.Timer timerMin;
        private System.Windows.Forms.Timer timerHour;
        private System.Windows.Forms.Label lblAMorPM;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblShowSecondsLeft;
    }
}