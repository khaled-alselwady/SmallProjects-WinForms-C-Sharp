using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmToDoList : Form
    {
        public frmToDoList()
        {
            InitializeComponent();
        }

        private bool CheckTilteInListView()
        {
            ListView.ListViewItemCollection ColumnItems = listView1.Items;

            foreach (ListViewItem columnItem in ColumnItems)
            {
                if (columnItem.SubItems[0].Text == txtTaskTitle.Text.Trim())
                {
                    return true;
                }
            }

            return false;

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskTitle.Text) || string.IsNullOrWhiteSpace(txtDiscription.Text))
                return;

            if (MessageBox.Show("Are you sure you want to add this new task?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) 
            {

                if (CheckTilteInListView())
                {
                    MessageBox.Show("There is such task with such title,try to write a new title", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaskTitle.Clear();
                    return;
                }


                ListViewItem Item = new ListViewItem(txtTaskTitle.Text.Trim());

                Item.SubItems.Add(txtDiscription.Text.Trim());
                Item.SubItems.Add(dateTimePicker1.Value.ToShortDateString());

                listView1.Items.Add(Item);

                MessageBox.Show("Task Added Successfully", "Success");
                txtTaskTitle.Clear();
                txtDiscription.Clear();
                txtTaskTitle.Focus();
                dateTimePicker1.Text = default;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchForTask.Text.Trim()))
                return;

            foreach (ListViewItem Item in listView1.Items)
            {
                if (Item.SubItems[0].Text == txtSearchForTask.Text.Trim())
                {
                    txtDiscriptionSearch.Text = Item.SubItems[1].Text;
                    dateTimePicker2.Text = Item.SubItems[2].Text;                   
                    return;
                }
            }

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTaskTitle.Clear();
            txtDiscription.Clear();
            txtSearchForTask.Clear();
            txtDiscriptionSearch.Clear();
            listView1.Items.Clear();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem Item in listView1.Items)
            {
                if (Item.Selected)
                {
                    if (MessageBox.Show("Are you sure you want to delete this task?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        Item.Remove();
                        MessageBox.Show("Task Deleted Susseccfully", "Success");
                    }
                    return;
                }

            }
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpAddNewTask;
            this.AcceptButton = btnAdd;
            txtTaskTitle.Focus();
            txtSearchForTask.Clear();
            txtDiscriptionSearch.Clear();
            dateTimePicker2.Text = default;
        }

        private void btnShowAllTasks_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpShowAllTasks;
            txtTaskTitle.Clear();
            txtDiscription.Clear();
            txtSearchForTask.Clear();
            txtDiscriptionSearch.Clear();
            dateTimePicker1.Text = default;
            dateTimePicker2.Text = default;
        }

        private void btnSearchForTask_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearch;
            txtSearchForTask.Focus();
            tabControl1.SelectedTab = tpSearchForTask;
            txtTaskTitle.Clear();
            txtDiscription.Clear();
            dateTimePicker1.Text = default;
        }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpAboutMe;
        }

        private void frmToDoList_Load(object sender, EventArgs e)
        {
            txtTaskTitle.Focus();
        }
    }
}
