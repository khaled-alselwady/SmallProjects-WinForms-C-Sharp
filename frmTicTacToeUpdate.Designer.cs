namespace MyFirstWinFormsProject
{
    partial class frmTicTacToeUpdate
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.lblTicTacToe = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbTwoPlayer = new System.Windows.Forms.RadioButton();
            this.rbOnePlayer = new System.Windows.Forms.RadioButton();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.txtNameTwo = new System.Windows.Forms.TextBox();
            this.lblNameTwo = new System.Windows.Forms.Label();
            this.txtNameOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLevel = new System.Windows.Forms.GroupBox();
            this.combLevel = new System.Windows.Forms.ComboBox();
            this.gbRounds = new System.Windows.Forms.GroupBox();
            this.combRounds = new System.Windows.Forms.ComboBox();
            this.gbLetter = new System.Windows.Forms.GroupBox();
            this.rbO = new System.Windows.Forms.RadioButton();
            this.rbX = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameOfPlayerOne = new System.Windows.Forms.Label();
            this.lblWinPlayerOne = new System.Windows.Forms.Label();
            this.lblNumberOfWinningPlayerOne = new System.Windows.Forms.Label();
            this.lblWinPlayerTwo = new System.Windows.Forms.Label();
            this.lblNumberOfWinningPlayerTwo = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblNumberOfDraw = new System.Windows.Forms.Label();
            this.lblNameOfPlayerTwo = new System.Windows.Forms.Label();
            this.btnLetterPlayerOne = new System.Windows.Forms.Button();
            this.btnLetterPlayerTwo = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pbDesign = new System.Windows.Forms.PictureBox();
            this.pbCrownPlayerOne = new System.Windows.Forms.PictureBox();
            this.pbCrownPlayerTwo = new System.Windows.Forms.PictureBox();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblNumberOfCurrentRound = new System.Windows.Forms.Label();
            this.lblSlash = new System.Windows.Forms.Label();
            this.lblNumberOfRounds = new System.Windows.Forms.Label();
            this.gbMode.SuspendLayout();
            this.gbName.SuspendLayout();
            this.gbLevel.SuspendLayout();
            this.gbRounds.SuspendLayout();
            this.gbLetter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrownPlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrownPlayerTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(672, 352);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 49);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(672, 430);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(113, 49);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // lblTicTacToe
            // 
            this.lblTicTacToe.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacToe.ForeColor = System.Drawing.Color.Red;
            this.lblTicTacToe.Location = new System.Drawing.Point(405, 50);
            this.lblTicTacToe.Name = "lblTicTacToe";
            this.lblTicTacToe.Size = new System.Drawing.Size(617, 104);
            this.lblTicTacToe.TabIndex = 2;
            this.lblTicTacToe.Text = "TIC.TAC.TOE";
            // 
            // lblOptions
            // 
            this.lblOptions.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.Color.Red;
            this.lblOptions.Location = new System.Drawing.Point(363, 67);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(670, 97);
            this.lblOptions.TabIndex = 3;
            this.lblOptions.Text = "Game Options Screen";
            this.lblOptions.Visible = false;
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbTwoPlayer);
            this.gbMode.Controls.Add(this.rbOnePlayer);
            this.gbMode.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMode.ForeColor = System.Drawing.Color.White;
            this.gbMode.Location = new System.Drawing.Point(310, 190);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(317, 123);
            this.gbMode.TabIndex = 4;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Mode";
            this.gbMode.Visible = false;
            // 
            // rbTwoPlayer
            // 
            this.rbTwoPlayer.AutoSize = true;
            this.rbTwoPlayer.Location = new System.Drawing.Point(173, 58);
            this.rbTwoPlayer.Name = "rbTwoPlayer";
            this.rbTwoPlayer.Size = new System.Drawing.Size(105, 29);
            this.rbTwoPlayer.TabIndex = 1;
            this.rbTwoPlayer.TabStop = true;
            this.rbTwoPlayer.Text = "2 Player";
            this.rbTwoPlayer.UseVisualStyleBackColor = true;
            this.rbTwoPlayer.CheckedChanged += new System.EventHandler(this.rbTwoPlayer_CheckedChanged);
            // 
            // rbOnePlayer
            // 
            this.rbOnePlayer.AutoSize = true;
            this.rbOnePlayer.Location = new System.Drawing.Point(20, 58);
            this.rbOnePlayer.Name = "rbOnePlayer";
            this.rbOnePlayer.Size = new System.Drawing.Size(105, 29);
            this.rbOnePlayer.TabIndex = 0;
            this.rbOnePlayer.TabStop = true;
            this.rbOnePlayer.Tag = "true";
            this.rbOnePlayer.Text = "1 Player";
            this.rbOnePlayer.UseVisualStyleBackColor = true;
            this.rbOnePlayer.CheckedChanged += new System.EventHandler(this.rbOnePlayer_CheckedChanged);
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.txtNameTwo);
            this.gbName.Controls.Add(this.lblNameTwo);
            this.gbName.Controls.Add(this.txtNameOne);
            this.gbName.Controls.Add(this.label1);
            this.gbName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbName.ForeColor = System.Drawing.Color.White;
            this.gbName.Location = new System.Drawing.Point(698, 190);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(363, 123);
            this.gbName.TabIndex = 5;
            this.gbName.TabStop = false;
            this.gbName.Text = "Name";
            this.gbName.Visible = false;
            // 
            // txtNameTwo
            // 
            this.txtNameTwo.BackColor = System.Drawing.Color.Black;
            this.txtNameTwo.ForeColor = System.Drawing.Color.White;
            this.txtNameTwo.Location = new System.Drawing.Point(209, 68);
            this.txtNameTwo.Name = "txtNameTwo";
            this.txtNameTwo.Size = new System.Drawing.Size(142, 33);
            this.txtNameTwo.TabIndex = 3;
            this.txtNameTwo.Visible = false;
            // 
            // lblNameTwo
            // 
            this.lblNameTwo.AutoSize = true;
            this.lblNameTwo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTwo.Location = new System.Drawing.Point(209, 45);
            this.lblNameTwo.Name = "lblNameTwo";
            this.lblNameTwo.Size = new System.Drawing.Size(60, 18);
            this.lblNameTwo.TabIndex = 2;
            this.lblNameTwo.Text = "Name 2";
            this.lblNameTwo.Visible = false;
            // 
            // txtNameOne
            // 
            this.txtNameOne.BackColor = System.Drawing.Color.Black;
            this.txtNameOne.ForeColor = System.Drawing.Color.White;
            this.txtNameOne.Location = new System.Drawing.Point(27, 68);
            this.txtNameOne.Name = "txtNameOne";
            this.txtNameOne.Size = new System.Drawing.Size(142, 33);
            this.txtNameOne.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name 1";
            // 
            // gbLevel
            // 
            this.gbLevel.Controls.Add(this.combLevel);
            this.gbLevel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLevel.ForeColor = System.Drawing.Color.White;
            this.gbLevel.Location = new System.Drawing.Point(310, 347);
            this.gbLevel.Name = "gbLevel";
            this.gbLevel.Size = new System.Drawing.Size(225, 93);
            this.gbLevel.TabIndex = 5;
            this.gbLevel.TabStop = false;
            this.gbLevel.Text = "Level";
            this.gbLevel.Visible = false;
            // 
            // combLevel
            // 
            this.combLevel.BackColor = System.Drawing.Color.Black;
            this.combLevel.ForeColor = System.Drawing.Color.White;
            this.combLevel.FormattingEnabled = true;
            this.combLevel.Items.AddRange(new object[] {
            "Easy",
            "Hard"});
            this.combLevel.Location = new System.Drawing.Point(20, 41);
            this.combLevel.Name = "combLevel";
            this.combLevel.Size = new System.Drawing.Size(184, 33);
            this.combLevel.TabIndex = 1;
            this.combLevel.Tag = "true";
            this.combLevel.Visible = false;
            // 
            // gbRounds
            // 
            this.gbRounds.Controls.Add(this.combRounds);
            this.gbRounds.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRounds.ForeColor = System.Drawing.Color.White;
            this.gbRounds.Location = new System.Drawing.Point(595, 352);
            this.gbRounds.Name = "gbRounds";
            this.gbRounds.Size = new System.Drawing.Size(225, 93);
            this.gbRounds.TabIndex = 6;
            this.gbRounds.TabStop = false;
            this.gbRounds.Text = "Rounds";
            this.gbRounds.Visible = false;
            // 
            // combRounds
            // 
            this.combRounds.BackColor = System.Drawing.Color.Black;
            this.combRounds.ForeColor = System.Drawing.Color.White;
            this.combRounds.FormattingEnabled = true;
            this.combRounds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.combRounds.Location = new System.Drawing.Point(20, 41);
            this.combRounds.Name = "combRounds";
            this.combRounds.Size = new System.Drawing.Size(184, 33);
            this.combRounds.TabIndex = 0;
            // 
            // gbLetter
            // 
            this.gbLetter.Controls.Add(this.rbO);
            this.gbLetter.Controls.Add(this.rbX);
            this.gbLetter.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLetter.ForeColor = System.Drawing.Color.White;
            this.gbLetter.Location = new System.Drawing.Point(846, 352);
            this.gbLetter.Name = "gbLetter";
            this.gbLetter.Size = new System.Drawing.Size(225, 93);
            this.gbLetter.TabIndex = 7;
            this.gbLetter.TabStop = false;
            this.gbLetter.Text = "P1 Letter";
            this.gbLetter.Visible = false;
            // 
            // rbO
            // 
            this.rbO.AutoSize = true;
            this.rbO.Location = new System.Drawing.Point(140, 40);
            this.rbO.Name = "rbO";
            this.rbO.Size = new System.Drawing.Size(45, 29);
            this.rbO.TabIndex = 3;
            this.rbO.TabStop = true;
            this.rbO.Text = "O";
            this.rbO.UseVisualStyleBackColor = true;
            // 
            // rbX
            // 
            this.rbX.AutoSize = true;
            this.rbX.Location = new System.Drawing.Point(34, 40);
            this.rbX.Name = "rbX";
            this.rbX.Size = new System.Drawing.Size(42, 29);
            this.rbX.TabIndex = 2;
            this.rbX.TabStop = true;
            this.rbX.Text = "X";
            this.rbX.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(614, 529);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(148, 49);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // lblNameOfPlayerOne
            // 
            this.lblNameOfPlayerOne.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfPlayerOne.ForeColor = System.Drawing.Color.White;
            this.lblNameOfPlayerOne.Location = new System.Drawing.Point(45, 386);
            this.lblNameOfPlayerOne.Name = "lblNameOfPlayerOne";
            this.lblNameOfPlayerOne.Size = new System.Drawing.Size(163, 46);
            this.lblNameOfPlayerOne.TabIndex = 15;
            this.lblNameOfPlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameOfPlayerOne.Visible = false;
            // 
            // lblWinPlayerOne
            // 
            this.lblWinPlayerOne.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinPlayerOne.ForeColor = System.Drawing.Color.White;
            this.lblWinPlayerOne.Location = new System.Drawing.Point(352, 640);
            this.lblWinPlayerOne.Name = "lblWinPlayerOne";
            this.lblWinPlayerOne.Size = new System.Drawing.Size(86, 35);
            this.lblWinPlayerOne.TabIndex = 17;
            this.lblWinPlayerOne.Text = "Win :";
            this.lblWinPlayerOne.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblWinPlayerOne.Visible = false;
            // 
            // lblNumberOfWinningPlayerOne
            // 
            this.lblNumberOfWinningPlayerOne.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfWinningPlayerOne.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfWinningPlayerOne.Location = new System.Drawing.Point(459, 640);
            this.lblNumberOfWinningPlayerOne.Name = "lblNumberOfWinningPlayerOne";
            this.lblNumberOfWinningPlayerOne.Size = new System.Drawing.Size(51, 35);
            this.lblNumberOfWinningPlayerOne.TabIndex = 18;
            this.lblNumberOfWinningPlayerOne.Text = "0";
            this.lblNumberOfWinningPlayerOne.Visible = false;
            // 
            // lblWinPlayerTwo
            // 
            this.lblWinPlayerTwo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinPlayerTwo.ForeColor = System.Drawing.Color.White;
            this.lblWinPlayerTwo.Location = new System.Drawing.Point(843, 640);
            this.lblWinPlayerTwo.Name = "lblWinPlayerTwo";
            this.lblWinPlayerTwo.Size = new System.Drawing.Size(86, 35);
            this.lblWinPlayerTwo.TabIndex = 19;
            this.lblWinPlayerTwo.Text = ": Win";
            this.lblWinPlayerTwo.Visible = false;
            // 
            // lblNumberOfWinningPlayerTwo
            // 
            this.lblNumberOfWinningPlayerTwo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfWinningPlayerTwo.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfWinningPlayerTwo.Location = new System.Drawing.Point(773, 640);
            this.lblNumberOfWinningPlayerTwo.Name = "lblNumberOfWinningPlayerTwo";
            this.lblNumberOfWinningPlayerTwo.Size = new System.Drawing.Size(51, 35);
            this.lblNumberOfWinningPlayerTwo.TabIndex = 20;
            this.lblNumberOfWinningPlayerTwo.Text = "0";
            this.lblNumberOfWinningPlayerTwo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblNumberOfWinningPlayerTwo.Visible = false;
            // 
            // lblDraw
            // 
            this.lblDraw.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.ForeColor = System.Drawing.Color.White;
            this.lblDraw.Location = new System.Drawing.Point(603, 640);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(86, 35);
            this.lblDraw.TabIndex = 21;
            this.lblDraw.Text = "Draw";
            this.lblDraw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDraw.Visible = false;
            // 
            // lblNumberOfDraw
            // 
            this.lblNumberOfDraw.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDraw.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfDraw.Location = new System.Drawing.Point(619, 592);
            this.lblNumberOfDraw.Name = "lblNumberOfDraw";
            this.lblNumberOfDraw.Size = new System.Drawing.Size(51, 35);
            this.lblNumberOfDraw.TabIndex = 22;
            this.lblNumberOfDraw.Text = "0";
            this.lblNumberOfDraw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNumberOfDraw.Visible = false;
            // 
            // lblNameOfPlayerTwo
            // 
            this.lblNameOfPlayerTwo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfPlayerTwo.ForeColor = System.Drawing.Color.White;
            this.lblNameOfPlayerTwo.Location = new System.Drawing.Point(1051, 386);
            this.lblNameOfPlayerTwo.Name = "lblNameOfPlayerTwo";
            this.lblNameOfPlayerTwo.Size = new System.Drawing.Size(163, 46);
            this.lblNameOfPlayerTwo.TabIndex = 16;
            this.lblNameOfPlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameOfPlayerTwo.Visible = false;
            // 
            // btnLetterPlayerOne
            // 
            this.btnLetterPlayerOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetterPlayerOne.Location = new System.Drawing.Point(71, 258);
            this.btnLetterPlayerOne.Name = "btnLetterPlayerOne";
            this.btnLetterPlayerOne.Size = new System.Drawing.Size(126, 108);
            this.btnLetterPlayerOne.TabIndex = 34;
            this.btnLetterPlayerOne.UseVisualStyleBackColor = true;
            // 
            // btnLetterPlayerTwo
            // 
            this.btnLetterPlayerTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetterPlayerTwo.Location = new System.Drawing.Point(1067, 258);
            this.btnLetterPlayerTwo.Name = "btnLetterPlayerTwo";
            this.btnLetterPlayerTwo.Size = new System.Drawing.Size(126, 108);
            this.btnLetterPlayerTwo.TabIndex = 35;
            this.btnLetterPlayerTwo.UseVisualStyleBackColor = true;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(432, 74);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(96, 104);
            this.pb1.TabIndex = 32;
            this.pb1.TabStop = false;
            this.pb1.Tag = "?";
            this.pb1.Visible = false;
            this.pb1.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb9
            // 
            this.pb9.Location = new System.Drawing.Point(758, 379);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(96, 104);
            this.pb9.TabIndex = 31;
            this.pb9.TabStop = false;
            this.pb9.Tag = "?";
            this.pb9.Visible = false;
            this.pb9.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb8
            // 
            this.pb8.Location = new System.Drawing.Point(593, 379);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(96, 104);
            this.pb8.TabIndex = 30;
            this.pb8.TabStop = false;
            this.pb8.Tag = "?";
            this.pb8.Visible = false;
            this.pb8.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(432, 379);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(96, 104);
            this.pb7.TabIndex = 29;
            this.pb7.TabStop = false;
            this.pb7.Tag = "?";
            this.pb7.Visible = false;
            this.pb7.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(759, 226);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(96, 104);
            this.pb6.TabIndex = 28;
            this.pb6.TabStop = false;
            this.pb6.Tag = "?";
            this.pb6.Visible = false;
            this.pb6.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(593, 226);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(96, 104);
            this.pb5.TabIndex = 27;
            this.pb5.TabStop = false;
            this.pb5.Tag = "?";
            this.pb5.Visible = false;
            this.pb5.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(431, 226);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(96, 104);
            this.pb4.TabIndex = 26;
            this.pb4.TabStop = false;
            this.pb4.Tag = "?";
            this.pb4.Visible = false;
            this.pb4.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(758, 74);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(96, 104);
            this.pb3.TabIndex = 25;
            this.pb3.TabStop = false;
            this.pb3.Tag = "?";
            this.pb3.Visible = false;
            this.pb3.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(593, 74);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(96, 104);
            this.pb2.TabIndex = 24;
            this.pb2.TabStop = false;
            this.pb2.Tag = "?";
            this.pb2.Visible = false;
            this.pb2.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbDesign
            // 
            this.pbDesign.Image = global::MyFirstWinFormsProject.Properties.Resources.TicTacToeDesign;
            this.pbDesign.Location = new System.Drawing.Point(329, 37);
            this.pbDesign.Name = "pbDesign";
            this.pbDesign.Size = new System.Drawing.Size(620, 467);
            this.pbDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDesign.TabIndex = 33;
            this.pbDesign.TabStop = false;
            this.pbDesign.Visible = false;
            // 
            // pbCrownPlayerOne
            // 
            this.pbCrownPlayerOne.Image = global::MyFirstWinFormsProject.Properties.Resources.crown;
            this.pbCrownPlayerOne.Location = new System.Drawing.Point(77, 162);
            this.pbCrownPlayerOne.Name = "pbCrownPlayerOne";
            this.pbCrownPlayerOne.Size = new System.Drawing.Size(106, 73);
            this.pbCrownPlayerOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCrownPlayerOne.TabIndex = 0;
            this.pbCrownPlayerOne.TabStop = false;
            this.pbCrownPlayerOne.Visible = false;
            // 
            // pbCrownPlayerTwo
            // 
            this.pbCrownPlayerTwo.Image = global::MyFirstWinFormsProject.Properties.Resources.crown;
            this.pbCrownPlayerTwo.Location = new System.Drawing.Point(1076, 162);
            this.pbCrownPlayerTwo.Name = "pbCrownPlayerTwo";
            this.pbCrownPlayerTwo.Size = new System.Drawing.Size(106, 73);
            this.pbCrownPlayerTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCrownPlayerTwo.TabIndex = 36;
            this.pbCrownPlayerTwo.TabStop = false;
            this.pbCrownPlayerTwo.Visible = false;
            // 
            // lblRound
            // 
            this.lblRound.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.White;
            this.lblRound.Location = new System.Drawing.Point(525, -1);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(128, 28);
            this.lblRound.TabIndex = 37;
            this.lblRound.Text = "Round :";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblRound.Visible = false;
            // 
            // lblNumberOfCurrentRound
            // 
            this.lblNumberOfCurrentRound.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCurrentRound.ForeColor = System.Drawing.Color.Lime;
            this.lblNumberOfCurrentRound.Location = new System.Drawing.Point(642, -2);
            this.lblNumberOfCurrentRound.Name = "lblNumberOfCurrentRound";
            this.lblNumberOfCurrentRound.Size = new System.Drawing.Size(48, 34);
            this.lblNumberOfCurrentRound.TabIndex = 38;
            this.lblNumberOfCurrentRound.Text = "1";
            this.lblNumberOfCurrentRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumberOfCurrentRound.Visible = false;
            // 
            // lblSlash
            // 
            this.lblSlash.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlash.ForeColor = System.Drawing.Color.White;
            this.lblSlash.Location = new System.Drawing.Point(681, -2);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(32, 34);
            this.lblSlash.TabIndex = 39;
            this.lblSlash.Text = "/";
            this.lblSlash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSlash.Visible = false;
            // 
            // lblNumberOfRounds
            // 
            this.lblNumberOfRounds.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRounds.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfRounds.Location = new System.Drawing.Point(703, -2);
            this.lblNumberOfRounds.Name = "lblNumberOfRounds";
            this.lblNumberOfRounds.Size = new System.Drawing.Size(48, 34);
            this.lblNumberOfRounds.TabIndex = 40;
            this.lblNumberOfRounds.Text = "0";
            this.lblNumberOfRounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumberOfRounds.Visible = false;
            // 
            // frmTicTacToeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1377, 751);
            this.Controls.Add(this.lblNumberOfRounds);
            this.Controls.Add(this.lblSlash);
            this.Controls.Add(this.lblNumberOfCurrentRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.pbCrownPlayerTwo);
            this.Controls.Add(this.pbCrownPlayerOne);
            this.Controls.Add(this.btnLetterPlayerTwo);
            this.Controls.Add(this.btnLetterPlayerOne);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.lblNumberOfDraw);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblNumberOfWinningPlayerTwo);
            this.Controls.Add(this.lblWinPlayerTwo);
            this.Controls.Add(this.lblNumberOfWinningPlayerOne);
            this.Controls.Add(this.lblWinPlayerOne);
            this.Controls.Add(this.lblNameOfPlayerTwo);
            this.Controls.Add(this.lblNameOfPlayerOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbLetter);
            this.Controls.Add(this.gbRounds);
            this.Controls.Add(this.gbLevel);
            this.Controls.Add(this.gbName);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblTicTacToe);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbDesign);
            this.Name = "frmTicTacToeUpdate";
            this.Tag = "false";
            this.Text = "frmTicTacToeUpdate";
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.gbLevel.ResumeLayout(false);
            this.gbRounds.ResumeLayout(false);
            this.gbLetter.ResumeLayout(false);
            this.gbLetter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrownPlayerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrownPlayerTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Label lblTicTacToe;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbTwoPlayer;
        private System.Windows.Forms.RadioButton rbOnePlayer;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox txtNameTwo;
        private System.Windows.Forms.Label lblNameTwo;
        private System.Windows.Forms.TextBox txtNameOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLevel;
        private System.Windows.Forms.ComboBox combLevel;
        private System.Windows.Forms.GroupBox gbRounds;
        private System.Windows.Forms.ComboBox combRounds;
        private System.Windows.Forms.GroupBox gbLetter;
        private System.Windows.Forms.RadioButton rbO;
        private System.Windows.Forms.RadioButton rbX;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameOfPlayerOne;
        private System.Windows.Forms.Label lblWinPlayerOne;
        private System.Windows.Forms.Label lblNumberOfWinningPlayerOne;
        private System.Windows.Forms.Label lblWinPlayerTwo;
        private System.Windows.Forms.Label lblNumberOfWinningPlayerTwo;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Label lblNumberOfDraw;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lblNameOfPlayerTwo;
        private System.Windows.Forms.PictureBox pbDesign;
        private System.Windows.Forms.Button btnLetterPlayerOne;
        private System.Windows.Forms.Button btnLetterPlayerTwo;
        private System.Windows.Forms.PictureBox pbCrownPlayerOne;
        private System.Windows.Forms.PictureBox pbCrownPlayerTwo;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblNumberOfCurrentRound;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.Label lblNumberOfRounds;
    }
}