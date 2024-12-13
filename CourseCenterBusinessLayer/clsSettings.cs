using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterBusinessLayer
{
    public static class clsSettings
    {

        public static byte NumberOfRemainingAttempts = 4;

        public static short NumberOfRemainingSeconds = 180;

        public static string NoAccessMessage = "Sorry, you don't have permission to view this page. Contact support if you need help.";

        public static string NoAccessTitle = "No Access!";

        public static string InvalidErrorMessage = "It looks like you missed some required fields. Please complete all marked fields before proceeding.";

        public static bool CheckPermission(int UserPermissions, int Permission)
        {
            return (UserPermissions & Permission) == Permission;
        }
            
        public  enum enPeoplePermissions
        {
            Read = 1,
            Add = 2,
            Update = 4,
            Delete = 8
        }

        public enum enStudentsPermissions
        {
            Read = 16,
            Add = 32,
            Update = 64,
            Delete = 128
        }

        public enum enInstructorsPermissions
        {
            Read = 256,
            Add = 512,
            Update = 1024,
            Delete = 2048
        }

        public enum enUsersPermissions
        {
            Read = 4096,
            Add = 8192,
            Update = 16384,
            Delete = 32768
        }

        public enum enCoursesPermissions
        {
            Read = 65536,
            Add = 131072,
            Update = 262144,
            Delete = 524288
        }

        public enum enEnrollmentsPermissions
        {
            Read = 1048576,
            Add = 2097152,
            Update = 4194304,
            Delete = 8388608
        }

        public enum enPaymentsPermissions
        {
            Read = 16777216,
            Add = 33554432,
            Update = 67108864,
            Delete = 134217728
        }



    }
}
