using CourseCenterDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterBusinessLayer
{
    public class clsSavedUser
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private clsSavedUser(int iD, string username, string password)
        {
            this.ID = iD;
            this.Username = username;
            this.Password = password;
        }

        public static bool Update(string Username, string Password)
        {
            return clsSavedUserData.UpdateSavedUser(Username, Password);
        }

        public static clsSavedUser Find()
        {
            int ID = 1;//Default only one user saved
            string Username = string.Empty;
            string Password = string.Empty; 

            if (clsSavedUserData.FindSavedUserByID(ID, ref Username, ref Password))
            {
                return new clsSavedUser(ID, Username, Password);
            }
            else
                return null;
        }

    }
}
