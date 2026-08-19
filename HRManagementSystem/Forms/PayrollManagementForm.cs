using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRManagementSystem.Models;
using HRManagementSystem.Services;
using HRManagementSystem.Data;
using HRManagementSystem.Helpers;

namespace HRManagementSystem.Forms
{
    public partial class PayrollManagementForm : Form
    {
        private readonly PayrollService _payrollService = new PayrollService();

        public PayrollManagementForm()
        {
            InitializeComponent();
        }

        private void LoadEmployees()
        {
            using var db = new HRDbContext();

            var employees = db.Employees
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Select(e => new
                {
                    Id = e.Id,

                    Name =
                        e.EmployeeCode +
                        " - " +
                        e.FirstName +
                        " " +
                        e.LastName
                })
                .ToList();

            cmbEmployee.DataSource = employees;

            cmbEmployee.DisplayMember = "Name";

            cmbEmployee.ValueMember = "Id";
        }

        private void LoadMonths()
        {
            cmbMonth.DataSource =
                Enumerable.Range(1, 12)
                .Select(m => new
                {
                    Number = m,
                    Name = new DateTime(
                        2026,
                        m,
                        1).ToString("MMMM")
                })
                .ToList();

            cmbMonth.DisplayMember = "Name";

            cmbMonth.ValueMember = "Number";
        }

        private void LoadPayrolls()
        {
            try
            {
                var payrolls =
                    _payrollService.GetAllPayrolls();

                dgvPayrolls.DataSource =
                    payrolls.Select(p => new
                    {
                        ID = p.Id,

                        Employee =
                            p.Employee == null
                                ? ""
                                : p.Employee.EmployeeCode +
                                  " - " +
                                  p.Employee.FirstName +
                                  " " +
                                  p.Employee.LastName,

                        Year = p.Year,

                        Month =
                            new DateTime(
                                p.Year,
                                p.Month,
                                1)
                            .ToString("MMMM"),

                        BasicSalary =
                            p.BasicSalary.ToString("N2"),

                        Overtime =
                            p.Overtime.ToString("N2"),

                        Allowances =
                            p.Allowances.ToString("N2"),

                        Deductions =
                            p.Deductions.ToString("N2"),

                        LeaveDeduction =
                            p.LeaveDeduction.ToString("N2"),

                        AttendanceDeduction =
                            p.AttendanceDeduction.ToString("N2"),

                        NetSalary =
                            p.NetSalary.ToString("N2"),

                        GeneratedDate =
                            p.GeneratedDate.ToString(
                                "yyyy-MM-dd HH:mm")
                    }).ToList();
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

        private void PayrollManagementForm_Load(object sender, EventArgs e)
        {
            if (!HasPayrollAccess())
            {
                MessageBox.Show(
                    "You do not have permission to access Payroll Management.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();

                return;
            }


            LoadEmployees();

            LoadMonths();

            LoadPayrolls();

            txtOvertime.Text = "0";

            txtAllowances.Text = "0";

            txtDeductions.Text = "0";

            nudYear.Value = DateTime.Now.Year;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmployee.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Please select an employee.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int employeeId =
                    Convert.ToInt32(
                        cmbEmployee.SelectedValue);

                int year =
                    Convert.ToInt32(nudYear.Value);

                int month =
                    Convert.ToInt32(
                        cmbMonth.SelectedValue);


                if (!decimal.TryParse(
                        txtOvertime.Text,
                        out decimal overtime))
                {
                    MessageBox.Show(
                        "Enter a valid overtime amount.");

                    return;
                }


                if (!decimal.TryParse(
                        txtAllowances.Text,
                        out decimal allowances))
                {
                    MessageBox.Show(
                        "Enter a valid allowances amount.");

                    return;
                }


                if (!decimal.TryParse(
                        txtDeductions.Text,
                        out decimal deductions))
                {
                    MessageBox.Show(
                        "Enter a valid deductions amount.");

                    return;
                }


                if (overtime < 0 ||
                    allowances < 0 ||
                    deductions < 0)
                {
                    MessageBox.Show(
                        "Amounts cannot be negative.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                var payroll =
                    _payrollService.GeneratePayroll(
                        employeeId,
                        year,
                        month,
                        overtime,
                        allowances,
                        deductions);


                MessageBox.Show(
                    $"Payroll generated successfully.\n\n" +
                    $"Net Salary: {payroll.NetSalary:N2}",
                    "Payroll Generated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                LoadPayrolls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Payroll Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPayrolls.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a payroll record.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                int id =
                    Convert.ToInt32(
                        dgvPayrolls
                        .SelectedRows[0]
                        .Cells["ID"]
                        .Value);


                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete this payroll record?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);


                if (result != DialogResult.Yes)
                {
                    return;
                }


                _payrollService.DeletePayroll(id);


                MessageBox.Show(
                    "Payroll deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                LoadPayrolls();
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

        private bool HasPayrollAccess()
        {
            if (Session.CurrentUser == null)
            {
                return false;
            }

            return
                Session.CurrentUser.Role ==
                    UserRole.Admin.ToString()
                ||
                Session.CurrentUser.Role ==
                    UserRole.HRManager.ToString();
        }
    }
}
