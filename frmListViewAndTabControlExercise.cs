using MyFirstWinFormsProject.Properties;
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
    public partial class frmListViewAndTabControlExercise : Form
    {
        public frmListViewAndTabControlExercise()
        {
            InitializeComponent();
        }

        private void ShowNotifyIcon(string Title)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Added Successfully" + Environment.NewLine
                + Title + Environment.NewLine + DateTime.Now.ToString();
            notifyIcon1.BalloonTipTitle = "Added User";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void Clear()
        {
            mtxtID.Clear();
            mtxtName.Clear();
            mtxtPhone.Clear();
            combCountry.Text = "Jordan";
            pbCountry.Image = Resources.jordan;
            lblSuffixOfCountry.Text = "+962";
            combCity.Text = "Amman";
            combCity.Items.Add("Amman");
            combCity.Items.Add("Zarqa");
            combCity.Items.Add("Jarash");
            mtxtID.Focus();
        }

        private void btnViewDate_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtID.Text) || string.IsNullOrWhiteSpace(mtxtName.Text)
                || string.IsNullOrWhiteSpace(mtxtPhone.Text))
                return;

            ListViewItem Item = new ListViewItem(mtxtID.Text.Trim());

            Item.SubItems.Add(mtxtName.Text.Trim());
            Item.SubItems.Add(combCountry.Text.Trim());
            Item.SubItems.Add(combCity.Text.Trim());
            Item.SubItems.Add(mtxtPhone.Text.Trim());

            listView1.Items.Add(Item);

            MessageBox.Show("Information Added Successfully", "Sucess",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowNotifyIcon(mtxtName.Text.Trim());

            Clear();
            mtxtID.Focus();

        }

        private void mtxtbox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void comb_Validating(object sender, CancelEventArgs e)
        {

        }

        private void combCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            combCity.Text = "";
            combCity.Items.Clear();

            if (combCountry.Text == "Jordan")
            {
                pbCountry.Image = Resources.jordan;
                lblSuffixOfCountry.Text = "+962";
                combCity.Items.Add("Amman");
                combCity.Items.Add("Zarqa");
                combCity.Items.Add("Jarash");
            }

            else
            {
                pbCountry.Image = Resources.egypt;
                lblSuffixOfCountry.Text = "+1";
                combCity.Items.Add("Jeza");
                combCity.Items.Add("Cario");
            }
        }

        private void frmListViewAndTabControlExercise_Load(object sender, EventArgs e)
        {
            mtxtID.Focus();
            rbDetails.Checked = true;
            combCountry.Text = "Jordan";
            pbCountry.Image = Resources.jordan;
            lblSuffixOfCountry.Text = "+962";
            combCity.Text = "Amman";
           
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Clear();
        }
    }
}
