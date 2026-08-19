using HRManagementSystem.Helpers;
using HRManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Data
{
    //public static class DbSeeder
    //{
    //    public static void Seed()
    //    {
    //        using var db = new HRDbContext();

    //        // Create default department
    //        if (!db.Departments.Any())
    //        {
    //            db.Departments.AddRange(
    //                new Department
    //                {
    //                    DepartmentName = "Information Technology",
    //                    Description = "IT Department"
    //                },
    //                new Department
    //                {
    //                    DepartmentName = "Human Resources",
    //                    Description = "Human Resources Department"
    //                },
    //                new Department
    //                {
    //                    DepartmentName = "Finance",
    //                    Description = "Finance Department"
    //                }
    //            );

    //            db.SaveChanges();
    //        }

    //        // Create default leave types
    //        if (!db.LeaveTypes.Any())
    //        {
    //            db.LeaveTypes.AddRange(
    //                new LeaveType
    //                {
    //                    Name = "Annual Leave",
    //                    DefaultDays = 14
    //                },
    //                new LeaveType
    //                {
    //                    Name = "Sick Leave",
    //                    DefaultDays = 7
    //                },
    //                new LeaveType
    //                {
    //                    Name = "Casual Leave",
    //                    DefaultDays = 7
    //                }
    //            );
    //        }

    //        // Create Admin
    //        if (!db.Users.Any(u => u.Username == "admin"))
    //        {
    //            db.Users.Add(new User
    //            {
    //                Username = "admin",
    //                PasswordHash = PasswordHelper.HashPassword("Admin@123"),
    //                Role = UserRole.Admin.ToString(),
    //                IsActive = true
    //            });
    //        }

    //        // Create HR Manager
    //        if (!db.Users.Any(u => u.Username == "hrmanager"))
    //        {
    //            db.Users.Add(new User
    //            {
    //                Username = "hrmanager",
    //                PasswordHash = PasswordHelper.HashPassword("HR@123"),
    //                Role = UserRole.HRManager.ToString(),
    //                IsActive = true
    //            });
    //        }

    //        db.SaveChanges();
    //    }
    //}

    public static class DbSeeder
    {
        public static void Seed()
        {
            using var db = new HRDbContext();

            // =========================================
            // CREATE DEFAULT DEPARTMENTS
            // =========================================

            if (!db.Departments.Any())
            {
                db.Departments.AddRange(
                    new Department
                    {
                        DepartmentName = "Information Technology",
                        Description = "IT Department"
                    },

                    new Department
                    {
                        DepartmentName = "Human Resources",
                        Description = "Human Resources Department"
                    },

                    new Department
                    {
                        DepartmentName = "Finance",
                        Description = "Finance Department"
                    }
                );

                db.SaveChanges();
            }


            // =========================================
            // CREATE DEFAULT LEAVE TYPES
            // =========================================

            if (!db.LeaveTypes.Any())
            {
                db.LeaveTypes.AddRange(
                    new LeaveType
                    {
                        Name = "Annual Leave",
                        DefaultDays = 14
                    },

                    new LeaveType
                    {
                        Name = "Sick Leave",
                        DefaultDays = 7
                    },

                    new LeaveType
                    {
                        Name = "Casual Leave",
                        DefaultDays = 7
                    }
                );

                // Save first so LeaveType IDs are generated
                db.SaveChanges();
            }


            // =========================================
            // CREATE ADMIN USER
            // =========================================

            if (!db.Users.Any(u => u.Username == "admin"))
            {
                db.Users.Add(new User
                {
                    Username = "admin",
                    PasswordHash =
                        PasswordHelper.HashPassword("Admin@123"),

                    Role = UserRole.Admin.ToString(),

                    IsActive = true
                });
            }


            // =========================================
            // CREATE HR MANAGER USER
            // =========================================

            if (!db.Users.Any(u => u.Username == "hrmanager"))
            {
                db.Users.Add(new User
                {
                    Username = "hrmanager",
                    PasswordHash =
                        PasswordHelper.HashPassword("HR@123"),

                    Role = UserRole.HRManager.ToString(),

                    IsActive = true
                });
            }

            db.SaveChanges();


            // =========================================
            // CREATE LEAVE BALANCES FOR EXISTING EMPLOYEES
            // =========================================

            var employees = db.Employees.ToList();

            var leaveTypes = db.LeaveTypes.ToList();

            foreach (var employee in employees)
            {
                foreach (var leaveType in leaveTypes)
                {
                    // Check whether this employee already has a balance for this leave type
                    bool balanceExists = db.LeaveBalances.Any(
                        lb =>
                            lb.EmployeeId == employee.Id &&
                            lb.LeaveTypeId == leaveType.Id
                    );

                    if (!balanceExists)
                    {
                        db.LeaveBalances.Add(
                            new LeaveBalance
                            {
                                EmployeeId = employee.Id,

                                LeaveTypeId = leaveType.Id,

                                AllocatedDays =
                                    leaveType.DefaultDays,

                                UsedDays = 0
                            }
                        );
                    }
                }
            }

            db.SaveChanges();
        }
    }
}
