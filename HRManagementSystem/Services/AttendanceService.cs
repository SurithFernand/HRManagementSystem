using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManagementSystem.Data;
using HRManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HRManagementSystem.Services
{
    public class AttendanceService
    {
        public List<Attendance> GetAll()
        {
            using var db = new HRDbContext();

            return db.Attendances
                .Include(a => a.Employee)
                .OrderByDescending(a => a.Date)
                .ThenByDescending(a => a.CheckIn)
                .ToList();
        }

        public List<Attendance> GetByEmployee(int employeeId)
        {
            using var db = new HRDbContext();

            return db.Attendances
                .Include(a => a.Employee)
                .Where(a => a.EmployeeId == employeeId)
                .OrderByDescending(a => a.Date)
                .ToList();
        }

        public Attendance? GetTodayAttendance(int employeeId)
        {
            using var db = new HRDbContext();

            DateTime today = DateTime.Today;

            return db.Attendances
                .FirstOrDefault(a =>
                    a.EmployeeId == employeeId &&
                    a.Date == today);
        }

        public void CheckIn(int employeeId)
        {
            using var db = new HRDbContext();

            DateTime today = DateTime.Today;

            var existingAttendance = db.Attendances
                .FirstOrDefault(a =>
                    a.EmployeeId == employeeId &&
                    a.Date == today);

            if (existingAttendance != null)
            {
                throw new Exception(
                    "Attendance has already been recorded for today.");
            }

            var attendance = new Attendance
            {
                EmployeeId = employeeId,
                Date = today,
                CheckIn = DateTime.Now,
                CheckOut = null,
                TotalHours = 0,
                Status = "Present"
            };

            db.Attendances.Add(attendance);

            db.SaveChanges();
        }

        public void CheckOut(int employeeId)
        {
            using var db = new HRDbContext();

            DateTime today = DateTime.Today;

            var attendance = db.Attendances
                .FirstOrDefault(a =>
                    a.EmployeeId == employeeId &&
                    a.Date == today);

            if (attendance == null)
            {
                throw new Exception(
                    "The employee has not checked in today.");
            }

            if (attendance.CheckIn == null)
            {
                throw new Exception(
                    "Check-in time is missing.");
            }

            if (attendance.CheckOut != null)
            {
                throw new Exception(
                    "The employee has already checked out today.");
            }

            attendance.CheckOut = DateTime.Now;

            TimeSpan duration =
                attendance.CheckOut.Value -
                attendance.CheckIn.Value;

            attendance.TotalHours =
                Math.Round(
                    (decimal)duration.TotalHours,
                    2);

            db.SaveChanges();
        }

        public List<Attendance> Search(
            string? employeeSearch,
            DateTime? date)
        {
            using var db = new HRDbContext();

            var query = db.Attendances
                .Include(a => a.Employee)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(employeeSearch))
            {
                query = query.Where(a =>
                    a.Employee!.EmployeeCode.Contains(
                        employeeSearch) ||
                    a.Employee.FirstName.Contains(
                        employeeSearch) ||
                    a.Employee.LastName.Contains(
                        employeeSearch));
            }

            if (date.HasValue)
            {
                query = query.Where(a =>
                    a.Date == date.Value.Date);
            }

            return query
                .OrderByDescending(a => a.Date)
                .ToList();
        }
    }
}
