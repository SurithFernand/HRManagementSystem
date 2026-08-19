using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Models
{
    public class Payroll
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public Employee? Employee { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public decimal BasicSalary { get; set; }

        public decimal Overtime { get; set; }

        public decimal Allowances { get; set; }

        public decimal Deductions { get; set; }

        public decimal LeaveDeduction { get; set; }

        public decimal AttendanceDeduction { get; set; }

        public decimal NetSalary { get; set; }

        public DateTime GeneratedDate { get; set; } = DateTime.Now;

        public string Status { get; set; } = "Generated";
    }

}