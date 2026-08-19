using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManagementSystem.Data;
using HRManagementSystem.Helpers;
using HRManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HRManagementSystem.Services
{
    public class AuthenticationService
    {
        public User? Login(string username, string password)
        {
            using var db = new HRDbContext();

            var user = db.Users
                .Include(u => u.Employee)
                .FirstOrDefault(u =>
                    u.Username == username &&
                    u.IsActive);

            if (user == null)
            {
                return null;
            }

            bool validPassword =
                PasswordHelper.VerifyPassword(
                    password,
                    user.PasswordHash);

            if (!validPassword)
            {
                return null;
            }

            return user;
        }
    }
}
