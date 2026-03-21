using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD__Business_Tier;
using DVLD__Business_Tier.Services;
using DVLD__Core;

namespace DVLD__Presentation_Tier.Forms.UserForms
{
    public partial class frmChangePassword : Form
    {
        private UserService _userService;
        public frmChangePassword()
        {
            InitializeComponent();
            _userService = new UserService();
        }
        public frmChangePassword(int userId)
        {
            InitializeComponent(userId);
            _userService = new UserService();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!_isInputsValid())
            {
                return;
            }

            string CurrentPassword = tbCurrentPassword.Text;    
            bool isCurrentPasswordVerified = clsPasswordHasher.VerifyPassword(CurrentPassword,Global.User.HashedPassword);

            if (!isCurrentPasswordVerified)
            {
                MessageBox.Show("Current password is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedNewPassword = clsPasswordHasher.HashPassword(tbNewPassword.Text);

            try
            {
                if (await _userService.UpdateUserInfo(hashedNewPassword,true))
                {
                    MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbConfirmationNewPassword_Leave(object sender, EventArgs e)
        {
            if (tbConfirmationNewPassword.Text != tbNewPassword.Text)
            {
                errorProvider1.SetError(tbConfirmationNewPassword, "New password and confirmation Does not match.");
            }
        }

        private bool _isInputsValid()
        {
            if (string.IsNullOrEmpty(tbCurrentPassword.Text) || string.IsNullOrEmpty(tbNewPassword.Text) || string.IsNullOrEmpty(tbConfirmationNewPassword.Text))
            {
                MessageBox.Show("Fill ALL Fields Please!","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            if (tbConfirmationNewPassword.Text!=tbNewPassword.Text )
            {
                MessageBox.Show("New Password and Current Password must be Same", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
