using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD__Presentation_Tier.Forms;
using DVLD__Presentation_Tier.Forms.UserForms;
using DVLD__Core;
using DVLD__Presentation_Tier.Forms.Application_Types_Forms;
using DVLD__Presentation_Tier.Forms.Test_Types_Forms;
using DVLD__Presentation_Tier.Forms.LocalDrivingLicenseForms;
using DVLD__Presentation_Tier.Forms.DriversForms;
using DVLD__Presentation_Tier.Forms.InternationalLicenseForms;
using DVLD__Presentation_Tier.Forms.DetainedLicenseForms;
using DVLD__Core.Models;
using DVLD__Business_Tier.Services;
namespace DVLD__Presentation_Tier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            _isAuthEditeOperationsBtn();
            Auth.DataBaseRoles = await _loadRolesFromDataBase();
        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.UsersList))
            {
                mgAccessDenied.Show();
                return;
            }
            frmPeopleListWithFilter frmPeopleListWithFilter = new frmPeopleListWithFilter();
            frmPeopleListWithFilter.ShowDialog();
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frmUserInfo = new frmUserInfo();
            frmUserInfo.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.User = null;
            System.Windows.Forms.Application.Restart();            
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.UsersList))
            {
                mgAccessDenied.Show();
                return;
            }
            frmManageUsers frmManageUsers = new frmManageUsers();
            frmManageUsers.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.ChangeUserPassword))
            {
                mgAccessDenied.Show();
                return;
            }
            frmChangePassword frmChangePassword = new frmChangePassword(Global.User.UserID);
            frmChangePassword.ShowDialog();
        }        

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.ManageApplicationTypes))
            {
                mgAccessDenied.Show();
                return;
            }
            frmManageApplicationTypes frmManageApplicationTypes = new frmManageApplicationTypes();
            frmManageApplicationTypes.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.ManageTestTypes))
            {
                mgAccessDenied.Show();
                return;
            }
            frmManageTestTypes frmManageTestTypes = new frmManageTestTypes();
            frmManageTestTypes.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.AddLocalDrivingApplication))
            {
                mgAccessDenied.Show();
                return;
            }
            frmNewLocalDrivingLicenseApplication frmNewLocalDrivingLicenseApplication = new frmNewLocalDrivingLicenseApplication();
            frmNewLocalDrivingLicenseApplication.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.AddInternationalLicense))
            {
                mgAccessDenied.Show();
                return;
            }
            frmInternationalLicenseApplication frmInternationalLicense = new frmInternationalLicenseApplication();
            frmInternationalLicense.ShowDialog();
        }        
        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.SeeApplicationsList))
            {
                mgAccessDenied.Show();
                return;
            }
            frmLocalDrivingLicenseApplication frmLocalDrivingLicenseApplication = new frmLocalDrivingLicenseApplication();
            frmLocalDrivingLicenseApplication.ShowDialog();
        }

        private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.InternationalLicenseList))
            {
                mgAccessDenied.Show();
                return;
            }
            frmManageInternationalLicense frmManageInternational = new frmManageInternationalLicense();
            frmManageInternational.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.DriverList))
            {
                mgAccessDenied.Show();
                return;
            }
            frmManageDrivers frmManage = new frmManageDrivers();
            frmManage.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.RenewLicenseApplication))
            {
                mgAccessDenied.Show();
                return;
            }
            frmRenewLicenseApplication frm = new frmRenewLicenseApplication();
            frm.ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.ReplaceLicenseApplication))
                {
                    mgAccessDenied.Show();
                    return;
                }
            frmReplaceLicense frmReplace = new frmReplaceLicense();
            frmReplace.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.DeatainLicense))
            {
                mgAccessDenied.Show();
                return;
            }
            frmDetainLicense frmDetain = new frmDetainLicense();
            frmDetain.ShowDialog();
        }

        private void relaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.ReleaseDetainedLicense))
            {
                mgAccessDenied.Show();
                return;
            }
            frmReleaseDetainedLicense frmRelease = new frmReleaseDetainedLicense();
            frmRelease.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.DetainedLicenseList))
            {
                mgAccessDenied.Show();
                return;
            }
            frmManageDeainedLicense frm = new frmManageDeainedLicense();
            frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.ReleaseDetainedLicense))
            {
                mgAccessDenied.Show();
                return;
            }
            frmReleaseDetainedLicense frmRelease = new frmReleaseDetainedLicense();
            frmRelease.ShowDialog();
        }

        private void editeOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.EditePermissionsButton))
            {
                mgAccessDenied.Show();
                return;
            }
            frmManagePermissions frm = new frmManagePermissions();
            frm.ShowDialog();
        }

        private void _isAuthEditeOperationsBtn()
        {
            try
            {
                editeOperationsToolStripMenuItem.Visible = Auth.IsAuth(Global.User.Role, Auth.enOperations.EditePermissionsButton);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking permissions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editeOperationsToolStripMenuItem.Visible = false;
            }
           
        }

        private async Task<Dictionary<Role.enRoles, decimal>> _loadRolesFromDataBase()
        {
            try
            {
                RoleService roleService = new RoleService();

                List<Role> roles = await roleService.GetAllRoles();
                Dictionary<Role.enRoles, decimal> rolesDictionary = new Dictionary<Role.enRoles, decimal>();
                foreach (Role role in roles)
                {
                    rolesDictionary.Add((Role.enRoles)role.RoleId, role.RoleCode);
                }
                return rolesDictionary;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Windows.Forms.Application.Restart();
                return null; 
            }
        }
    }
}
