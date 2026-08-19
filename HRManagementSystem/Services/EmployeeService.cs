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
    public class EmployeeService
    {
        public List<Employee> GetAll()
        {
            using var db = new HRDbContext();

            return db.Employees
                .Include(e => e.Department)
                .OrderBy(e => e.EmployeeCode)
                .ToList();
        }

        public Employee? GetById(int id)
        {
            using var db = new HRDbContext();

            return db.Employees
                .Include(e => e.Department)
                .FirstOrDefault(e => e.Id == id);
        }

        public List<Employee> Search(
            string searchText,
            int? departmentId = null,
            string? position = null)
        {
            using var db = new HRDbContext();

            var query = db.Employees
                .Include(e => e.Department)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                query = query.Where(e =>
                    e.EmployeeCode.Contains(searchText) ||
                    e.FirstName.Contains(searchText) ||
                    e.LastName.Contains(searchText) ||
                    e.Email.Contains(searchText));
            }

            if (departmentId.HasValue)
            {
                query = query.Where(e =>
                    e.DepartmentId == departmentId.Value);
            }

            if (!string.IsNullOrWhiteSpace(position))
            {
                query = query.Where(e =>
                    e.Position.Contains(position));
            }

            return query
                .OrderBy(e => e.EmployeeCode)
                .ToList();
        }

        //public void Add(Employee employee)
        //{
        //    using var db = new HRDbContext();

        //    bool codeExists = db.Employees.Any(e =>
        //        e.EmployeeCode.ToLower() ==
        //        employee.EmployeeCode.ToLower());

        //    if (codeExists)
        //    {
        //        throw new Exception(
        //            "An employee with this employee code already exists.");
        //    }

        //    bool emailExists = db.Employees.Any(e =>
        //        e.Email.ToLower() ==
        //        employee.Email.ToLower());

        //    if (emailExists)
        //    {
        //        throw new Exception(
        //            "An employee with this email already exists.");
        //    }

        //    bool departmentExists = db.Departments.Any(d =>
        //        d.Id == employee.DepartmentId);

        //    if (!departmentExists)
        //    {
        //        throw new Exception(
        //            "The selected department does not exist.");
        //    }

        //    db.Employees.Add(employee);

        //    db.SaveChanges();
        //}
        public Employee Add(Employee employee)
        {
            using var db = new HRDbContext();

            bool codeExists = db.Employees.Any(e =>
                e.EmployeeCode.ToLower() ==
                employee.EmployeeCode.ToLower());

            if (codeExists)
            {
                throw new Exception(
                    "An employee with this employee code already exists.");
            }

            bool emailExists = db.Employees.Any(e =>
                e.Email.ToLower() ==
                employee.Email.ToLower());

            if (emailExists)
            {
                throw new Exception(
                    "An employee with this email already exists.");
            }

            bool departmentExists = db.Departments.Any(d =>
                d.Id == employee.DepartmentId);

            if (!departmentExists)
            {
                throw new Exception(
                    "The selected department does not exist.");
            }

            db.Employees.Add(employee);

            db.SaveChanges();

            return employee;
        }

        public void Update(Employee employee)
        {
            using var db = new HRDbContext();

            var existingEmployee =
                db.Employees.Find(employee.Id);

            if (existingEmployee == null)
            {
                throw new Exception("Employee not found.");
            }

            bool codeExists = db.Employees.Any(e =>
                e.Id != employee.Id &&
                e.EmployeeCode.ToLower() ==
                employee.EmployeeCode.ToLower());

            if (codeExists)
            {
                throw new Exception(
                    "Another employee already uses this employee code.");
            }

            bool emailExists = db.Employees.Any(e =>
                e.Id != employee.Id &&
                e.Email.ToLower() ==
                employee.Email.ToLower());

            if (emailExists)
            {
                throw new Exception(
                    "Another employee already uses this email.");
            }

            existingEmployee.EmployeeCode =
                employee.EmployeeCode;

            existingEmployee.FirstName =
                employee.FirstName;

            existingEmployee.LastName =
                employee.LastName;

            existingEmployee.DateOfBirth =
                employee.DateOfBirth;

            existingEmployee.Gender =
                employee.Gender;

            existingEmployee.Email =
                employee.Email;

            existingEmployee.Phone =
                employee.Phone;

            existingEmployee.Address =
                employee.Address;

            existingEmployee.DepartmentId =
                employee.DepartmentId;

            existingEmployee.Position =
                employee.Position;

            existingEmployee.Salary =
                employee.Salary;

            existingEmployee.DateJoined =
                employee.DateJoined;

            existingEmployee.Status =
                employee.Status;

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new HRDbContext();

            var employee = db.Employees.Find(id);

            if (employee == null)
            {
                throw new Exception("Employee not found.");
            }

            db.Employees.Remove(employee);

            db.SaveChanges();
        }
    }
}
