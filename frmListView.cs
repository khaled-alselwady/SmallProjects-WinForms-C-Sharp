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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtID.Text) || string.IsNullOrWhiteSpace(txtName.Text)
                || string.IsNullOrWhiteSpace(txtCity.Text)) 
                return;


            ListViewItem Item = new ListViewItem(mtxtID.Text.Trim());

            if (rbMale.Checked)
                Item.ImageIndex = 0; 

            else 
                Item.ImageIndex = 1;


            Item.SubItems.Add(txtName.Text.Trim());
            Item.SubItems.Add(txtCity.Text.Trim());

            listView1.Items.Add(Item);

            mtxtID.Clear();
            txtName.Clear();
            txtCity.Clear();
            mtxtID.Focus();
        }

        private void brnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for (byte i = 1; i <= 10; i++)
            {
                ListViewItem  Item = new ListViewItem(i.ToString());

                if (i % 2 == 0)     
                    Item.ImageIndex = 0;
                
                else 
                    Item.ImageIndex = 1;

                Item.SubItems.Add("Person" + i);
                Item.SubItems.Add("Amman");

                listView1.Items.Add(Item);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].Text);
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void mtxtID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtID.Text))
            {
                e.Cancel = true;
                mtxtID.Focus();
                errorProvider1.SetError(mtxtID, "ID should have a value!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtID, "");
            }
        }
    }
}
