using HRManagementSystem.Data;
using HRManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Services
{
    public class DepartmentService
    {
        public List<Department> GetAll()
        {
            using var db = new HRDbContext();

            return db.Departments
                .OrderBy(d => d.DepartmentName)
                .ToList();
        }

        public List<Department> Search(string searchText)
        {
            using var db = new HRDbContext();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                return GetAll();
            }

            return db.Departments
                .Where(d =>
                    d.DepartmentName.Contains(searchText) ||
                    d.Description.Contains(searchText))
                .OrderBy(d => d.DepartmentName)
                .ToList();
        }

        public void Add(string name, string description)
        {
            using var db = new HRDbContext();

            var exists = db.Departments.Any(d =>
                d.DepartmentName.ToLower() == name.ToLower());

            if (exists)
            {
                throw new Exception("A department with this name already exists.");
            }

            var department = new Department
            {
                DepartmentName = name,
                Description = description
            };

            db.Departments.Add(department);
            db.SaveChanges();
        }

        public void Update(int id, string name, string description)
        {
            using var db = new HRDbContext();

            var department = db.Departments.Find(id);

            if (department == null)
            {
                throw new Exception("Department not found.");
            }

            var exists = db.Departments.Any(d =>
                d.Id != id &&
                d.DepartmentName.ToLower() == name.ToLower());

            if (exists)
            {
                throw new Exception("A department with this name already exists.");
            }

            department.DepartmentName = name;
            department.Description = description;

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new HRDbContext();

            var department = db.Departments.Find(id);

            if (department == null)
            {
                throw new Exception("Department not found.");
            }

            var hasEmployees = db.Employees
                .Any(e => e.DepartmentId == id);

            if (hasEmployees)
            {
                throw new Exception(
                    "This department cannot be deleted because employees are assigned to it.");
            }

            db.Departments.Remove(department);
            db.SaveChanges();
        }
    }
}
