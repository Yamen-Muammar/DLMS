using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core;
using DVLD__Core.Models;
using DVLD__Core.View_Models;
using DVLD__Data_Tier.Repositories;

namespace DVLD__Business_Tier.Services
{
    public class UserService
    {
        //Login Helper Methodes
        public async static Task<bool> Login(string username, string password, bool isRemaindMeActive)
        {
            User user = null;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username AND Password cannot be Empty.");
            }

            user = await UserRepository.GetUserByUsername(username);
            if (user == null)
            {
                throw new Exception("Invalid username or password. Please try again.");
            }

            if (!user.isActive)
            {
                throw new Exception("User Is Not Active.");
            }

            if (!clsPasswordHasher.VerifyPassword(password, user.HashedPassword))
            {
                throw new Exception("Invalid username or password. Please try again.");
            }

            Global.User = user;

            if (isRemaindMeActive)
            {
                SaveRemaindMeInfo(username, password);
            }
            else
            {
                RemoveDataInRemaindMeFile();
            }

            return true; // Placeholder for successful login
        }

        private  static bool SaveRemaindMeInfo(string username, string password)
        {
            string seperator = "|||";
            string line = username + seperator + password;

            string filePath = @"F:\yamen - 2024\C#\Course\projects\remaindInfo.txt";

            try
            {
                 File.WriteAllLines(filePath, new[] { line });
            }
            catch (Exception)
            {

                //throw new Exception("Error While Save User Information");
            }

            return true;
        }

        private static bool RemoveDataInRemaindMeFile()
        {
            string filePath = @"F:\yamen - 2024\C#\Course\projects\remaindInfo.txt";

            try
            {
                File.Delete(filePath);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static List<string> GetRemaindMeInfo()
        {
            List<string> list = new List<string>();

            string filePath = @"F:\yamen - 2024\C#\Course\projects\remaindInfo.txt";
            try
            {
                if (!File.Exists(filePath))
                {
                    //throw new Exception("File Does not Exists");
                }

                foreach (string line in File.ReadLines(filePath))
                {

                    list = _decodeLine(line, "|||");
                }

            }
            catch (Exception)
            {
                //throw;
            }
            return list;
        }

        private static List<string> _decodeLine(string line, string seperator)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == seperator[0] && line[i + 1] == seperator[1] && line[i + 2] == seperator[2])
                {
                    string username = line.Substring(0, i);
                    string password = line.Substring(i + 3);
                    list.Add(username);
                    list.Add(password);
                    break;
                }

            }
            return list;
        }

        // Gets

        public static List<clsUserView> GetAllUsers()
        {
            List<clsUserView> usersList = new List<clsUserView>();
            
            usersList = UserRepository.GetAllUser();
           
            return usersList;
        }

        public static User GetUserById(int userId)
        {
            User user = null;
            user = UserRepository.GetUserByID(userId);
            return user;
        }

        public static bool isUserExists(int personId) 
        {
            bool isFound = false;
            isFound = UserRepository.IsUserExistOnPersonID(personId);
            return isFound;
        }

        //Delete 
        public static bool DeleteUser(int userId)
        {         
            bool isDeleted = false;
            
            
                User userToDelete = GetUserById(userId);

                if (userToDelete == null)
                {
                    throw new Exception("User Not Found");
                }

                if (userToDelete.UserID == Global.User.UserID)
                {
                    throw new Exception("You Can not delete yourself");
                }

                if (!UserRepository.DeleteUser(userId))
                {                                        
                    throw new Exception("Can not Delete the User");
                }
                else
                {
                    isDeleted = true;
                }
           
            return isDeleted;
        }

        // Add 

        public static int AddNewUser(User user)
        {
            int insertedUser = -1;
            
            if(UserRepository.IsUserExistOnPersonID(user.Person_ID))
            {
                throw new Exception("User Already Exists");
            }

            insertedUser = UserRepository.AddNewUser(user);
            if (insertedUser == -1)
            {
                throw new Exception("Can not Add the User");
            }
           
            return insertedUser;
        }

        //Update 
        public static bool UpdateUserInfo(string newHashedPassword,bool isActive)
        {
            if (newHashedPassword == string.Empty)
            {
                throw new Exception("New Password Cannot be Empty");
            }

            if(UserRepository.UpdateUser(newHashedPassword,isActive))
            {
                return true;
            }
            else
            {
                throw new Exception("Can not Update the User");
            }
        }
    }
}
