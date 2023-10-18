namespace MyFirstWinFormsProject
{
    partial class frmToDoList
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAddNewTask = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpShowAllTasks = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tpSearchForTask = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchForTask = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDiscriptionSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tpAboutMe = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAboutMe = new System.Windows.Forms.Button();
            this.btnShowAllTasks = new System.Windows.Forms.Button();
            this.btnSearchForTask = new System.Windows.Forms.Button();
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpAddNewTask.SuspendLayout();
            this.tpShowAllTasks.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tpSearchForTask.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tpAddNewTask);
            this.tabControl1.Controls.Add(this.tpShowAllTasks);
            this.tabControl1.Controls.Add(this.tpSearchForTask);
            this.tabControl1.Controls.Add(this.tpAboutMe);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(188, -5);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 557);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tpAddNewTask
            // 
            this.tpAddNewTask.BackColor = System.Drawing.Color.Black;
            this.tpAddNewTask.Controls.Add(this.dateTimePicker1);
            this.tpAddNewTask.Controls.Add(this.label4);
            this.tpAddNewTask.Controls.Add(this.txtTaskTitle);
            this.tpAddNewTask.Controls.Add(this.btnAdd);
            this.tpAddNewTask.Controls.Add(this.btnReset);
            this.tpAddNewTask.Controls.Add(this.label6);
            this.tpAddNewTask.Controls.Add(this.txtDiscription);
            this.tpAddNewTask.Controls.Add(this.label5);
            this.tpAddNewTask.Controls.Add(this.label3);
            this.tpAddNewTask.Controls.Add(this.label2);
            this.tpAddNewTask.Controls.Add(this.label1);
            this.tpAddNewTask.Location = new System.Drawing.Point(4, 5);
            this.tpAddNewTask.Name = "tpAddNewTask";
            this.tpAddNewTask.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddNewTask.Size = new System.Drawing.Size(785, 548);
            this.tpAddNewTask.TabIndex = 0;
            this.tpAddNewTask.Text = "tabPage1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(558, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 24);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(391, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Promised Time:";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTaskTitle.Location = new System.Drawing.Point(152, 176);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(196, 27);
            this.txtTaskTitle.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnAdd.Location = new System.Drawing.Point(490, 407);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 64);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnReset.Location = new System.Drawing.Point(178, 407);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 64);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(532, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "100 Letter Only";
            // 
            // txtDiscription
            // 
            this.txtDiscription.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDiscription.Location = new System.Drawing.Point(220, 256);
            this.txtDiscription.MaxLength = 100;
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(394, 99);
            this.txtDiscription.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Task Discription:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Task Tilte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(248, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 33);
            this.label2.TabIndex = 25;
            this.label2.Text = "Add New Task Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "To_Do_List";
            // 
            // tpShowAllTasks
            // 
            this.tpShowAllTasks.BackColor = System.Drawing.Color.Black;
            this.tpShowAllTasks.Controls.Add(this.listView1);
            this.tpShowAllTasks.Controls.Add(this.label8);
            this.tpShowAllTasks.Controls.Add(this.label7);
            this.tpShowAllTasks.Location = new System.Drawing.Point(4, 5);
            this.tpShowAllTasks.Name = "tpShowAllTasks";
            this.tpShowAllTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowAllTasks.Size = new System.Drawing.Size(785, 548);
            this.tpShowAllTasks.TabIndex = 1;
            this.tpShowAllTasks.Text = "tabPage2";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Gray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 198);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(784, 294);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Task Title";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Task Description";
            this.columnHeader2.Width = 507;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Promised Time";
            this.columnHeader3.Width = 133;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(293, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 33);
            this.label8.TabIndex = 27;
            this.label8.Text = "To_Do_List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(241, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 33);
            this.label7.TabIndex = 26;
            this.label7.Text = "Show All Tasks Form";
            // 
            // tpSearchForTask
            // 
            this.tpSearchForTask.BackColor = System.Drawing.Color.Black;
            this.tpSearchForTask.Controls.Add(this.dateTimePicker2);
            this.tpSearchForTask.Controls.Add(this.label9);
            this.tpSearchForTask.Controls.Add(this.txtSearchForTask);
            this.tpSearchForTask.Controls.Add(this.btnSearch);
            this.tpSearchForTask.Controls.Add(this.txtDiscriptionSearch);
            this.tpSearchForTask.Controls.Add(this.label10);
            this.tpSearchForTask.Controls.Add(this.label12);
            this.tpSearchForTask.Controls.Add(this.label13);
            this.tpSearchForTask.Controls.Add(this.label14);
            this.tpSearchForTask.Location = new System.Drawing.Point(4, 5);
            this.tpSearchForTask.Name = "tpSearchForTask";
            this.tpSearchForTask.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchForTask.Size = new System.Drawing.Size(785, 548);
            this.tpSearchForTask.TabIndex = 2;
            this.tpSearchForTask.Text = "tabPage3";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(221, 288);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 24);
            this.dateTimePicker2.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(50, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 24);
            this.label9.TabIndex = 46;
            this.label9.Text = "Promised Time:";
            // 
            // txtSearchForTask
            // 
            this.txtSearchForTask.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSearchForTask.Location = new System.Drawing.Point(313, 177);
            this.txtSearchForTask.Name = "txtSearchForTask";
            this.txtSearchForTask.Size = new System.Drawing.Size(244, 27);
            this.txtSearchForTask.TabIndex = 45;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSearch.Location = new System.Drawing.Point(574, 177);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 28);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDiscriptionSearch
            // 
            this.txtDiscriptionSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDiscriptionSearch.Location = new System.Drawing.Point(221, 323);
            this.txtDiscriptionSearch.MaxLength = 100;
            this.txtDiscriptionSearch.Multiline = true;
            this.txtDiscriptionSearch.Name = "txtDiscriptionSearch";
            this.txtDiscriptionSearch.ReadOnly = true;
            this.txtDiscriptionSearch.Size = new System.Drawing.Size(394, 99);
            this.txtDiscriptionSearch.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(41, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 24);
            this.label10.TabIndex = 40;
            this.label10.Text = "Task Discription:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(41, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 24);
            this.label12.TabIndex = 37;
            this.label12.Text = "Enter The Task Title Here:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(248, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(275, 33);
            this.label13.TabIndex = 36;
            this.label13.Text = "Search For Task Form";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(295, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 33);
            this.label14.TabIndex = 35;
            this.label14.Text = "To_Do_List";
            // 
            // tpAboutMe
            // 
            this.tpAboutMe.BackColor = System.Drawing.Color.Black;
            this.tpAboutMe.Location = new System.Drawing.Point(4, 5);
            this.tpAboutMe.Name = "tpAboutMe";
            this.tpAboutMe.Padding = new System.Windows.Forms.Padding(3);
            this.tpAboutMe.Size = new System.Drawing.Size(785, 548);
            this.tpAboutMe.TabIndex = 3;
            this.tpAboutMe.Text = "tabPage4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnAboutMe);
            this.panel1.Controls.Add(this.btnShowAllTasks);
            this.panel1.Controls.Add(this.btnSearchForTask);
            this.panel1.Controls.Add(this.btnAddNewTask);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 538);
            this.panel1.TabIndex = 1;
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAboutMe.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnAboutMe.Location = new System.Drawing.Point(0, 435);
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.Size = new System.Drawing.Size(191, 80);
            this.btnAboutMe.TabIndex = 3;
            this.btnAboutMe.Text = "About Me";
            this.btnAboutMe.UseVisualStyleBackColor = false;
            this.btnAboutMe.Click += new System.EventHandler(this.btnAboutMe_Click);
            // 
            // btnShowAllTasks
            // 
            this.btnShowAllTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowAllTasks.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnShowAllTasks.Location = new System.Drawing.Point(0, 247);
            this.btnShowAllTasks.Name = "btnShowAllTasks";
            this.btnShowAllTasks.Size = new System.Drawing.Size(191, 80);
            this.btnShowAllTasks.TabIndex = 2;
            this.btnShowAllTasks.Text = "Show All Tasks";
            this.btnShowAllTasks.UseVisualStyleBackColor = false;
            this.btnShowAllTasks.Click += new System.EventHandler(this.btnShowAllTasks_Click);
            // 
            // btnSearchForTask
            // 
            this.btnSearchForTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchForTask.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnSearchForTask.Location = new System.Drawing.Point(0, 341);
            this.btnSearchForTask.Name = "btnSearchForTask";
            this.btnSearchForTask.Size = new System.Drawing.Size(191, 80);
            this.btnSearchForTask.TabIndex = 1;
            this.btnSearchForTask.Text = "Search For Task";
            this.btnSearchForTask.UseVisualStyleBackColor = false;
            this.btnSearchForTask.Click += new System.EventHandler(this.btnSearchForTask_Click);
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddNewTask.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnAddNewTask.Location = new System.Drawing.Point(0, 153);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(191, 80);
            this.btnAddNewTask.TabIndex = 0;
            this.btnAddNewTask.Text = "Add New Task";
            this.btnAddNewTask.UseVisualStyleBackColor = false;
            this.btnAddNewTask.Click += new System.EventHandler(this.btnAddNewTask_Click);
            // 
            // frmToDoList
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmToDoList";
            this.Text = "frmToDoList";
            this.Load += new System.EventHandler(this.frmToDoList_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAddNewTask.ResumeLayout(false);
            this.tpAddNewTask.PerformLayout();
            this.tpShowAllTasks.ResumeLayout(false);
            this.tpShowAllTasks.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tpSearchForTask.ResumeLayout(false);
            this.tpSearchForTask.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAddNewTask;
        private System.Windows.Forms.TabPage tpShowAllTasks;
        private System.Windows.Forms.TabPage tpSearchForTask;
        private System.Windows.Forms.TabPage tpAboutMe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchForTask;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDiscriptionSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAboutMe;
        private System.Windows.Forms.Button btnShowAllTasks;
        private System.Windows.Forms.Button btnSearchForTask;
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}