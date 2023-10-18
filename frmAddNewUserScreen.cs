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
    public partial class frmAddNewUserScreen : Form
    {
        public frmAddNewUserScreen()
        {
            InitializeComponent();
        }

        

        void ShowNotifyIcon(string Title)
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Added User";
            notifyIcon1.BalloonTipText = Title;
            notifyIcon1.ShowBalloonTip(1000);
        }

        void Clear()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtJop.Clear();
            txtSalary.Clear();
            txtPhone.Clear();
            rbFemale.Checked = false;
            rbMale.Checked = false;
            chkGood.Checked = false;
            chkVeryGood.Checked = false;
        }

        void FillTheInfo()
        {
            string Name = txtFirstName.Text + " " + txtLastName.Text;

            ListViewItem Item = new ListViewItem(Name.Trim());

            if (rbMale.Checked)
                Item.ImageIndex = 0;
            else
                Item.ImageIndex = 1;

            Item.SubItems.Add(txtJop.Text.Trim());
            Item.SubItems.Add(txtSalary.Text.Trim());
            Item.SubItems.Add(txtPhone.Text.Trim());

            if (rbMale.Checked)
                Item.SubItems.Add("Male");
            else
                Item.SubItems.Add("Female");


            if (chkGood.Checked && !chkVeryGood.Checked)
                Item.SubItems.Add("Good");

            else if (chkVeryGood.Checked && !chkGood.Checked)
                Item.SubItems.Add("Very Good");

            else
                Item.SubItems.Add("Good And Very Good");


            listView1.Items.Add(Item);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Green;


            if (txtFirstName.Text == "")
            {
                MessageBox.Show("First Name is Empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtLastName.Text == "")
            {
                MessageBox.Show("Last Name is Empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtJop.Text == "")
            {
                MessageBox.Show("Jop is Empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSalary.Text == "")
            {
                MessageBox.Show("Salary is Empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPhone.Text == "")
            {
                MessageBox.Show("Phone is Empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((!rbMale.Checked) && (!rbFemale.Checked))
            {
                MessageBox.Show("Gender is NOT Chosen!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if ((!chkGood.Checked) && (!chkVeryGood.Checked))
            {
                MessageBox.Show("Level is NOT Chosen!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillTheInfo();        
            ShowNotifyIcon(txtFirstName.Text + " " + txtLastName.Text);
            Clear();
        }

        private void frmAddNewUserScreen_Load(object sender, EventArgs e)
        {
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Green;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text)) 
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                errorProvider1.SetError(((TextBox)sender), $"{((TextBox)sender).Tag} should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(((TextBox)sender), "");
            }
        }

        
    }
}
