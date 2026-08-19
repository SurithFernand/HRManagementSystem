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
    public partial class DepartmentForm : Form
    {
        private readonly DepartmentService _departmentService = new();

        private int _selectedDepartmentId = 0;

        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void LoadDepartments()
        {
            try
            {
                var departments = _departmentService.GetAll();

                dgvDepartments.DataSource = departments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load departments.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtDepartmentName.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(
                    "Please enter a department name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDepartmentName.Focus();
                return;
            }

            try
            {
                _departmentService.Add(name, description);

                MessageBox.Show(
                    "Department added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
                LoadDepartments();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtDepartmentName.Clear();
            txtDescription.Clear();

            _selectedDepartmentId = 0;

            dgvDepartments.ClearSelection();
        }

        private void dgvDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dgvDepartments.Rows[e.RowIndex];

            _selectedDepartmentId =
                Convert.ToInt32(row.Cells["Id"].Value);

            txtDepartmentName.Text =
                row.Cells["DepartmentName"].Value?.ToString() ?? "";

            txtDescription.Text =
                row.Cells["Description"].Value?.ToString() ?? "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedDepartmentId == 0)
            {
                MessageBox.Show(
                    "Please select a department first.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string name = txtDepartmentName.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(
                    "Please enter a department name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                _departmentService.Update(
                    _selectedDepartmentId,
                    name,
                    description);

                MessageBox.Show(
                    "Department updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
                LoadDepartments();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedDepartmentId == 0)
            {
                MessageBox.Show(
                    "Please select a department first.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this department?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _departmentService.Delete(_selectedDepartmentId);

                MessageBox.Show(
                    "Department deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
                LoadDepartments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                var departments =
                    _departmentService.Search(searchText);

                dgvDepartments.DataSource = departments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to search departments.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
