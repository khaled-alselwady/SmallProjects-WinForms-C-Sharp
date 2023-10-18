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
    public partial class frmGetPermissions : Form
    {
        public frmGetPermissions()
        {
            InitializeComponent();
        }

        private int GetPermissions = 0;
        private bool IsAdmin = false;
        private bool UncheckedListView = false;

        private void Clear()
        {
            masktxtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            UncheckedListView = true;
            CheckAllNodes(treePermissions);
            GetPermissions = 0;
        }

        private bool CheckIDInListView()
        {
            ListView.ListViewItemCollection ColumnItems = listView1.Items;

            foreach (ListViewItem columnItem in ColumnItems)
            {
                if (columnItem.SubItems[0].Text == masktxtID.Text.Trim())
                {
                    return true;
                }
            }

            return false;

        }

        private void CheckTreeViewNode(TreeNode node, Boolean IsChecked)
        {
            foreach (TreeNode Item in node.Nodes)
            {
                Item.Checked = IsChecked;

                if (Item.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(Item, IsChecked);
                }

            }

        }

        private void CheckAllNodes(TreeView treeView)
        {  
            foreach (TreeNode node in treeView.Nodes)
            {
                CheckAllChildNodes(node);
            }
        }

        private void CheckAllChildNodes(TreeNode treeNode)
        {
           
            if (treeNode.Checked)
            {
                GetPermissions += Convert.ToInt32(treeNode.Tag);
            }

            if(UncheckedListView)
            {
                treeNode.Checked = false;
            }
            
            
            foreach (TreeNode childNode in treeNode.Nodes)
            {
                CheckAllChildNodes(childNode);
            }
        }

        private bool CheckInfoIsNotComplate()
        {
            return (string.IsNullOrWhiteSpace(masktxtID.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text));
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (CheckInfoIsNotComplate())
                return;

            if (CheckIDInListView()) 
            {
                MessageBox.Show("There is the same ID in the List View, Please make sure to write another one!");
                return;
            }

            UncheckedListView = false;
            ListViewItem Item = new ListViewItem(masktxtID.Text.Trim());

            Item.SubItems.Add(txtFirstName.Text.Trim());
            Item.SubItems.Add(txtLastName.Text.Trim());

            CheckAllNodes(treePermissions);

            if (IsAdmin)
            {      
                GetPermissions = -1;
            }

            Item.SubItems.Add(GetPermissions.ToString());

            listView1.Items.Add(Item);
            Clear();
        }

        private void treePermissions_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);

            if (e.Node.Name == "Node0")
            {
                IsAdmin = e.Node.Checked;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                masktxtID.Text = selectedItem.SubItems[0].Text.Trim(); 
                txtFirstName.Text = selectedItem.SubItems[1].Text.Trim(); 
                txtLastName.Text = selectedItem.SubItems[2].Text.Trim(); 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count > 0)
            {
                
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedItem.SubItems[0].Text = masktxtID.Text.Trim();
                selectedItem.SubItems[1].Text = txtFirstName.Text.Trim();
                selectedItem.SubItems[2].Text = txtLastName.Text.Trim();

                UncheckedListView = false;
                CheckAllNodes(treePermissions);

                if (IsAdmin)
                {
                    GetPermissions = -1;
                }

                selectedItem.SubItems[3].Text = GetPermissions.ToString();
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection ColumnItems = listView1.Items;

            foreach (ListViewItem columnItem in ColumnItems)
            {
                if (columnItem.SubItems[0].Text == masktxtID.Text.Trim())
                {
                    columnItem.Remove();
                    Clear();
                    return;
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
