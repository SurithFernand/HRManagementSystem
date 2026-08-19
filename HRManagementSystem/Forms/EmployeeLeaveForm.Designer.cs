namespace HRManagementSystem.Forms
{
    partial class EmployeeLeaveForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblNumberOfDays = new Label();
            label8 = new Label();
            btnApplyLeave = new Button();
            label9 = new Label();
            dgvLeaveRequests = new DataGridView();
            cmbLeaveType = new ComboBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            txtReason = new TextBox();
            dgvLeaveBalances = new DataGridView();
            lblAvailable = new Label();
            lblAvailableDays = new Label();
            lblDaysValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLeaveRequests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLeaveBalances).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 24);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "MY LEAVE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 75);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "Leave Application";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 75);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Leave Balance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 110);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "Leave Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 168);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Start Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 196);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "End Date:";
            // 
            // lblNumberOfDays
            // 
            lblNumberOfDays.AutoSize = true;
            lblNumberOfDays.Location = new Point(47, 239);
            lblNumberOfDays.Name = "lblNumberOfDays";
            lblNumberOfDays.Size = new Size(120, 20);
            lblNumberOfDays.TabIndex = 6;
            lblNumberOfDays.Text = "Number of Days:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 285);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 7;
            label8.Text = "Reason:";
            // 
            // btnApplyLeave
            // 
            btnApplyLeave.Location = new Point(159, 349);
            btnApplyLeave.Name = "btnApplyLeave";
            btnApplyLeave.Size = new Size(157, 29);
            btnApplyLeave.TabIndex = 8;
            btnApplyLeave.Text = "Apply Leave";
            btnApplyLeave.UseVisualStyleBackColor = true;
            btnApplyLeave.Click += btnApplyLeave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(372, 373);
            label9.Name = "label9";
            label9.Size = new Size(149, 20);
            label9.TabIndex = 9;
            label9.Text = "MY LEAVE REQUESTS";
            // 
            // dgvLeaveRequests
            // 
            dgvLeaveRequests.AllowUserToAddRows = false;
            dgvLeaveRequests.AllowUserToDeleteRows = false;
            dgvLeaveRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLeaveRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeaveRequests.Location = new Point(12, 396);
            dgvLeaveRequests.Name = "dgvLeaveRequests";
            dgvLeaveRequests.ReadOnly = true;
            dgvLeaveRequests.RowHeadersWidth = 51;
            dgvLeaveRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLeaveRequests.Size = new Size(860, 163);
            dgvLeaveRequests.TabIndex = 10;
            // 
            // cmbLeaveType
            // 
            cmbLeaveType.FormattingEnabled = true;
            cmbLeaveType.Location = new Point(134, 107);
            cmbLeaveType.Name = "cmbLeaveType";
            cmbLeaveType.Size = new Size(220, 28);
            cmbLeaveType.TabIndex = 11;
            cmbLeaveType.SelectedIndexChanged += cmbLeaveType_SelectedIndexChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(134, 168);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 12;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(126, 191);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 13;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged_1;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(134, 282);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(288, 61);
            txtReason.TabIndex = 14;
            // 
            // dgvLeaveBalances
            // 
            dgvLeaveBalances.AllowUserToAddRows = false;
            dgvLeaveBalances.AllowUserToDeleteRows = false;
            dgvLeaveBalances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLeaveBalances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeaveBalances.Location = new Point(520, 115);
            dgvLeaveBalances.Name = "dgvLeaveBalances";
            dgvLeaveBalances.ReadOnly = true;
            dgvLeaveBalances.RowHeadersWidth = 51;
            dgvLeaveBalances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLeaveBalances.Size = new Size(223, 164);
            dgvLeaveBalances.TabIndex = 15;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(47, 138);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(74, 20);
            lblAvailable.TabIndex = 16;
            lblAvailable.Text = "Available:";
            // 
            // lblAvailableDays
            // 
            lblAvailableDays.AutoSize = true;
            lblAvailableDays.Location = new Point(127, 138);
            lblAvailableDays.Name = "lblAvailableDays";
            lblAvailableDays.Size = new Size(51, 20);
            lblAvailableDays.TabIndex = 17;
            lblAvailableDays.Text = "0 days";
            // 
            // lblDaysValue
            // 
            lblDaysValue.AutoSize = true;
            lblDaysValue.Location = new Point(173, 239);
            lblDaysValue.Name = "lblDaysValue";
            lblDaysValue.Size = new Size(17, 20);
            lblDaysValue.TabIndex = 18;
            lblDaysValue.Text = "0";
            // 
            // EmployeeLeaveForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 641);
            Controls.Add(lblDaysValue);
            Controls.Add(lblAvailableDays);
            Controls.Add(lblAvailable);
            Controls.Add(dgvLeaveBalances);
            Controls.Add(txtReason);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cmbLeaveType);
            Controls.Add(dgvLeaveRequests);
            Controls.Add(label9);
            Controls.Add(btnApplyLeave);
            Controls.Add(label8);
            Controls.Add(lblNumberOfDays);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeLeaveForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeLeaveForm";
            Load += EmployeeLeaveForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLeaveRequests).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLeaveBalances).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblNumberOfDays;
        private Label label8;
        private Button btnApplyLeave;
        private Label label9;
        private DataGridView dgvLeaveRequests;
        private ComboBox cmbLeaveType;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private TextBox txtReason;
        private DataGridView dgvLeaveBalances;
        private Label lblAvailable;
        private Label lblAvailableDays;
        private Label lblDaysValue;
    }
}