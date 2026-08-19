using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRManagementSystem.Models;

namespace HRManagementSystem.Helpers
{
    public static class Session
    {
        public static User? CurrentUser { get; private set; }

        public static void Login(User user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public static bool IsAdmin()
        {
            return CurrentUser?.Role == UserRole.Admin.ToString();
        }

        public static bool IsHRManager()
        {
            return CurrentUser?.Role == UserRole.HRManager.ToString();
        }

        public static bool IsEmployee()
        {
            return CurrentUser?.Role == UserRole.Employee.ToString();
        }
    }
}
