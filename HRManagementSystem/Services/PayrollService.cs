using HRManagementSystem.Data;
using HRManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Services
{
    public class PayrollService
    {
        // Get all payroll records
        public List<Payroll> GetAllPayrolls()
        {
            using var db = new HRDbContext();

            return db.Payrolls
                .Include(p => p.Employee)
                .OrderByDescending(p => p.Year)
                .ThenByDescending(p => p.Month)
                .ToList();
        }


        // Get payroll records for one employee
        public List<Payroll> GetEmployeePayrolls(int employeeId)
        {
            using var db = new HRDbContext();

            return db.Payrolls
                .Include(p => p.Employee)
                .Where(p => p.EmployeeId == employeeId)
                .OrderByDescending(p => p.Year)
                .ThenByDescending(p => p.Month)
                .ToList();
        }


        // Get one payroll
        public Payroll? GetPayroll(int id)
        {
            using var db = new HRDbContext();

            return db.Payrolls
                .Include(p => p.Employee)
                .FirstOrDefault(p => p.Id == id);
        }


        // Generate payroll
        public Payroll GeneratePayroll(
            int employeeId,
            int year,
            int month,
            decimal overtime,
            decimal allowances,
            decimal deductions)
        {
            using var db = new HRDbContext();

            // Find employee
            var employee = db.Employees
                .FirstOrDefault(e => e.Id == employeeId);

            if (employee == null)
            {
                throw new Exception(
                    "Employee not found.");
            }


            // Prevent duplicate payroll
            bool exists = db.Payrolls.Any(p =>
                p.EmployeeId == employeeId &&
                p.Year == year &&
                p.Month == month);

            if (exists)
            {
                throw new Exception(
                    "Payroll already exists for this employee and month.");
            }


            // Basic salary comes from Employee
            decimal basicSalary = employee.Salary;


            // ==========================================
            // ATTENDANCE
            // ==========================================

            var attendanceRecords = db.Attendances
                .Where(a =>
                    a.EmployeeId == employeeId &&
                    a.Date.Year == year &&
                    a.Date.Month == month)
                .ToList();


            int absentDays = attendanceRecords
                .Count(a => a.Status == "Absent");


            decimal dailySalary =
                basicSalary / 30m;


            decimal attendanceDeduction =
                absentDays * dailySalary;


            // ==========================================
            // LEAVE
            // ==========================================

            // For now approved leave is considered
            // paid leave, so it does not reduce salary.

            decimal leaveDeduction = 0m;


            // ==========================================
            // NET SALARY
            // ==========================================

            decimal netSalary =
                basicSalary
                + overtime
                + allowances
                - deductions
                - leaveDeduction
                - attendanceDeduction;


            // Prevent negative salary
            if (netSalary < 0)
            {
                netSalary = 0;
            }


            // ==========================================
            // CREATE PAYROLL
            // ==========================================

            var payroll = new Payroll
            {
                EmployeeId = employeeId,

                Month = month,

                Year = year,

                BasicSalary = basicSalary,

                Overtime = overtime,

                Allowances = allowances,

                Deductions = deductions,

                LeaveDeduction = leaveDeduction,

                AttendanceDeduction =
                    attendanceDeduction,

                NetSalary = netSalary,

                GeneratedDate = DateTime.Now
            };


            db.Payrolls.Add(payroll);

            db.SaveChanges();

            return payroll;
        }


        // Delete payroll
        public void DeletePayroll(int id)
        {
            using var db = new HRDbContext();

            var payroll = db.Payrolls
                .FirstOrDefault(p => p.Id == id);

            if (payroll == null)
            {
                throw new Exception(
                    "Payroll record not found.");
            }

            db.Payrolls.Remove(payroll);

            db.SaveChanges();
        }
    }
    //public class PayrollService
    //{
    //    // ==========================================
    //    // GET ALL PAYROLL RECORDS
    //    // ==========================================

    //    public List<Payroll> GetAllPayrolls()
    //    {
    //        using var db = new HRDbContext();

    //        return db.Payrolls
    //            .Include(p => p.Employee)
    //            .OrderByDescending(p => p.Year)
    //            .ThenByDescending(p => p.Month)
    //            .ToList();
    //    }


    //    // ==========================================
    //    // GET EMPLOYEE PAYROLL
    //    // ==========================================

    //    public List<Payroll> GetEmployeePayrolls(
    //        int employeeId)
    //    {
    //        using var db = new HRDbContext();

    //        return db.Payrolls
    //            .Include(p => p.Employee)
    //            .Where(p => p.EmployeeId == employeeId)
    //            .OrderByDescending(p => p.Year)
    //            .ThenByDescending(p => p.Month)
    //            .ToList();
    //    }


    //    // ==========================================
    //    // GET SPECIFIC PAYROLL
    //    // ==========================================

    //    public Payroll? GetPayroll(int id)
    //    {
    //        using var db = new HRDbContext();

    //        return db.Payrolls
    //            .Include(p => p.Employee)
    //            .FirstOrDefault(p => p.Id == id);
    //    }


    //    // ==========================================
    //    // CALCULATE PAYROLL
    //    // ==========================================

    //    public Payroll CalculatePayroll(
    //        int employeeId,
    //        int year,
    //        int month,
    //        decimal overtimePay,
    //        decimal otherDeductions)
    //    {
    //        using var db = new HRDbContext();

    //        // --------------------------------------
    //        // Find employee
    //        // --------------------------------------

    //        var employee = db.Employees
    //            .FirstOrDefault(e => e.Id == employeeId);

    //        if (employee == null)
    //        {
    //            throw new Exception(
    //                "Employee not found.");
    //        }


    //        // --------------------------------------
    //        // Check duplicate payroll
    //        // --------------------------------------

    //        bool alreadyExists = db.Payrolls.Any(
    //            p =>
    //                p.EmployeeId == employeeId &&
    //                p.Year == year &&
    //                p.Month == month);

    //        if (alreadyExists)
    //        {
    //            throw new Exception(
    //                "Payroll already exists for this employee and month.");
    //        }


    //        // --------------------------------------
    //        // Basic salary
    //        // --------------------------------------

    //        decimal basicSalary = employee.Salary;


    //        // --------------------------------------
    //        // Calculate attendance
    //        // --------------------------------------

    //        var attendanceRecords = db.Attendances
    //            .Where(a =>
    //                a.EmployeeId == employeeId &&
    //                a.Date.Year == year &&
    //                a.Date.Month == month)
    //            .ToList();


    //        // --------------------------------------
    //        // Attendance deduction
    //        // --------------------------------------

    //        int absentDays = attendanceRecords
    //            .Count(a => a.Status == "Absent");


    //        decimal dailySalary =
    //            basicSalary / 30m;

    //        decimal attendanceDeduction =
    //            absentDays * dailySalary;


    //        // --------------------------------------
    //        // Calculate approved leave
    //        // --------------------------------------

    //        var approvedLeaves = db.LeaveRequests
    //            .Where(lr =>
    //                lr.EmployeeId == employeeId &&
    //                lr.Status == "Approved" &&
    //                lr.StartDate.Year <= year &&
    //                lr.EndDate.Year >= year)
    //            .ToList();


    //        int approvedLeaveDays = 0;

    //        foreach (var leave in approvedLeaves)
    //        {
    //            DateTime start =
    //                leave.StartDate.Date;

    //            DateTime end =
    //                leave.EndDate.Date;

    //            for (
    //                DateTime date = start;
    //                date <= end;
    //                date = date.AddDays(1))
    //            {
    //                if (date.Year == year &&
    //                    date.Month == month)
    //                {
    //                    approvedLeaveDays++;
    //                }
    //            }
    //        }


    //        // --------------------------------------
    //        // Leave deduction
    //        // --------------------------------------

    //        // Paid leave does not reduce salary.
    //        // Leave deduction is therefore initially 0.

    //        decimal leaveDeduction = 0m;


    //        // --------------------------------------
    //        // Net salary
    //        // --------------------------------------

    //        decimal netSalary =
    //            basicSalary
    //            + overtimePay
    //            - attendanceDeduction
    //            - leaveDeduction
    //            - otherDeductions;


    //        // --------------------------------------
    //        // Create payroll
    //        // --------------------------------------

    //        var payroll = new Payroll
    //        {
    //            EmployeeId = employeeId,

    //            Year = year,

    //            Month = month,

    //            BasicSalary = basicSalary,

    //            Overtime = overtimePay,

    //            LeaveDeduction = leaveDeduction,

    //            AttendanceDeduction =
    //                attendanceDeduction,

    //            Deductions =
    //                otherDeductions,

    //            NetSalary = netSalary,

    //            GeneratedDate = DateTime.Now,

    //            Status = "Generated"
    //        };


    //        db.Payrolls.Add(payroll);

    //        db.SaveChanges();

    //        return payroll;
    //    }


    //    // ==========================================
    //    // DELETE PAYROLL
    //    // ==========================================

    //    public void DeletePayroll(int id)
    //    {
    //        using var db = new HRDbContext();

    //        var payroll = db.Payrolls
    //            .FirstOrDefault(p => p.Id == id);

    //        if (payroll == null)
    //        {
    //            throw new Exception(
    //                "Payroll record not found.");
    //        }

    //        db.Payrolls.Remove(payroll);

    //        db.SaveChanges();
    //    }
    //}
}
