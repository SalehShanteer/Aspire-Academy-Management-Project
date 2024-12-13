using CourseCenterDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterBusinessLayer
{
    public class clsUser
    {

        private enum enMode { AddNew = 0, Update = 1}

        private enMode _Mode = enMode.AddNew;
        
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.Username = string.Empty;
            this.Password = string.Empty;
            this.RoleID = -1;
            this.DateCreated = DateTime.MinValue;
            this.LastLogin = DateTime.MinValue;
            this.IsActive = true;

            _Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string Username, string Password, int RoleID
                 , DateTime DateCreated, DateTime LastLogin, bool IsActive)
        {
            this.ID = UserID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.RoleID = RoleID;
            this.DateCreated = DateCreated;
            this.LastLogin = LastLogin;
            this.IsActive = IsActive;

            _Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.ID = clsUserData.AddNewUser(this.PersonID, this.Username, this.Password
                , this.RoleID, this.IsActive);

            return this.ID != -1;
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.ID, this.PersonID, this.Username, this.Password, this.RoleID
                , this.LastLogin, this.IsActive);
        }
        
        public static bool Delete(int ID)
        {
            return clsUserData.DeleteUser(ID);
        }

        public static clsUser Find(int ID)
        {
            int PersonID = -1;

            string Username = string.Empty, Password = string.Empty;
            
            int RoleID = -1;    
            
            DateTime DateCreated = DateTime.MinValue, LastLogin = DateTime.MinValue;

            bool IsActive = true;

            if (clsUserData.FindByID(ID, ref PersonID, ref Username, ref Password, ref RoleID
                , ref DateCreated, ref LastLogin, ref IsActive))
            {
                return new clsUser(ID, PersonID, Username, Password, RoleID, DateCreated, LastLogin, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static clsUser Find(string Username, string Password)
        {
            int ID = -1, PersonID = -1, RoleID = -1;

            DateTime DateCreated = DateTime.MinValue, LastLogin = DateTime.MinValue;

            bool IsActive = true;

            if (clsUserData.FindByUsernameAndPassword(ref ID, ref PersonID, Username, Password, ref RoleID
                , ref DateCreated, ref LastLogin, ref IsActive))
            {
                return new clsUser(ID, PersonID, Username, Password, RoleID, DateCreated, LastLogin, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static bool IsExist(int ID)
        {
            return clsUserData.IsExistByID(ID);
        }

        public static bool IsExist(string Username, string Password)
        {
            return clsUserData.IsExistByUsernameAndPassword(Username, Password);
        }

        public static bool IsPersonAddedBefore(int PersonID)
        {
            return clsUserData.IsPersonIDExist(PersonID);
        }

        public static bool IsUsernameAddedBefore(string Username)
        {
            return clsUserData.IsUsernameUsedBefore(Username);
        }

        public static bool IsUsernameAddedBefore(int ID, string Username)
        {
            return clsUserData.IsUsernameUsedBefore(ID, Username);
        }

        public static bool IsUserActive(string Username)
        {
            return clsUserData.IsUserActive(Username);
        }

        public bool Save()
        {
            switch (_Mode)
            {

                case enMode.AddNew:
                    {
                        if (_AddNewUser())
                        {
                            _Mode = enMode.Update;

                            return true;
                        }
                        
                        return false;
                    }

                case enMode.Update:
                    {
                        if (_UpdateUser())
                        {
                            return true;
                        }

                        return false;
                    }
            }
            return false;
        }

        public static DataTable GetUsersList()
        {
            return clsUserData.GetAllUsersList();
        }

    }
}
