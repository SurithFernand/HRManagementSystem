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
    public class LeaveService
    {
        // ==========================================
        // GET LEAVE TYPES
        // ==========================================

        public List<LeaveType> GetLeaveTypes()
        {
            using var db = new HRDbContext();

            return db.LeaveTypes
                .OrderBy(lt => lt.Name)
                .ToList();
        }


        // ==========================================
        // GET EMPLOYEE LEAVE BALANCES
        // ==========================================

        public List<LeaveBalance> GetEmployeeBalances(
            int employeeId)
        {
            using var db = new HRDbContext();

            return db.LeaveBalances
                .Include(lb => lb.LeaveType)
                .Where(lb => lb.EmployeeId == employeeId)
                .OrderBy(lb => lb.LeaveType!.Name)
                .ToList();
        }


        // ==========================================
        // GET ALL LEAVE REQUESTS
        // ==========================================

        public List<LeaveRequest> GetAllRequests()
        {
            using var db = new HRDbContext();

            return db.LeaveRequests
                .Include(lr => lr.Employee)
                .Include(lr => lr.LeaveType)
                .OrderByDescending(lr => lr.AppliedDate)
                .ToList();
        }


        // ==========================================
        // GET EMPLOYEE LEAVE REQUESTS
        // ==========================================

        public List<LeaveRequest> GetEmployeeRequests(
            int employeeId)
        {
            using var db = new HRDbContext();

            return db.LeaveRequests
                .Include(lr => lr.LeaveType)
                .Where(lr => lr.EmployeeId == employeeId)
                .OrderByDescending(lr => lr.AppliedDate)
                .ToList();
        }


        // ==========================================
        // APPLY FOR LEAVE
        // ==========================================

        public void ApplyLeave(
            int employeeId,
            int leaveTypeId,
            DateTime startDate,
            DateTime endDate,
            string reason)
        {
            using var db = new HRDbContext();

            // Validate dates
            if (startDate.Date > endDate.Date)
            {
                throw new Exception(
                    "Start date cannot be after end date.");
            }

            if (startDate.Date < DateTime.Today)
            {
                throw new Exception(
                    "Leave cannot be applied for a past date.");
            }

            // Validate reason
            if (string.IsNullOrWhiteSpace(reason))
            {
                throw new Exception(
                    "Please provide a reason for the leave.");
            }

            // Calculate number of days
            int numberOfDays =
                (endDate.Date - startDate.Date).Days + 1;


            // Check for overlapping requests
            bool overlappingRequest =
                db.LeaveRequests.Any(lr =>
                    lr.EmployeeId == employeeId &&
                    lr.Status != "Rejected" &&
                    startDate.Date <= lr.EndDate.Date &&
                    endDate.Date >= lr.StartDate.Date);

            if (overlappingRequest)
            {
                throw new Exception(
                    "This leave period overlaps with an existing leave request.");
            }


            // Find employee leave balance
            var balance = db.LeaveBalances
                .FirstOrDefault(lb =>
                    lb.EmployeeId == employeeId &&
                    lb.LeaveTypeId == leaveTypeId);

            if (balance == null)
            {
                throw new Exception(
                    "Leave balance was not found for this employee.");
            }


            // Check available leave
            if (balance.RemainingDays < numberOfDays)
            {
                throw new Exception(
                    $"Insufficient leave balance. " +
                    $"Remaining days: {balance.RemainingDays}.");
            }


            // Create request
            var request = new LeaveRequest
            {
                EmployeeId = employeeId,
                LeaveTypeId = leaveTypeId,
                StartDate = startDate.Date,
                EndDate = endDate.Date,
                NumberOfDays = numberOfDays,
                Reason = reason.Trim(),
                Status = "Pending",
                AppliedDate = DateTime.Now
            };

            db.LeaveRequests.Add(request);

            db.SaveChanges();
        }


        // ==========================================
        // APPROVE LEAVE
        // ==========================================

        public void ApproveLeave(
            int leaveRequestId,
            int approvedBy,
            string? comment = null)
        {
            using var db = new HRDbContext();

            var request = db.LeaveRequests
                .FirstOrDefault(lr =>
                    lr.Id == leaveRequestId);

            if (request == null)
            {
                throw new Exception(
                    "Leave request not found.");
            }

            if (request.Status != "Pending")
            {
                throw new Exception(
                    "Only pending leave requests can be approved.");
            }


            // Find balance
            var balance = db.LeaveBalances
                .FirstOrDefault(lb =>
                    lb.EmployeeId == request.EmployeeId &&
                    lb.LeaveTypeId == request.LeaveTypeId);

            if (balance == null)
            {
                throw new Exception(
                    "Leave balance was not found.");
            }


            // Check balance again before approval
            if (balance.RemainingDays <
                request.NumberOfDays)
            {
                throw new Exception(
                    "There are not enough remaining leave days.");
            }


            // Approve request
            request.Status = "Approved";

            request.ApprovedBy = approvedBy;

            request.DecisionDate = DateTime.Now;

            request.DecisionComment = comment;


            // Update used leave
            balance.UsedDays += request.NumberOfDays;

            db.SaveChanges();
        }


        // ==========================================
        // REJECT LEAVE
        // ==========================================

        public void RejectLeave(
            int leaveRequestId,
            int approvedBy,
            string? comment = null)
        {
            using var db = new HRDbContext();

            var request = db.LeaveRequests
                .FirstOrDefault(lr =>
                    lr.Id == leaveRequestId);

            if (request == null)
            {
                throw new Exception(
                    "Leave request not found.");
            }

            if (request.Status != "Pending")
            {
                throw new Exception(
                    "Only pending leave requests can be rejected.");
            }


            // Reject request
            request.Status = "Rejected";

            request.ApprovedBy = approvedBy;

            request.DecisionDate = DateTime.Now;

            request.DecisionComment = comment;


            // We DO NOT increase UsedDays here.

            db.SaveChanges();
        }
    }
}
