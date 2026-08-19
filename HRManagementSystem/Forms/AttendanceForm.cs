using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRManagementSystem.Data;
using HRManagementSystem.Models;
using HRManagementSystem.Services;

namespace HRManagementSystem.Forms
{
    public partial class AttendanceForm : Form
    {
        private readonly AttendanceService _attendanceService = new();

        private List<Employee> _employees = new();

        private int _selectedEmployeeId = 0;
        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadAttendance();
        }

        private void LoadEmployees()
        {
            try
            {
                using var db = new HRDbContext();

                _employees = db.Employees
                    .OrderBy(e => e.EmployeeCode)
                    .ToList();

                cmbEmployee.DataSource = null;

                cmbEmployee.DataSource = _employees;

                cmbEmployee.DisplayMember = "EmployeeCode";

                cmbEmployee.ValueMember = "Id";

                cmbEmployee.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load employees.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadAttendance()
        {
            try
            {
                var records =
                    _attendanceService.GetAll();

                DisplayAttendance(records);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load attendance.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DisplayAttendance(List<Attendance> records)
        {
            dgvAttendance.DataSource = null;

            dgvAttendance.DataSource = records;

            if (dgvAttendance.Columns["Employee"] != null)
            {
                dgvAttendance.Columns["Employee"]
                    .Visible = false;
            }
        }


        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedValue == null)
                return;

            if (cmbEmployee.SelectedValue is int employeeId)
            {
                _selectedEmployeeId = employeeId;

                LoadTodayAttendance();
            }
        }

        private void LoadTodayAttendance()
        {
            if (_selectedEmployeeId == 0)
                return;

            try
            {
                var attendance = _attendanceService.GetTodayAttendance(_selectedEmployeeId);

                if (attendance == null)
                {
                    lblCheckIn.Text = "Check In: -";
                    lblCheckOut.Text = "Check Out: -";
                    lblTotalHours.Text = "Hours: 0";

                    return;
                }

                lblCheckIn.Text =
                    attendance.CheckIn.HasValue
                        ? $"Check In: {attendance.CheckIn.Value:hh:mm tt}"
                        : "Check In: -";

                lblCheckOut.Text =
                    attendance.CheckOut.HasValue
                        ? $"Check Out: {attendance.CheckOut.Value:hh:mm tt}"
                        : "Check Out: -";

                lblTotalHours.Text =
                    $"Hours: {attendance.TotalHours:0.00}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (_selectedEmployeeId == 0)
            {
                MessageBox.Show(
                    "Please select an employee.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                _attendanceService.CheckIn(
                    _selectedEmployeeId);

                MessageBox.Show(
                    "Employee checked in successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadTodayAttendance();
                LoadAttendance();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Check In",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (_selectedEmployeeId == 0)
            {
                MessageBox.Show(
                    "Please select an employee.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                _attendanceService.CheckOut(
                    _selectedEmployeeId);

                MessageBox.Show(
                    "Employee checked out successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadTodayAttendance();
                LoadAttendance();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Check Out",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText =
                    txtSearch.Text.Trim();

                DateTime selectedDate =
                    dtpSearchDate.Value.Date;

                var records =
                    _attendanceService.Search(
                        searchText,
                        selectedDate);

                DisplayAttendance(records);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to search attendance.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            LoadAttendance();
        }
    }
}
