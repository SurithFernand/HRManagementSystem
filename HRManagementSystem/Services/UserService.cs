using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManagementSystem.Data;
using HRManagementSystem.Helpers;
using HRManagementSystem.Models;

namespace HRManagementSystem.Services
{
    public class UserService
    {
        public User CreateEmployeeUser(
            int employeeId,
            string username,
            string password)
        {
            using var db = new HRDbContext();

            username = username.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                throw new Exception(
                    "Username is required.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception(
                    "Password is required.");
            }

            bool usernameExists =
                db.Users.Any(u =>
                    u.Username == username);

            if (usernameExists)
            {
                throw new Exception(
                    "This username is already in use.");
            }

            var employee =
                db.Employees.FirstOrDefault(
                    e => e.Id == employeeId);

            if (employee == null)
            {
                throw new Exception(
                    "Employee not found.");
            }

            var existingAccount =
                db.Users.FirstOrDefault(
                    u => u.EmployeeId == employeeId);

            if (existingAccount != null)
            {
                throw new Exception(
                    "This employee already has a login account.");
            }

            var user = new User
            {
                Username = username,

                PasswordHash =
                    PasswordHelper.HashPassword(password),

                Role =
                    UserRole.Employee.ToString(),

                EmployeeId = employeeId,

                IsActive = true
            };

            db.Users.Add(user);

            db.SaveChanges();

            return user;
        }
    }
}
