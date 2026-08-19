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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 32);
            label1.TabIndex = 0;
            label1.Text = "HR MANAGEMENT SYSTEM";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11F);
            lblWelcome.Location = new Point(80, 204);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(90, 25);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DeepSkyBlue;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.Location = new Point(804, 398);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRole.Location = new Point(80, 243);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(51, 25);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role";
            // 
            // btnDepartments
            // 
            btnDepartments.BackColor = SystemColors.Highlight;
            btnDepartments.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDepartments.Location = new Point(80, 294);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(160, 29);
            btnDepartments.TabIndex = 4;
            btnDepartments.Text = "Departments";
            btnDepartments.UseVisualStyleBackColor = false;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = SystemColors.Highlight;
            btnEmployees.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmployees.Location = new Point(366, 294);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(160, 29);
            btnEmployees.TabIndex = 5;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = SystemColors.Highlight;
            btnAttendance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAttendance.Location = new Point(80, 343);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(160, 29);
            btnAttendance.TabIndex = 6;
            btnAttendance.Text = "Attendance";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnMyLeave
            // 
            btnMyLeave.BackColor = SystemColors.Highlight;
            btnMyLeave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMyLeave.Location = new Point(366, 343);
            btnMyLeave.Name = "btnMyLeave";
            btnMyLeave.Size = new Size(160, 29);
            btnMyLeave.TabIndex = 7;
            btnMyLeave.Text = "My Leave";
            btnMyLeave.UseVisualStyleBackColor = false;
            btnMyLeave.Click += btnMyLeave_Click;
            // 
            // btnLeaveManagement
            // 
            btnLeaveManagement.BackColor = SystemColors.Highlight;
            btnLeaveManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLeaveManagement.Location = new Point(659, 294);
            btnLeaveManagement.Name = "btnLeaveManagement";
            btnLeaveManagement.Size = new Size(160, 29);
            btnLeaveManagement.TabIndex = 8;
            btnLeaveManagement.Text = "Leave Management";
            btnLeaveManagement.UseVisualStyleBackColor = false;
            btnLeaveManagement.Click += btnLeaveManagement_Click;
            // 
            // btnPayroll
            // 
            btnPayroll.BackColor = SystemColors.Highlight;
            btnPayroll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPayroll.Location = new Point(659, 343);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(160, 29);
            btnPayroll.TabIndex = 9;
            btnPayroll.Text = "Payroll";
            btnPayroll.UseVisualStyleBackColor = false;
            btnPayroll.Click += btnPayroll_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-2, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(935, 153);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(932, 453);
            Controls.Add(pictureBox1);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}