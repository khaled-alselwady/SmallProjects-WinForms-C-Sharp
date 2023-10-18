namespace MyFirstWinFormsProject
{
    partial class frmMoveItems
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxChoices = new System.Windows.Forms.ComboBox();
            this.btnToListBox = new System.Windows.Forms.Button();
            this.btnToComboBox = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(275, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Challenge!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Move Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(270, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(392, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(430, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Left DropDown List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(288, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "Right List Box";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(217, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(60, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 35);
            this.label7.TabIndex = 6;
            this.label7.Text = "Select Group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(550, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 35);
            this.label8.TabIndex = 7;
            this.label8.Text = "Clients / Groups";
            // 
            // cboxChoices
            // 
            this.cboxChoices.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxChoices.FormattingEnabled = true;
            this.cboxChoices.Items.AddRange(new object[] {
            "Group1",
            "Group2",
            "Group3"});
            this.cboxChoices.Location = new System.Drawing.Point(81, 335);
            this.cboxChoices.Name = "cboxChoices";
            this.cboxChoices.Size = new System.Drawing.Size(192, 41);
            this.cboxChoices.TabIndex = 8;
            // 
            // btnToListBox
            // 
            this.btnToListBox.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnToListBox.Location = new System.Drawing.Point(243, 277);
            this.btnToListBox.Name = "btnToListBox";
            this.btnToListBox.Size = new System.Drawing.Size(39, 40);
            this.btnToListBox.TabIndex = 9;
            this.btnToListBox.Text = ">";
            this.btnToListBox.UseVisualStyleBackColor = true;
            this.btnToListBox.Click += new System.EventHandler(this.btnToListBox_Click);
            // 
            // btnToComboBox
            // 
            this.btnToComboBox.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnToComboBox.Location = new System.Drawing.Point(498, 277);
            this.btnToComboBox.Name = "btnToComboBox";
            this.btnToComboBox.Size = new System.Drawing.Size(39, 40);
            this.btnToComboBox.TabIndex = 10;
            this.btnToComboBox.Text = "<";
            this.btnToComboBox.UseVisualStyleBackColor = true;
            this.btnToComboBox.Click += new System.EventHandler(this.btnToComboBox_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(556, 335);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 108);
            this.listBox1.TabIndex = 11;
            // 
            // frmMoveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnToComboBox);
            this.Controls.Add(this.btnToListBox);
            this.Controls.Add(this.cboxChoices);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMoveItems";
            this.Text = "frmMoveItems";
            this.Load += new System.EventHandler(this.frmMoveItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxChoices;
        private System.Windows.Forms.Button btnToListBox;
        private System.Windows.Forms.Button btnToComboBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}