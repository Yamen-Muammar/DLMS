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
using DVLD__Core.Models;

namespace DVLD__Presentation_Tier.Forms.UserForms
{
    public partial class frmUpdateUserStatus : Form
    {
        private UserService _userService;
        private User UserInfo {  get; set; }
        private int _passedUserID;
        private bool _previousStatuse;
        public frmUpdateUserStatus(int userID)
        {
            InitializeComponent();
            _userService = new UserService();
            _passedUserID = userID;
        }
        private async void frmUpdateUserStatus_Load(object sender, EventArgs e)
        {
            UserInfo = await _getUserAsynByIDAsync(_passedUserID);
            if (UserInfo == null)
            {
               this.Close();
                MessageBox.Show("User Not Found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblUsername.Text = UserInfo.Username;
            cbIsActive.Checked = UserInfo.isActive;
        }

        private async Task<User> _getUserAsynByIDAsync(int userID)
        {
            User user = null;
            try
            {
                user = await _userService.GetUserByIdAsync(userID);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return user;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (UserInfo == null)
            {
                return;
            }
            _previousStatuse = !cbIsActive.Checked;

            try
            {

                if (await _userService.UpdateUserStatus(UserInfo.UserID, cbIsActive.Checked))
                {
                    MessageBox.Show("User Status Updated Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can not update Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbIsActive.Checked = _previousStatuse;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbIsActive.Checked = _previousStatuse;
            }
        }
    }
}
