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
    public partial class frmTreeviewExercise : Form
    {
        public frmTreeviewExercise()
        {
            InitializeComponent();
        }
      
        private void CheckedTreeViewNode(TreeNodeCollection Nodes, string NodeName)
        {
            foreach (TreeNode Node in Nodes)
            {

                if (Node.Name == NodeName) 
                {
                    Node.Checked = true;
                    Node.ImageIndex = 1;         
                }

                if (Node.Nodes.Count > 0) 
                {
                    this.CheckedTreeViewNode(Node.Nodes, NodeName);
                }


            }
        }

        private void UnCheckedTreeViewNode(TreeNodeCollection Nodes)
        {
            foreach (TreeNode Node in Nodes)
            {
                Node.Checked = false;
                Node.ImageIndex = 0;

                if (Node.Nodes.Count > 0)
                {
                    this.UnCheckedTreeViewNode(Node.Nodes);
                }

            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            UnCheckedTreeViewNode(treeView1.Nodes);

            for (byte i = 0; i < chklNodes.CheckedItems.Count; i++)
            {
                CheckedTreeViewNode(treeView1.Nodes, chklNodes.CheckedItems[i].ToString());
            }
        }

       
    }
}
