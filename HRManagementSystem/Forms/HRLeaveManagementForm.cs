using HRManagementSystem.Helpers;
using HRManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagementSystem.Forms
{
    public partial class HRLeaveManagementForm : Form
    {
        private readonly LeaveService _leaveService = new LeaveService();
        public HRLeaveManagementForm()
        {
            InitializeComponent();
        }

        private bool IsHRManager()
        {
            if (Session.CurrentUser == null)
            {
                return false;
            }

            return Session.CurrentUser.Role ==
                   UserRole.HRManager.ToString()
                   ||
                   Session.CurrentUser.Role ==
                   UserRole.Admin.ToString();
        }

        private void HRLeaveManagementForm_Load(object sender, EventArgs e)
        {
            if (!IsHRManager())
            {
                MessageBox.Show(
                    "You do not have permission to access Leave Management.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();

                return;
            }

            LoadRequests();
        }

        private void LoadRequests()
        {
            try
            {
                var requests = _leaveService.GetAllRequests();

                dgvLeaveRequests.DataSource = requests
                    .Select(r => new
                    {
                        ID = r.Id,

                        Employee =
                            r.Employee == null
                                ? ""
                                : r.Employee.FirstName + " " +
                                  r.Employee.LastName,

                        EmployeeCode =
                            r.Employee?.EmployeeCode ?? "",

                        LeaveType =
                            r.LeaveType?.Name ?? "",

                        StartDate =
                            r.StartDate.ToShortDateString(),

                        EndDate =
                            r.EndDate.ToShortDateString(),

                        Days = r.NumberOfDays,

                        Status = r.Status,

                        Reason = r.Reason,

                        AppliedDate =
                            r.AppliedDate.ToShortDateString()
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading leave requests:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void ApproveSelectedRequest()
        {
            try
            {
                if (dgvLeaveRequests.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a leave request.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (Session.CurrentUser == null)
                {
                    MessageBox.Show(
                        "No user is currently logged in.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                int requestId =
                    Convert.ToInt32(
                        dgvLeaveRequests
                            .SelectedRows[0]
                            .Cells["ID"]
                            .Value);

                int approvedBy =
                    Session.CurrentUser.Id;

                string comment =
                    txtDecisionComment.Text.Trim();

                var confirm = MessageBox.Show(
                    "Are you sure you want to approve this leave request?",
                    "Confirm Approval",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                {
                    return;
                }

                _leaveService.ApproveLeave(
                    requestId,
                    approvedBy,
                    comment);

                MessageBox.Show(
                    "Leave request approved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtDecisionComment.Clear();

                LoadRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Approve Leave",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            ApproveSelectedRequest();
        }

        

        private void RejectSelectedRequest()
        {
            try
            {
                if (dgvLeaveRequests.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a leave request.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (Session.CurrentUser == null)
                {
                    MessageBox.Show(
                        "No user is currently logged in.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                int requestId =
                    Convert.ToInt32(
                        dgvLeaveRequests
                            .SelectedRows[0]
                            .Cells["ID"]
                            .Value);

                int approvedBy =
                    Session.CurrentUser.Id;

                string comment =
                    txtDecisionComment.Text.Trim();

                var confirm = MessageBox.Show(
                    "Are you sure you want to reject this leave request?",
                    "Confirm Rejection",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                {
                    return;
                }

                _leaveService.RejectLeave(
                    requestId,
                    approvedBy,
                    comment);

                MessageBox.Show(
                    "Leave request rejected.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtDecisionComment.Clear();

                LoadRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Reject Leave",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            RejectSelectedRequest();
        }


    }
}
