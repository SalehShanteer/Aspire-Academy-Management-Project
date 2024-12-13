using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseCenterDataLayer;

namespace CourseCenterBusinessLayer
{
    public class clsPerson
    {
        private enum enMode { AddNew = 0, Update = 1}
        private enMode _Mode = enMode.AddNew;
        
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        //Get FullName
        public string FullName { get { return FirstName + " " + LastName; } }

        public clsPerson() 
        {
            ID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Gender = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Email = string.Empty;
            Phone = string.Empty;
            Address = string.Empty;
            ImagePath = string.Empty;

            _Mode = enMode.AddNew;
        }

        private clsPerson(int iD, string firstName, string lastName, string gender, DateTime dateOfBirth
            , string email, string phone, string address, string ImagePath)
        {
            this.ID = iD;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.ImagePath = ImagePath;

            _Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.ID = clsPersonData.AddNewPerson(this.FirstName, this.LastName, this.Gender, this.DateOfBirth
                , this.Email, this.Phone, this.Address, this.ImagePath);
            return ID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.ID, this.FirstName, this.LastName, this.Gender, this.DateOfBirth
                , this.Email, this.Phone, this.Address, this.ImagePath);
        }

        public static bool Delete(int ID)
        {
            return clsPersonData.DeletePerson(ID);
        }

        public static clsPerson Find(int ID)
        {
            string FirstName = string.Empty, LastName = string.Empty, Gender = string.Empty, Email = string.Empty
                , Phone = string.Empty, Address = string.Empty, ImagePath = string.Empty;
            
            DateTime DateOfBirth = DateTime.MinValue;

            if (clsPersonData.FindPersonByID(ID, ref FirstName, ref LastName, ref Gender, ref DateOfBirth, ref Email, ref Phone, ref Address, ref ImagePath))
                return new clsPerson(ID, FirstName, LastName, Gender, DateOfBirth, Email, Phone, Address, ImagePath);
            return null;
        }

        public static bool IsExist(int ID)
        {
            return clsPersonData.IsPersonExist(ID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewPerson())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        if (_UpdatePerson())
                            return true;
                        return false;
                    }
            }
            return false;
        }

        public static DataTable GetPersonsList()
        {
            return clsPersonData.GetAllPersons();
        }

    }
}
