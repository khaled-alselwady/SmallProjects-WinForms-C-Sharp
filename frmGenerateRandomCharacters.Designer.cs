namespace MyFirstWinFormsProject
{
    partial class frmGenerateRandomCharacters
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblNumberOfDigits = new System.Windows.Forms.Label();
            this.txtNumberOfDigits = new System.Windows.Forms.TextBox();
            this.chkLetters = new System.Windows.Forms.CheckBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.chkMix = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCopy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtText.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(25, 52);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(517, 98);
            this.txtText.TabIndex = 0;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.SystemColors.Control;
            this.btnOptions.FlatAppearance.BorderSize = 3;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(171, 179);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(97, 37);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.FlatAppearance.BorderSize = 3;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(380, 329);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(96, 43);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblNumberOfDigits
            // 
            this.lblNumberOfDigits.AutoSize = true;
            this.lblNumberOfDigits.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDigits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumberOfDigits.Location = new System.Drawing.Point(134, 252);
            this.lblNumberOfDigits.Name = "lblNumberOfDigits";
            this.lblNumberOfDigits.Size = new System.Drawing.Size(131, 16);
            this.lblNumberOfDigits.TabIndex = 3;
            this.lblNumberOfDigits.Text = "Number Of Digits";
            // 
            // txtNumberOfDigits
            // 
            this.txtNumberOfDigits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberOfDigits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNumberOfDigits.Location = new System.Drawing.Point(270, 251);
            this.txtNumberOfDigits.Name = "txtNumberOfDigits";
            this.txtNumberOfDigits.Size = new System.Drawing.Size(40, 20);
            this.txtNumberOfDigits.TabIndex = 4;
            // 
            // chkLetters
            // 
            this.chkLetters.AutoSize = true;
            this.chkLetters.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLetters.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkLetters.Location = new System.Drawing.Point(148, 310);
            this.chkLetters.Name = "chkLetters";
            this.chkLetters.Size = new System.Drawing.Size(74, 20);
            this.chkLetters.TabIndex = 5;
            this.chkLetters.Text = "Letters";
            this.chkLetters.UseVisualStyleBackColor = true;
            this.chkLetters.CheckedChanged += new System.EventHandler(this.chkLetters_CheckedChanged);
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSymbols.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkSymbols.Location = new System.Drawing.Point(148, 352);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(79, 20);
            this.chkSymbols.TabIndex = 6;
            this.chkSymbols.Text = "Symbols";
            this.chkSymbols.UseVisualStyleBackColor = true;
            this.chkSymbols.CheckedChanged += new System.EventHandler(this.chkSymbols_CheckedChanged);
            // 
            // chkMix
            // 
            this.chkMix.AutoSize = true;
            this.chkMix.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkMix.Location = new System.Drawing.Point(244, 352);
            this.chkMix.Name = "chkMix";
            this.chkMix.Size = new System.Drawing.Size(47, 20);
            this.chkMix.TabIndex = 8;
            this.chkMix.Text = "Mix";
            this.chkMix.UseVisualStyleBackColor = true;
            this.chkMix.CheckedChanged += new System.EventHandler(this.chkMix_CheckedChanged);
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumbers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkNumbers.Location = new System.Drawing.Point(244, 310);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(82, 20);
            this.chkNumbers.TabIndex = 7;
            this.chkNumbers.Text = "Numbers";
            this.chkNumbers.UseVisualStyleBackColor = true;
            this.chkNumbers.CheckedChanged += new System.EventHandler(this.chkNumbers_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(703, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 54);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.BorderSize = 3;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(692, 395);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 43);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCopy
            // 
            this.lblCopy.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopy.ForeColor = System.Drawing.Color.Blue;
            this.lblCopy.Location = new System.Drawing.Point(484, 133);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(38, 17);
            this.lblCopy.TabIndex = 11;
            this.lblCopy.Text = "copy";
            this.lblCopy.Visible = false;
            this.lblCopy.Click += new System.EventHandler(this.lblCopy_Click);
            // 
            // frmGenerateRandomCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkMix);
            this.Controls.Add(this.chkNumbers);
            this.Controls.Add(this.chkSymbols);
            this.Controls.Add(this.chkLetters);
            this.Controls.Add(this.txtNumberOfDigits);
            this.Controls.Add(this.lblNumberOfDigits);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.txtText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGenerateRandomCharacters";
            this.Text = "frmGenerateRandomCharacters";
            this.Load += new System.EventHandler(this.frmGenerateRandomCharacters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblNumberOfDigits;
        private System.Windows.Forms.TextBox txtNumberOfDigits;
        private System.Windows.Forms.CheckBox chkLetters;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.CheckBox chkMix;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCopy;
    }
}