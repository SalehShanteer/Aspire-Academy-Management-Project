using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseCenter_Project;
using CourseCenterBusinessLayer;

namespace testCourseCenterProject
{
    public class Test
    {
        
        public static void TestFindByIDFunction(int ID)
        {
            clsPaymentMethod student = clsPaymentMethod.Find(ID);
            if (student != null)
            {
                Console.WriteLine($"{student.ID}, {student.MethodName}, {student.Description}, {student.IsActive}");
            }
            else
            {
                Console.WriteLine($"Student with ID = {ID} Not Found");
            }
        }

        public static void TestFindByNameFunction(string Name)
        {
            clsCourse student = clsCourse.Find(Name);
            if (student != null)
            {
                Console.WriteLine($"{student.ID}, {student.Name}, {student.InstructorID}, {student.CreditHours}");
            }
            else
            {
                Console.WriteLine($"Student with Name = {Name} Not Found");
            }
        }

        public static void TestIsExistFunction(int ID)
        {
            if (clsPaymentMethod.IsExist(ID))
                Console.WriteLine("The student exist");
            else
                Console.WriteLine("The student does not exist");
        }

        public static void TestIsExistFunction(string Name)
        {
            if (clsCourse.IsExist(Name))
                Console.WriteLine("The student exist");
            else
                Console.WriteLine("The student does not exist");
        }

        public static void TestAddNewFunction()
        {
            clsPaymentMethod Student = new clsPaymentMethod();
            Student.ID = 2;
            Student.MethodName = "VISA";
            Student.Description = "Test";
            Student.IsActive = true;

            if (Student.Save())
            {
                Console.WriteLine($"student with ID = {Student.ID}, {Student.MethodName} added successfully");
            }
            else
            {
                Console.WriteLine("student add operation failed");
            }
        }

        public static void TestUpdateFunction(int ID)
        {
            clsPaymentMethod Student = clsPaymentMethod.Find(ID);
            if (Student != null)
            {
                Student.MethodName = "VISA";
                Student.Description = "Test";
                Student.IsActive = true;
                if (Student.Save())
                    Console.WriteLine($"Update to {Student.MethodName}");
                else
                    Console.WriteLine("Update failed");
            }
            else
            {
                Console.WriteLine("person not found");
            }
        }

        public static void TestDeleteFunction(int ID)
        {
            if (clsPaymentMethod.Delete(ID))
                Console.WriteLine($"Student With ID = {ID} deleted successfully");
            else 
                Console.WriteLine("student delete failed");
        }

        public static void TestGetAllFunction()
        {
            DataTable dt = clsPaymentMethod.GetPaymentMethodsList();
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row["MethodName"]}, {row["IsActive"]}");
            }
        }

        public static int TestFindPersonID(int ID)
        {
            return clsInstructor.GetPersonID(ID);
        }

        public static bool IsPaid(int ID)
        {
            return clsPayment.IsPaidAnyAmount(ID);
        }
        
  

        static void Main(string[] args)
        {
            //TestFindByIDFunction(1);
            //TestFindByNameFunction("oop");
            //TestIsExistFunction(1);
            //TestAddNewFunction();
            //TestUpdateFunction(2);
            //TestDeleteFunction(2);
            //TestGetAllFunction();

            string s = "saleh";

            Console.WriteLine(clsUtility.Encrypt(s));

            Console.WriteLine(clsUtility.Decrypt(clsUtility.Encrypt(s)));

            Console.ReadKey();
        }
    }
}
