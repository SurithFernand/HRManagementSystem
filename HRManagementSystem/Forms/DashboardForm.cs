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

namespace HRManagementSystem.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                Close();
                return;
            }

            lblWelcome.Text =
                $"Welcome, {Session.CurrentUser.Username}";

            lblRole.Text =
                $"Role: {Session.CurrentUser.Role}";

            ConfigureRoleAccess();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Session.Logout();

            //Close();

            var result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Confirm Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            // Clear logged-in user
            Session.Logout();

            // Show the existing LoginForm
            Application.OpenForms
                .OfType<LoginForm>()
                .FirstOrDefault()?
                .Show();

            // Close Dashboard
            Close();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            using var form = new DepartmentForm();

            form.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            using var form = new EmployeeForm();

            form.ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            using var form = new AttendanceForm();

            form.ShowDialog();
        }


        //private void ConfigureRoleAccess()
        //{
        //    if (Session.CurrentUser == null)
        //    {
        //        return;
        //    }

        //    string role = Session.CurrentUser.Role;


        //    // Leave

        //    // Hide both leave buttons first
        //    btnMyLeave.Visible = false;
        //    btnLeaveManagement.Visible = false;


        //    // Employee
        //    if (role == UserRole.Employee.ToString())
        //    {
        //        btnMyLeave.Visible = true;
        //    }


        //    // HR Manager
        //    else if (role == UserRole.HRManager.ToString())
        //    {
        //        btnLeaveManagement.Visible = true;
        //    }


        //    // Admin
        //    else if (role == UserRole.Admin.ToString())
        //    {
        //        btnLeaveManagement.Visible = true;
        //    }



        //    // Payroll

        //    // Hide by default
        //    btnPayroll.Visible = false;


        //    // Admin
        //    if (role == UserRole.Admin.ToString())
        //    {
        //        btnPayroll.Visible = true;
        //    }


        //    // HR Manager
        //    else if (role == UserRole.HRManager.ToString())
        //    {
        //        btnPayroll.Visible = true;
        //    }


        //    // Employee
        //    else if (role == UserRole.Employee.ToString())
        //    {
        //        btnPayroll.Visible = false;
        //    }


        //}
        private void ConfigureRoleAccess()
        {
            if (Session.CurrentUser == null)
            {
                return;
            }

            string role = Session.CurrentUser.Role;


            // ==========================================
            // HIDE EVERYTHING BY DEFAULT
            // ==========================================

            btnEmployees.Visible = false;
            btnDepartments.Visible = false;
            btnAttendance.Visible = false;

            btnMyLeave.Visible = false;
            btnLeaveManagement.Visible = false;

            btnPayroll.Visible = false;


            // ==========================================
            // ADMIN
            // ==========================================

            if (role == UserRole.Admin.ToString())
            {
                btnEmployees.Visible = true;
                btnDepartments.Visible = true;
                btnAttendance.Visible = true;
                btnLeaveManagement.Visible = true;
                btnPayroll.Visible = true;
            }


            // ==========================================
            // HR MANAGER
            // ==========================================

            else if (role == UserRole.HRManager.ToString())
            {
                btnEmployees.Visible = true;
                btnDepartments.Visible = true;
                btnAttendance.Visible = true;
                btnLeaveManagement.Visible = true;
                btnPayroll.Visible = true;
            }


            // ==========================================
            // EMPLOYEE
            // ==========================================

            else if (role == UserRole.Employee.ToString())
            {
                // Employees cannot manage employees
                btnEmployees.Visible = false;

                // Employees cannot manage departments
                btnDepartments.Visible = false;

                // Employees can access attendance
                btnAttendance.Visible = true;

                // Employees can apply for their own leave
                btnMyLeave.Visible = true;

                // Employees cannot manage other employees' leave
                btnLeaveManagement.Visible = false;

                // Employees cannot manage payroll
                btnPayroll.Visible = false;
            }
        }

        private void btnMyLeave_Click(object sender, EventArgs e)
        {
            EmployeeLeaveForm form = new EmployeeLeaveForm();

            form.ShowDialog();
        }

        private void btnLeaveManagement_Click(object sender, EventArgs e)
        {
            HRLeaveManagementForm form = new HRLeaveManagementForm();

            form.ShowDialog();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            PayrollManagementForm form = new PayrollManagementForm();

            form.ShowDialog();
        }
    }
}
