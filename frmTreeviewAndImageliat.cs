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
    public partial class frmTreeviewAndImageliat : Form
    {
        public frmTreeviewAndImageliat()
        {
            InitializeComponent();
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

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView2.Nodes.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                treeView2.SelectedNode.Nodes.Add(comboBox1.SelectedItem.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (treeView2.Nodes.Count > 0)
            {
                treeView2.SelectedNode.Remove();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Text = textBox2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.ContainsKey("Node0"))
            {
                MessageBox.Show("true!");
            }
            else
            {
                MessageBox.Show("False!!");
            }
        }
    }
}
