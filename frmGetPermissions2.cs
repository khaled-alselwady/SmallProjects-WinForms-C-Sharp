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
    public partial class frmGetPermissions2 : Form
    {
        public frmGetPermissions2()
        {
            InitializeComponent();
        }

        enum enPermissions { pShow = 1, pDelete = 2, pUpdate = 4, pAll = 7 }

        private int CurrentPermissions = 0;

        private void UnCheckOtherCheckboxes()
        {
            chkShow.Checked = false;
            chkDelete.Checked = false;
            chkUpdate.Checked = false;
        }

        private void DesableOtherCheckboxes()
        {
            chkShow.Enabled = false;
            chkDelete.Enabled = false;
            chkUpdate.Enabled = false;
        }

        private void EnableOtherCheckboxes()
        {
            chkShow.Enabled = true;
            chkDelete.Enabled = true;
            chkUpdate.Enabled = true;
        }

        private bool CheckAccessPermission(enPermissions en_Permission)
        {
            if (en_Permission == enPermissions.pAll)
                return true;


            if (((int)en_Permission & CurrentPermissions) == (int)en_Permission)
                return true;
            else
                return false;
        }

        private List<int> GetSelectedPermissions()
        {
            List<int> SelectedPermissions = new List<int>();

            if (chkShow.Checked)
            {
                SelectedPermissions.Add((int)enPermissions.pShow);
            }
            if (chkDelete.Checked)
            {
                SelectedPermissions.Add((int)enPermissions.pDelete);
            }
            if (chkUpdate.Checked)
            {
                SelectedPermissions.Add((int)enPermissions.pUpdate);
            }

            return SelectedPermissions;
        }

        private int CalculatePermissions(List<int> SelectedPermissions)
        {
            CurrentPermissions = 0;

            foreach(int Permission in SelectedPermissions)
            {
                CurrentPermissions += Permission;
            }

            return CurrentPermissions;
        }

        private int GetPermissions()
        {
            if (chkAllPermissions.Checked)
            {
                return (int)enPermissions.pAll;
            }

            else
            {
                return CalculatePermissions(GetSelectedPermissions());
            }
            
        }

        private void UpdatePermissionAndlabelText()
        {
            CurrentPermissions = GetPermissions();
            lblNumberOfPermissions.Text = CurrentPermissions.ToString();
        }

        private void ShowMessageBox(bool HasPermission)
        {
            if (HasPermission)
                MessageBox.Show("Welcome");
            else
                MessageBox.Show("Error");
        }

        private void chkAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAllPermissions.Checked)
            {
                UnCheckOtherCheckboxes();
                DesableOtherCheckboxes();
            }

            else
            {
                EnableOtherCheckboxes();
            }

            UpdatePermissionAndlabelText();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePermissionAndlabelText();
        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePermissionAndlabelText();
        }

        private void chkUpdate_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePermissionAndlabelText();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowMessageBox(CheckAccessPermission(enPermissions.pShow));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ShowMessageBox(CheckAccessPermission(enPermissions.pDelete));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowMessageBox(CheckAccessPermission(enPermissions.pUpdate));
        }
    }
}
