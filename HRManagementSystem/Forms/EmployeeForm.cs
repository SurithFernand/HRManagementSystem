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

namespace HRManagementSystem.Forms
{
    public partial class EmployeeForm : Form
    {
        private readonly EmployeeService _employeeService = new();

        private readonly UserService _userService = new();

        private int _selectedEmployeeId = 0;

        private List<Department> _departments = new();

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ConfigureComboBoxes();
            LoadDepartments();
            LoadEmployees();

            ConfigureLoginFields();
        }


        private void ConfigureComboBoxes()
        {
            cmbGender.Items.Clear();

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");

            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
            cmbStatus.Items.Add("On Leave");

            cmbGender.SelectedIndex = -1;
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadDepartments()
        {
            try
            {
                using var db = new HRManagementSystem.Data.HRDbContext();

                _departments = db.Departments
                    .OrderBy(d => d.DepartmentName)
                    .ToList();

                cmbDepartment.DataSource = null;
                cmbDepartment.DataSource = _departments;
                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "Id";

                var filterDepartments =
                    new List<Department>
                    {
                new Department
                {
                    Id = 0,
                    DepartmentName = "All Departments"
                }
                    };

                filterDepartments.AddRange(_departments);

                cmbFilterDepartment.DataSource = null;
                cmbFilterDepartment.DataSource =
                    filterDepartments;

                cmbFilterDepartment.DisplayMember =
                    "DepartmentName";

                cmbFilterDepartment.ValueMember = "Id";

                cmbDepartment.SelectedIndex = -1;
                cmbFilterDepartment.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load departments.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void LoadEmployees()
        {
            try
            {
                var employees =
                    _employeeService.GetAll();

                DisplayEmployees(employees);
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

        private void DisplayEmployees(List<Employee> employees)
        {
            dgvEmployees.DataSource = null;

            dgvEmployees.DataSource = employees;

            if (dgvEmployees.Columns["Department"] != null)
            {
                dgvEmployees.Columns["Department"]
                    .Visible = false;
            }

            if (dgvEmployees.Columns["Users"] != null)
            {
                dgvEmployees.Columns["Users"]
                    .Visible = false;
            }
        }





        private bool ValidateEmployee()
        {
            if (string.IsNullOrWhiteSpace(
                txtEmployeeCode.Text))
            {
                MessageBox.Show(
                    "Employee code is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmployeeCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtFirstName.Text))
            {
                MessageBox.Show(
                    "First name is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtLastName.Text))
            {
                MessageBox.Show(
                    "Last name is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLastName.Focus();
                return false;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a gender.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtEmail.Text))
            {
                MessageBox.Show(
                    "Email is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return false;
            }

            if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a department.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtPosition.Text))
            {
                MessageBox.Show(
                    "Position is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPosition.Focus();
                return false;
            }

            if (!decimal.TryParse(
                txtSalary.Text,
                out decimal salary))
            {
                MessageBox.Show(
                    "Please enter a valid salary.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSalary.Focus();
                return false;
            }

            if (salary < 0)
            {
                MessageBox.Show(
                    "Salary cannot be negative.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSalary.Focus();
                return false;
            }

            if (dtpDateJoined.Value.Date <
                dtpDateOfBirth.Value.Date)
            {
                MessageBox.Show(
                    "Date joined cannot be before date of birth.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            // Login option
            if (chkCreateLogin.Checked)
            {
                if (string.IsNullOrWhiteSpace(
                    txtUsername.Text))
                {
                    MessageBox.Show(
                        "Username is required when creating a login account.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtUsername.Focus();

                    return false;
                }

                if (string.IsNullOrWhiteSpace(
                    txtPassword.Text))
                {
                    MessageBox.Show(
                        "Password is required when creating a login account.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPassword.Focus();

                    return false;
                }

                if (txtPassword.Text.Length < 6)
                {
                    MessageBox.Show(
                        "Password must contain at least 6 characters.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPassword.Focus();

                    return false;
                }
            }

            return true;
        }

        private Employee GetEmployeeFromForm()
        {
            return new Employee
            {
                Id = _selectedEmployeeId,

                EmployeeCode =
                    txtEmployeeCode.Text.Trim(),

                FirstName =
                    txtFirstName.Text.Trim(),

                LastName =
                    txtLastName.Text.Trim(),

                DateOfBirth =
                    dtpDateOfBirth.Value.Date,

                Gender =
                    cmbGender.Text,

                Email =
                    txtEmail.Text.Trim(),

                Phone =
                    txtPhone.Text.Trim(),

                Address =
                    txtAddress.Text.Trim(),

                DepartmentId =
                    Convert.ToInt32(
                        cmbDepartment.SelectedValue),

                Position =
                    txtPosition.Text.Trim(),

                Salary =
                    decimal.Parse(
                        txtSalary.Text),

                DateJoined =
                    dtpDateJoined.Value.Date,

                Status =
                    cmbStatus.Text
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (!ValidateEmployee())
            //    return;

            //try
            //{
            //    var employee = GetEmployeeFromForm();

            //    employee.Id = 0;

            //    _employeeService.Add(employee);

            //    MessageBox.Show(
            //        "Employee added successfully.",
            //        "Success",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);

            //    ClearFields();
            //    LoadEmployees();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(
            //        ex.Message,
            //        "Unable to Add Employee",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}
            if (!ValidateEmployee())
                return;

            try
            {
                var employee = GetEmployeeFromForm();

                employee.Id = 0;


                // =====================================
                // 1. CREATE EMPLOYEE
                // =====================================

                var createdEmployee =
                    _employeeService.Add(employee);


                // =====================================
                // 2. CREATE LOGIN ACCOUNT IF REQUESTED
                // =====================================

                if (chkCreateLogin.Checked)
                {
                    _userService.CreateEmployeeUser(
                        createdEmployee.Id,
                        txtUsername.Text,
                        txtPassword.Text);
                }


                // =====================================
                // 3. SUCCESS
                // =====================================

                MessageBox.Show(
                    chkCreateLogin.Checked
                        ? "Employee and login account created successfully."
                        : "Employee added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                ClearFields();

                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Add Employee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dgvEmployees.Rows[e.RowIndex];

            _selectedEmployeeId =
                Convert.ToInt32(
                    row.Cells["Id"].Value);

            txtEmployeeCode.Text =
                row.Cells["EmployeeCode"].Value?.ToString() ?? "";

            txtFirstName.Text =
                row.Cells["FirstName"].Value?.ToString() ?? "";

            txtLastName.Text =
                row.Cells["LastName"].Value?.ToString() ?? "";

            dtpDateOfBirth.Value =
                Convert.ToDateTime(
                    row.Cells["DateOfBirth"].Value);

            cmbGender.Text =
                row.Cells["Gender"].Value?.ToString() ?? "";

            txtEmail.Text =
                row.Cells["Email"].Value?.ToString() ?? "";

            txtPhone.Text =
                row.Cells["Phone"].Value?.ToString() ?? "";

            txtAddress.Text =
                row.Cells["Address"].Value?.ToString() ?? "";

            cmbDepartment.SelectedValue =
                Convert.ToInt32(
                    row.Cells["DepartmentId"].Value);

            txtPosition.Text =
                row.Cells["Position"].Value?.ToString() ?? "";

            txtSalary.Text =
                row.Cells["Salary"].Value?.ToString() ?? "";

            dtpDateJoined.Value =
                Convert.ToDateTime(
                    row.Cells["DateJoined"].Value);

            cmbStatus.Text =
                row.Cells["Status"].Value?.ToString() ?? "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedEmployeeId == 0)
            {
                MessageBox.Show(
                    "Please select an employee first.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateEmployee())
                return;

            try
            {
                var employee = GetEmployeeFromForm();

                _employeeService.Update(employee);

                MessageBox.Show(
                    "Employee updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Update Employee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedEmployeeId == 0)
            {
                MessageBox.Show(
                    "Please select an employee first.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to delete this employee?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _employeeService.Delete(
                    _selectedEmployeeId);

                MessageBox.Show(
                    "Employee deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Delete Employee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            _selectedEmployeeId = 0;

            txtEmployeeCode.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtPosition.Clear();
            txtSalary.Clear();

            cmbGender.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            cmbStatus.SelectedIndex = 0;

            dtpDateOfBirth.Value =
                DateTime.Today.AddYears(-18);

            dtpDateJoined.Value =
                DateTime.Today;

            dgvEmployees.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText =
                    txtSearch.Text.Trim();

                string position =
                    txtFilterPosition.Text.Trim();

                int? departmentId = null;

                if (cmbFilterDepartment.SelectedValue != null)
                {
                    int selectedId =
                        Convert.ToInt32(
                            cmbFilterDepartment.SelectedValue);

                    if (selectedId != 0)
                    {
                        departmentId = selectedId;
                    }
                }

                var employees =
                    _employeeService.Search(
                        searchText,
                        departmentId,
                        position);

                DisplayEmployees(employees);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to search employees.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtFilterPosition.Clear();

            cmbFilterDepartment.SelectedIndex = 0;

            LoadEmployees();
        }



        // Login option
        private void ConfigureLoginFields()
        {
            txtUsername.Enabled = chkCreateLogin.Checked;
            txtPassword.Enabled = chkCreateLogin.Checked;

            lblUsername.Enabled = chkCreateLogin.Checked;
            lblPassword.Enabled = chkCreateLogin.Checked;
        }

        private void chkCreateLogin_CheckedChanged(object sender, EventArgs e)
        {
            ConfigureLoginFields();

            if (!chkCreateLogin.Checked)
            {
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

    }

}
