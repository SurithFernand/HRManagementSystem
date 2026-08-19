using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Models
{
    public class LeaveBalance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveType? LeaveType { get; set; }
        public int AllocatedDays { get; set; }
        public int UsedDays { get; set; }
        public int RemainingDays => AllocatedDays - UsedDays;
    }
}
