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
    public partial class frmTreeviewAndImageliatExercise : Form
    {
        public frmTreeviewAndImageliatExercise()
        {
            InitializeComponent();
        }

        private short CounterDepartment = 1;
        private short CounterEmployee = 1;

        private void AddNodesToTreeView()
        {
            for (short i = 1; i <= Convert.ToInt16(masktxtDepartment.Text); i++)
            {
                treeviewDepartments.Nodes.Add("Department " + CounterDepartment);
                CounterDepartment++;
            }
        }

        private void AddChildToTreeView(TreeNode node)
        {
            for (short i = 1; i <= Convert.ToInt16(masktxtEmployee.Text); i++)
            {
                node.Nodes.Add("Employee " + CounterEmployee);
                CounterEmployee++;
            }
        }

        private void CheckChildNodes(TreeNode treenode)
        {
            if (treenode.IsSelected)
            {
                treeviewDepartments.Tag = 1;
                return;
            }
                
            foreach (TreeNode ChildNode in treenode.Nodes)
            {
                CheckChildNodes(ChildNode);
            }
        }

        private void ChangeImageIndexAtEmployee(TreeNode node)
        {
            foreach (TreeNode Child in node.Nodes) 
            {
                Child.ImageIndex = 1;
                Child.SelectedImageIndex = 1;
                ChangeImageIndexAtEmployee(Child);
            }
        }

        private bool IsThereASelectedNode()
        {
            foreach (TreeNode node in treeviewDepartments.Nodes)
            {
                CheckChildNodes(node);
            }

            if (Convert.ToInt16(treeviewDepartments.Tag) == 0)
                return false;
            else
                return true;
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

        private void ResetNodeImage(TreeNode node)
        {
            node.ImageKey = null;
            node.SelectedImageKey = null;
            node.ImageIndex = 0;
            node.SelectedImageIndex = 0;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(masktxtDepartment.Text))
                return;

            AddNodesToTreeView();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(masktxtEmployee.Text) || !IsThereASelectedNode())   
                return;

            if (treeviewDepartments.SelectedNode.Nodes.Count <= 0)
                CounterEmployee = 1;


            AddChildToTreeView(treeviewDepartments.SelectedNode);
            ChangeImageIndexAtEmployee(treeviewDepartments.SelectedNode);

            
        }

        private void treeviewDepartments_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            foreach (TreeNode node in treeviewDepartments.Nodes)
            {
                ResetNodeImage(node);
            }

            if (treeviewDepartments.SelectedNode != null && treeviewDepartments.SelectedNode != e.Node)
            {
                treeviewDepartments.SelectedNode.ImageIndex = 0;
            }

            if (treeviewDepartments.SelectedNode != null)
            {
                treeviewDepartments.SelectedNode.ImageIndex = 2;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!IsThereASelectedNode())
                return;

            txtEdit.Text = treeviewDepartments.SelectedNode.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEdit.Text))
            {
                treeviewDepartments.SelectedNode.Text = txtEdit.Text;
            }
        }

        private void treeviewDepartments_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!IsThereASelectedNode() || treeviewDepartments.SelectedNode == null)
                return;

            treeviewDepartments.SelectedNode.Remove();
        }

        private void btnAddDepartment_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(masktxtDepartment.Text))
                return;

            AddNodesToTreeView();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Yellow;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }

       
        
    }
}
