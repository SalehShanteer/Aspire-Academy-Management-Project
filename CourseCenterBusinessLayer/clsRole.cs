using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseCenterDataLayer;

namespace CourseCenterBusinessLayer
{
    public class clsRole
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int ID { get; set; }
        public string Name { get; set; }
        public int Permissions { get; set; }
        public string Description { get; set; }

        public clsRole()
        {
            this.ID = -1;
            this.Name = string.Empty;
            this.Permissions = -1;
            this.Description = string.Empty;

            _Mode = enMode.AddNew;
        }

        private clsRole(int ID, string Name, int Permissions, string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Permissions = Permissions;
            this.Description = Description;

            _Mode = enMode.Update;
        }

        private bool _AddNewRole()
        {
            this.ID = clsRoleData.AddNewRole(this.Name, this.Permissions, this.Description);
            return this.ID != -1;
        }

        private bool _UpdateRole()
        {
            return clsRoleData.UpdateRole(this.ID, this.Name, this.Permissions, this.Description);
        }

        public static bool Delete(int ID)
        {
            if (clsRoleData.DeleteRole(ID))
                return true;
            return false;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewRole())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        if (_UpdateRole())
                            return true;
                        return false;
                    }
            }
            return false;
        }

        public static clsRole Find(int ID)
        {
            string Name = string.Empty, Description = string.Empty;
            int Permissions = -1;

            if (clsRoleData.FindRoleByID(ID, ref Name, ref Permissions, ref Description))
                return new clsRole(ID, Name, Permissions, Description);
            return null;
        }

        public static clsRole Find(string Name)
        {
            int ID = -1;
            int Permissions = -1;
            string Description = string.Empty;

            if (clsRoleData.FindRoleByName(Name, ref ID, ref Permissions, ref Description))
                return new clsRole(ID, Name, Permissions, Description);
            return null;
        }

        public static bool IsExist(int ID)
        {
            return clsRoleData.IsRoleExist(ID);
        }

        public static DataTable GetAllRoles()
        {
            return clsRoleData.GetAllRoles();
        }

    }
}
