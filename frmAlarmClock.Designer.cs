namespace MyFirstWinFormsProject
{
    partial class frmAlarmClock
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
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.timerSec = new System.Windows.Forms.Timer(this.components);
            this.timerMin = new System.Windows.Forms.Timer(this.components);
            this.timerHour = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerSet = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHour
            // 
            this.lblHour.Font = new System.Drawing.Font("SimSun", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.Blue;
            this.lblHour.Location = new System.Drawing.Point(272, 57);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(68, 64);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "00";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            this.lblMin.Font = new System.Drawing.Font("SimSun", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.Blue;
            this.lblMin.Location = new System.Drawing.Point(334, 57);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(67, 64);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "00";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSec
            // 
            this.lblSec.Font = new System.Drawing.Font("SimSun", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.Blue;
            this.lblSec.Location = new System.Drawing.Point(395, 57);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(67, 64);
            this.lblSec.TabIndex = 2;
            this.lblSec.Text = "00";
            this.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(325, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(386, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(108, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set Alarm Time :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 20F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Location = new System.Drawing.Point(313, 303);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(116, 38);
            this.btnSetAlarm.TabIndex = 8;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // timerSec
            // 
            this.timerSec.Interval = 1000;
            this.timerSec.Tick += new System.EventHandler(this.timerSec_Tick_1);
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
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // TimerSet
            // 
            this.TimerSet.Tick += new System.EventHandler(this.TimerSet_Tick);
            // 
            // frmAlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSetAlarm);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Name = "frmAlarmClock";
            this.Text = "Alarm Clock";
            this.Load += new System.EventHandler(this.frmAlarmClock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.Timer timerSec;
        private System.Windows.Forms.Timer timerMin;
        private System.Windows.Forms.Timer timerHour;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer TimerSet;
    }
}