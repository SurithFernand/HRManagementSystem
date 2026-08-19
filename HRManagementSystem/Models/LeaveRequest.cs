using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Models
{
    public class LeaveRequest
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveType? LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
        public DateTime AppliedDate { get; set; } = DateTime.Now;
        public int? ApprovedBy { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime? DecisionDate { get; set; }
        public string? DecisionComment { get; set; }
    }
}
