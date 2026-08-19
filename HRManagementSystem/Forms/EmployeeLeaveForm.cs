using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRManagementSystem.Helpers;
using HRManagementSystem.Models;
using HRManagementSystem.Services;

namespace HRManagementSystem.Forms
{
    public partial class EmployeeLeaveForm : Form
    {
        private readonly LeaveService _leaveService = new LeaveService();

        public EmployeeLeaveForm()
        {
            InitializeComponent();

        }

        //private void LoadData()
        //{
        //    try
        //    {
        //        if (Session.CurrentUser == null)
        //        {
        //            MessageBox.Show(
        //                "No user is currently logged in.",
        //                "Error",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Error);

        //            return;
        //        }

        //        if (Session.CurrentUser.EmployeeId == null)
        //        {
        //            MessageBox.Show(
        //                "This user is not linked to an employee.",
        //                "Error",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Error);

        //            return;
        //        }

        //        int employeeId =
        //            Session.CurrentUser.EmployeeId.Value;

        //        LoadLeaveTypes(employeeId);

        //        LoadLeaveBalances(employeeId);

        //        LoadLeaveRequests(employeeId);

        //        CalculateNumberOfDays();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(
        //            "Error loading leave information:\n" +
        //            ex.Message,
        //            "Error",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }
        //}
        private void LoadData()
        {
            try
            {
                if (Session.CurrentUser == null)
                {
                    MessageBox.Show(
                        "No user is currently logged in.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                if (Session.CurrentUser.EmployeeId == null)
                {
                    MessageBox.Show(
                        "This user is not linked to an employee.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                int employeeId =
                    Session.CurrentUser.EmployeeId.Value;

                LoadLeaveTypes();

                LoadLeaveBalances(employeeId);

                LoadLeaveRequests(employeeId);

                CalculateNumberOfDays();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading leave information:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //private void LoadLeaveTypes(int employeeId)
        //{
        //    var leaveTypes = _leaveService.GetLeaveTypes();

        //    cmbLeaveType.DataSource = leaveTypes;

        //    cmbLeaveType.DisplayMember = "Name";

        //    cmbLeaveType.ValueMember = "Id";

        //    if (leaveTypes.Count > 0)
        //    {
        //        cmbLeaveType.SelectedIndex = 0;
        //    }
        //}
        private void LoadLeaveTypes()
        {
            var leaveTypes =
                _leaveService.GetLeaveTypes();

            cmbLeaveType.DataSource = null;

            cmbLeaveType.DisplayMember = "Name";
            cmbLeaveType.ValueMember = "Id";

            cmbLeaveType.DataSource = leaveTypes;

            if (leaveTypes.Count > 0)
            {
                cmbLeaveType.SelectedIndex = 0;
            }
            else
            {
                cmbLeaveType.SelectedIndex = -1;
            }
        }

        private void LoadLeaveBalances(int employeeId)
        {
            var balances =
                _leaveService.GetEmployeeBalances(employeeId);

            dgvLeaveBalances.DataSource = balances
                .Select(b => new
                {
                    LeaveType = b.LeaveType?.Name ?? "",
                    Allocated = b.AllocatedDays,
                    Used = b.UsedDays,
                    Remaining = b.RemainingDays
                })
                .ToList();
        }

        private void LoadLeaveRequests(int employeeId)
        {
            var requests =
                _leaveService.GetEmployeeRequests(employeeId);

            dgvLeaveRequests.DataSource = requests
                .Select(r => new
                {
                    ID = r.Id,
                    LeaveType = r.LeaveType?.Name ?? "",
                    StartDate = r.StartDate.ToShortDateString(),
                    EndDate = r.EndDate.ToShortDateString(),
                    Days = r.NumberOfDays,
                    Status = r.Status,
                    Reason = r.Reason,
                    AppliedDate = r.AppliedDate.ToShortDateString()
                })
                .ToList();
        }

        private void CalculateNumberOfDays()
        {
            if (dtpEndDate.Value.Date <
                dtpStartDate.Value.Date)
            {
                lblDaysValue.Text = "0";
                return;
            }

            int days =
                (dtpEndDate.Value.Date -
                 dtpStartDate.Value.Date).Days + 1;

            lblDaysValue.Text = days.ToString();
        }

        //private void UpdateAvailableDays()
        //{
        //    if (Session.CurrentUser?.EmployeeId == null)
        //    {
        //        return;
        //    }

        //    if (cmbLeaveType.SelectedValue == null)
        //    {
        //        return;
        //    }

        //    int employeeId =
        //        Session.CurrentUser.EmployeeId.Value;

        //    int leaveTypeId =
        //        Convert.ToInt32(cmbLeaveType.SelectedValue);

        //    var balances =
        //        _leaveService.GetEmployeeBalances(employeeId);

        //    var balance = balances.FirstOrDefault(
        //        b => b.LeaveTypeId == leaveTypeId);

        //    if (balance == null)
        //    {
        //        lblAvailableDays.Text = "0 days";
        //        return;
        //    }

        //    lblAvailableDays.Text =
        //        $"{balance.RemainingDays} days";
        //}
        private void UpdateAvailableDays()
        {
            if (Session.CurrentUser?.EmployeeId == null)
            {
                return;
            }

            if (cmbLeaveType.SelectedItem is not LeaveType selectedLeaveType)
            {
                lblAvailableDays.Text = "0 days";
                return;
            }

            int employeeId =
                Session.CurrentUser.EmployeeId.Value;

            int leaveTypeId =
                selectedLeaveType.Id;

            var balances =
                _leaveService.GetEmployeeBalances(employeeId);

            var balance = balances.FirstOrDefault(
                b => b.LeaveTypeId == leaveTypeId);

            if (balance == null)
            {
                lblAvailableDays.Text = "0 days";
                return;
            }

            lblAvailableDays.Text =
                $"{balance.RemainingDays} days";
        }



        //private void ApplyLeave()
        //{
        //    try
        //    {
        //        if (Session.CurrentUser?.EmployeeId == null)
        //        {
        //            MessageBox.Show(
        //                "You are not linked to an employee.",
        //                "Error",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Error);

        //            return;
        //        }

        //        if (cmbLeaveType.SelectedValue == null)
        //        {
        //            MessageBox.Show(
        //                "Please select a leave type.",
        //                "Validation",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Warning);

        //            return;
        //        }

        //        int employeeId =
        //            Session.CurrentUser.EmployeeId.Value;

        //        int leaveTypeId =
        //            Convert.ToInt32(cmbLeaveType.SelectedValue);

        //        DateTime startDate =
        //            dtpStartDate.Value.Date;

        //        DateTime endDate =
        //            dtpEndDate.Value.Date;

        //        string reason =
        //            txtReason.Text.Trim();

        //        _leaveService.ApplyLeave(
        //            employeeId,
        //            leaveTypeId,
        //            startDate,
        //            endDate,
        //            reason);

        //        MessageBox.Show(
        //            "Leave request submitted successfully.",
        //            "Success",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Information);

        //        txtReason.Clear();

        //        LoadData();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(
        //            ex.Message,
        //            "Unable to Apply Leave",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Warning);
        //    }
        //}
        private void ApplyLeave()
        {
            try
            {
                if (Session.CurrentUser?.EmployeeId == null)
                {
                    MessageBox.Show(
                        "You are not linked to an employee.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                if (cmbLeaveType.SelectedItem is not LeaveType selectedLeaveType)
                {
                    MessageBox.Show(
                        "Please select a leave type.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbLeaveType.Focus();

                    return;
                }

                int employeeId =
                    Session.CurrentUser.EmployeeId.Value;

                int leaveTypeId =
                    selectedLeaveType.Id;

                DateTime startDate =
                    dtpStartDate.Value.Date;

                DateTime endDate =
                    dtpEndDate.Value.Date;

                if (startDate > endDate)
                {
                    MessageBox.Show(
                        "Start date cannot be after end date.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string reason =
                    txtReason.Text.Trim();

                if (string.IsNullOrWhiteSpace(reason))
                {
                    MessageBox.Show(
                        "Please enter a reason for the leave.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtReason.Focus();

                    return;
                }

                _leaveService.ApplyLeave(
                    employeeId,
                    leaveTypeId,
                    startDate,
                    endDate,
                    reason);

                MessageBox.Show(
                    "Leave request submitted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtReason.Clear();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Apply Leave",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnApplyLeave_Click(object sender, EventArgs e)
        {
            ApplyLeave();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateNumberOfDays();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateNumberOfDays();
        }

        private void dtpEndDate_ValueChanged_1(object sender, EventArgs e)
        {
            CalculateNumberOfDays();
        }

        private void cmbLeaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAvailableDays();
        }

        private void EmployeeLeaveForm_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show(
                    "No user is currently logged in.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();

                return;
            }

            if (Session.CurrentUser.Role !=
                UserRole.Employee.ToString())
            {
                MessageBox.Show(
                    "This page is only available to employees.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();

                return;
            }


            LoadData();
        }



































































        //private void EmployeeLeaveForm_Load(object? sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (Session.CurrentUser == null)
        //        {
        //            MessageBox.Show(
        //                "No user is currently logged in.",
        //                "Error",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Error);

        //            Close();
        //            return;
        //        }

        //        if (Session.CurrentUser.EmployeeId == null)
        //        {
        //            MessageBox.Show(
        //                "This user is not linked to an employee.",
        //                "Error",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Error);

        //            Close();
        //            return;
        //        }

        //        _employeeId = Session.CurrentUser.EmployeeId.Value;

        //        LoadLeaveTypes();
        //        LoadLeaveBalances();
        //        LoadLeaveRequests();

        //        dtpStartDate.MinDate = DateTime.Today;
        //        dtpEndDate.MinDate = DateTime.Today;

        //        UpdateNumberOfDays();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(
        //            "Error loading leave information:\n\n" + ex.Message,
        //            "Error",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }
        //}

        //private void LoadLeaveTypes()
        //{
        //    var leaveTypes = _leaveService.GetLeaveTypes();

        //    cmbLeaveType.DataSource = leaveTypes;

        //    cmbLeaveType.DisplayMember = "Name";

        //    cmbLeaveType.ValueMember = "Id";
        //}

        //private void LoadLeaveBalances()
        //{
        //    var balances =
        //        _leaveService.GetEmployeeBalances(_employeeId);

        //    dgvLeaveBalances.DataSource = balances
        //        .Select(b => new
        //        {
        //            LeaveType = b.LeaveType?.Name ?? "",
        //            Allocated = b.AllocatedDays,
        //            Used = b.UsedDays,
        //            Remaining = b.RemainingDays
        //        })
        //        .ToList();

        //    ConfigureBalanceGrid();
        //}

        //private void ConfigureBalanceGrid()
        //{
        //    if (dgvLeaveBalances.Columns.Count == 0)
        //        return;

        //    dgvLeaveBalances.Columns[0].HeaderText = "Leave Type";
        //    dgvLeaveBalances.Columns[1].HeaderText = "Allocated";
        //    dgvLeaveBalances.Columns[2].HeaderText = "Used";
        //    dgvLeaveBalances.Columns[3].HeaderText = "Remaining";

        //    dgvLeaveBalances.AutoSizeColumnsMode =
        //        DataGridViewAutoSizeColumnsMode.Fill;

        //    dgvLeaveBalances.ReadOnly = true;

        //    dgvLeaveBalances.AllowUserToAddRows = false;
        //}


        //private void LoadLeaveRequests()
        //{
        //    var requests =
        //        _leaveService.GetEmployeeRequests(_employeeId);

        //    dgvLeaveRequests.DataSource = requests
        //        .Select(r => new
        //        {
        //            r.Id,
        //            LeaveType = r.LeaveType?.Name ?? "",
        //            StartDate = r.StartDate.ToShortDateString(),
        //            EndDate = r.EndDate.ToShortDateString(),
        //            r.NumberOfDays,
        //            r.Status,
        //            r.Reason,
        //            AppliedDate = r.AppliedDate.ToShortDateString()
        //        })
        //        .ToList();

        //    ConfigureRequestGrid();
        //}

        //private void ConfigureRequestGrid()
        //{
        //    if (dgvLeaveRequests.Columns.Count == 0)
        //        return;

        //    dgvLeaveRequests.AutoSizeColumnsMode =
        //        DataGridViewAutoSizeColumnsMode.Fill;

        //    dgvLeaveRequests.ReadOnly = true;

        //    dgvLeaveRequests.AllowUserToAddRows = false;

        //    dgvLeaveRequests.SelectionMode =
        //        DataGridViewSelectionMode.FullRowSelect;
        //}

        //private void DatePicker_ValueChanged(object? sender, EventArgs e)
        //{
        //    UpdateNumberOfDays();
        //}

        //private void UpdateNumberOfDays()
        //{
        //    if (dtpEndDate.Value.Date < dtpStartDate.Value.Date)
        //    {
        //        lblNumberOfDays.Text = "0";
        //        return;
        //    }

        //    int days =
        //        (dtpEndDate.Value.Date -
        //         dtpStartDate.Value.Date).Days + 1;

        //    lblNumberOfDays.Text = days.ToString();
        //}

        //private void CmbLeaveType_SelectedIndexChanged(object? sender, EventArgs e)
        //{
        //    ShowSelectedLeaveBalance();
        //}

        //private void ShowSelectedLeaveBalance()
        //{
        //    if (cmbLeaveType.SelectedValue == null)
        //        return;

        //    if (!int.TryParse(
        //        cmbLeaveType.SelectedValue.ToString(),
        //        out int leaveTypeId))
        //    {
        //        return;
        //    }

        //    var balance =
        //        _leaveService
        //            .GetEmployeeBalances(_employeeId)
        //            .FirstOrDefault(
        //                b => b.LeaveTypeId == leaveTypeId);

        //    if (balance == null)
        //    {
        //        lblAvailableDays.Text =
        //            "Available: 0 days";

        //        return;
        //    }

        //    lblAvailableDays.Text =
        //        $"Available: {balance.RemainingDays} days";
        //}

        //private void btnApplyLeave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbLeaveType.SelectedValue == null)
        //        {
        //            MessageBox.Show(
        //                "Please select a leave type.",
        //                "Validation",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Warning);

        //            return;
        //        }

        //        int leaveTypeId =
        //            Convert.ToInt32(cmbLeaveType.SelectedValue);

        //        DateTime startDate =
        //            dtpStartDate.Value.Date;

        //        DateTime endDate =
        //            dtpEndDate.Value.Date;

        //        string reason =
        //            txtReason.Text.Trim();


        //        if (startDate > endDate)
        //        {
        //            MessageBox.Show(
        //                "Start date cannot be after end date.",
        //                "Validation",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Warning);

        //            return;
        //        }


        //        if (string.IsNullOrWhiteSpace(reason))
        //        {
        //            MessageBox.Show(
        //                "Please enter a reason for the leave.",
        //                "Validation",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Warning);

        //            txtReason.Focus();

        //            return;
        //        }


        //        int numberOfDays =
        //            (endDate - startDate).Days + 1;


        //        DialogResult result = MessageBox.Show(
        //            $"Apply for {numberOfDays} day(s) of leave?",
        //            "Confirm Leave Request",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Question);

        //        if (result != DialogResult.Yes)
        //            return;


        //        _leaveService.ApplyLeave(
        //            _employeeId,
        //            leaveTypeId,
        //            startDate,
        //            endDate,
        //            reason);


        //        MessageBox.Show(
        //            "Leave request submitted successfully.",
        //            "Success",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Information);


        //        txtReason.Clear();

        //        LoadLeaveBalances();
        //        LoadLeaveRequests();

        //        UpdateNumberOfDays();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(
        //            ex.Message,
        //            "Leave Request",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Warning);
        //    }
        //}
    }
}
