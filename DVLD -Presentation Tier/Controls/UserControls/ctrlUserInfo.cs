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

namespace DVLD__Presentation_Tier.Controls.UserControls
{
    public partial class ctrlUserInfo : UserControl
    {
        private User UserInfo { get; set; }

        private UserService _userService;

        private int _userId;
        public ctrlUserInfo()
        {
            InitializeComponent();
            _userService = new UserService();
            _userId = -1;
        }

        public ctrlUserInfo(int UserId)
        {
            InitializeComponent();
            _userService = new UserService();
            _userId = UserId;
        }
        private async void ctrlUserInfo_Load(object sender, EventArgs e)
        {
            if (_userId == -1)
            {
                UserInfo = Global.User;
            }
            else
            {
                UserInfo = await _getUserInfo(_userId);
            }
            
            if (UserInfo == null)
            {
                return;
            }
            _loadUserInforamtionInForm(UserInfo);
        }
        private async Task<User> _getUserInfo(int userId)
        {
            User userInfo = null;
            try
            {
                userInfo = await _userService.GetUserById(userId);
                if (userInfo == null)
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while fetching user information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return userInfo;
        }
        private void _loadUserInforamtionInForm(User user)
        {
            if (user == null)
            {
                return;
            }

            Person person = _loadPersonInformation(user.Person_ID);
            if (person == null)
            { 
                return;
            }
            ctrlPersonInformation1.UpdatePersonInfoANDRefreshUI(person);
            lblUserID.Text = user.UserID.ToString();
            lblUsername.Text = user.Username;
            lblIsActive.Text = (user.isActive) ? "Active" : "InActive";  
        }
        private Person _loadPersonInformation(int personID)
        {
            Person person = null;
            try
            {
                person = PersonService.Find(personID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return person;           
        }
        
    }
}
