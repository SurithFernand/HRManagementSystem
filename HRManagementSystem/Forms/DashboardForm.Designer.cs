namespace HRManagementSystem.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblWelcome = new Label();
            btnLogout = new Button();
            lblRole = new Label();
            btnDepartments = new Button();
            btnEmployees = new Button();
            btnAttendance = new Button();
            btnMyLeave = new Button();
            btnLeaveManagement = new Button();
            btnPayroll = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(286, 40);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 0;
            label1.Text = "HR MANAGEMENT SYSTEM";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(43, 96);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(71, 20);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(639, 409);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(43, 137);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(39, 20);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role";
            // 
            // btnDepartments
            // 
            btnDepartments.Location = new Point(32, 268);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(110, 29);
            btnDepartments.TabIndex = 4;
            btnDepartments.Text = "Departments";
            btnDepartments.UseVisualStyleBackColor = true;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(61, 303);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(94, 29);
            btnEmployees.TabIndex = 5;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Location = new Point(111, 338);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(94, 29);
            btnAttendance.TabIndex = 6;
            btnAttendance.Text = "Attendance";
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnMyLeave
            // 
            btnMyLeave.Location = new Point(168, 373);
            btnMyLeave.Name = "btnMyLeave";
            btnMyLeave.Size = new Size(94, 29);
            btnMyLeave.TabIndex = 7;
            btnMyLeave.Text = "My Leave";
            btnMyLeave.UseVisualStyleBackColor = true;
            btnMyLeave.Click += btnMyLeave_Click;
            // 
            // btnLeaveManagement
            // 
            btnLeaveManagement.Location = new Point(286, 373);
            btnLeaveManagement.Name = "btnLeaveManagement";
            btnLeaveManagement.Size = new Size(189, 29);
            btnLeaveManagement.TabIndex = 8;
            btnLeaveManagement.Text = "Leave Management";
            btnLeaveManagement.UseVisualStyleBackColor = true;
            btnLeaveManagement.Click += btnLeaveManagement_Click;
            // 
            // btnPayroll
            // 
            btnPayroll.Location = new Point(520, 373);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(164, 29);
            btnPayroll.TabIndex = 9;
            btnPayroll.Text = "Payroll Management";
            btnPayroll.UseVisualStyleBackColor = true;
            btnPayroll.Click += btnPayroll_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPayroll);
            Controls.Add(btnLeaveManagement);
            Controls.Add(btnMyLeave);
            Controls.Add(btnAttendance);
            Controls.Add(btnEmployees);
            Controls.Add(btnDepartments);
            Controls.Add(lblRole);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcome);
            Controls.Add(label1);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblWelcome;
        private Button btnLogout;
        private Label lblRole;
        private Button btnDepartments;
        private Button btnEmployees;
        private Button btnAttendance;
        private Button btnMyLeave;
        private Button btnLeaveManagement;
        private Button btnPayroll;
    }
}