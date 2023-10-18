namespace MyFirstWinFormsProject
{
    partial class frmCheckListBox
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnForm1 = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.btnForm4 = new System.Windows.Forms.Button();
            this.btnForm5 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Form 1",
            "Form 2",
            "Form 3",
            "Form 4",
            "Form 5"});
            this.checkedListBox1.Location = new System.Drawing.Point(318, 204);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(107, 54);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnForm1
            // 
            this.btnForm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm1.Font = new System.Drawing.Font("Tahoma", 17F);
            this.btnForm1.Location = new System.Drawing.Point(92, 322);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(107, 50);
            this.btnForm1.TabIndex = 1;
            this.btnForm1.Tag = "Form 1";
            this.btnForm1.Text = "Form 1";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm2.Font = new System.Drawing.Font("Tahoma", 17F);
            this.btnForm2.Location = new System.Drawing.Point(205, 322);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(107, 50);
            this.btnForm2.TabIndex = 2;
            this.btnForm2.Tag = "Form 2";
            this.btnForm2.Text = "Form 2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm3.Font = new System.Drawing.Font("Tahoma", 17F);
            this.btnForm3.Location = new System.Drawing.Point(318, 322);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(107, 50);
            this.btnForm3.TabIndex = 3;
            this.btnForm3.Tag = "Form 3";
            this.btnForm3.Text = "Form 3";
            this.btnForm3.UseVisualStyleBackColor = true;
            this.btnForm3.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnForm4
            // 
            this.btnForm4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm4.Font = new System.Drawing.Font("Tahoma", 17F);
            this.btnForm4.Location = new System.Drawing.Point(431, 322);
            this.btnForm4.Name = "btnForm4";
            this.btnForm4.Size = new System.Drawing.Size(107, 50);
            this.btnForm4.TabIndex = 4;
            this.btnForm4.Tag = "Form 4";
            this.btnForm4.Text = "Form 4";
            this.btnForm4.UseVisualStyleBackColor = true;
            this.btnForm4.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnForm5
            // 
            this.btnForm5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm5.Font = new System.Drawing.Font("Tahoma", 17F);
            this.btnForm5.Location = new System.Drawing.Point(544, 322);
            this.btnForm5.Name = "btnForm5";
            this.btnForm5.Size = new System.Drawing.Size(107, 50);
            this.btnForm5.TabIndex = 5;
            this.btnForm5.Tag = "Form 5";
            this.btnForm5.Text = "Form 5";
            this.btnForm5.UseVisualStyleBackColor = true;
            this.btnForm5.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmCheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForm5);
            this.Controls.Add(this.btnForm4);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnForm1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "frmCheckListBox";
            this.Text = "frmCheckListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button btnForm3;
        private System.Windows.Forms.Button btnForm4;
        private System.Windows.Forms.Button btnForm5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}