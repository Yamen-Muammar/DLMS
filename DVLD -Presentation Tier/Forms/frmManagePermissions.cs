using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD__Business_Tier.Services;
using DVLD__Core;
using DVLD__Core.Models;

namespace DVLD__Presentation_Tier.Forms
{
    public partial class frmManagePermissions : Form
    {
        private RoleService _roleService;
        public frmManagePermissions()
        {
            InitializeComponent();
            _roleService = new RoleService();
        }

        private async void frmManagePermissions_Load(object sender, EventArgs e)
        {
            _loadComboBox();
        }

        //save button
        private async void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalPermissions = _calculatePermissionTotalCode();
                Role.enRoles selectedRole = (Role.enRoles)Enum.Parse(typeof(Role.enRoles), cbRoles.SelectedItem.ToString());

                bool isUpdated = await _roleService.UpdateRoleCode(selectedRole, totalPermissions);
                if (!isUpdated)
                {
                    MessageBox.Show("Failed to update role permissions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Auth.DataBaseRoles[selectedRole] = totalPermissions;
                Global.User.Role.RoleCode = totalPermissions;
                MessageBox.Show("Role permissions updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }
        }
        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _loadDGV((Role.enRoles)Enum.Parse(typeof(Role.enRoles), cbRoles.SelectedItem.ToString()));
        }
        private void dgvPermissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPermissions.CurrentRow.Cells["colPermissionName"].Value.ToString() == Auth.enOperations.FullPermission.ToString())
            {
                bool isChecked = Convert.ToBoolean(dgvPermissions.CurrentRow.Cells["colAssign"].Value);
                changeCheckBoxStatus(!isChecked);
            }
        }
        private void changeCheckBoxStatus(bool enable)
        { 
                if (enable)
                {
                    foreach (DataGridViewRow row in dgvPermissions.Rows)
                    {
                        row.Cells["colAssign"].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvPermissions.Rows)
                    {
                        row.Cells["colAssign"].Value = false;
                    }
                }
        }
        private void _loadDGV(Role.enRoles role)
        {
            int i = 1;
            dgvPermissions.Rows.Clear();
            foreach (Auth.enOperations item in Enum.GetValues(typeof(Auth.enOperations)))
            {
                bool isAuth = false;

                int rowIndex = dgvPermissions.Rows.Add(false);

                if (Auth.IsAuth(role, Auth.enOperations.FullPermission))
                {
                    isAuth = true;
                }
                else
                {
                    isAuth = Auth.IsAuth(role, item);
                }

                DataGridViewRow row = dgvPermissions.Rows[rowIndex];
                row.Cells["colAssign"].Value = isAuth;
                row.Cells["colNumber"].Value = i;
                row.Cells["colPermissionName"].Value = item.ToString();
                row.Cells["colCode"].Value = (long)item;
                i++;
            }
        }
        private void _loadComboBox()
        {
            foreach (string item in Enum.GetNames(typeof(Role.enRoles)))
            {
                cbRoles.Items.Add(item);
            }
            cbRoles.SelectedIndex = 0;
        }
        private decimal _calculatePermissionTotalCode()
        {
            long permissionTotalCode = 0;

            foreach (DataGridViewRow row in dgvPermissions.Rows)
            {
                if (row.Cells["colAssign"].Value.ToString() == "")
                {
                    throw new InvalidOperationException("Error While calculating Permissions");
                }

                if (row.Cells["colPermissionName"].Value.ToString() == Auth.enOperations.FullPermission.ToString() && Convert.ToBoolean(row.Cells["colAssign"].Value))
                {
                    permissionTotalCode = Convert.ToInt64(row.Cells["colCode"].Value);
                    return permissionTotalCode;
                }


                bool isChecked = Convert.ToBoolean(row.Cells["colAssign"].Value);
                if (isChecked)
                {
                    permissionTotalCode += Convert.ToInt64(row.Cells["colCode"].Value);
                }
            }
            return permissionTotalCode;

        }
        private async Task<Dictionary<Role.enRoles, decimal>> _UpdateRolesDictionaryFromDataBase()
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
