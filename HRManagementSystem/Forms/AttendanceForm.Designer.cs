namespace HRManagementSystem.Forms
{
    partial class AttendanceForm
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
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            lblTotalHours = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbEmployee = new ComboBox();
            btnCheckIn = new Button();
            btnCheckOut = new Button();
            btnSearch = new Button();
            btnShowAll = new Button();
            txtSearch = new TextBox();
            dtpSearchDate = new DateTimePicker();
            dgvAttendance = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 32);
            label1.TabIndex = 0;
            label1.Text = "Attendance Management ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(34, 61);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "Employee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(34, 171);
            label3.Name = "label3";
            label3.Size = new Size(158, 23);
            label3.TabIndex = 2;
            label3.Text = "Today's Attendance";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Location = new Point(56, 199);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(103, 20);
            lblCheckIn.TabIndex = 3;
            lblCheckIn.Text = "Check In :    - -";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Location = new Point(56, 225);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(115, 20);
            lblCheckOut.TabIndex = 4;
            lblCheckOut.Text = "Check Out :    - -";
            // 
            // lblTotalHours
            // 
            lblTotalHours.AutoSize = true;
            lblTotalHours.Location = new Point(56, 254);
            lblTotalHours.Name = "lblTotalHours";
            lblTotalHours.Size = new Size(87, 20);
            lblTotalHours.TabIndex = 5;
            lblTotalHours.Text = "Hours :    - -";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(34, 359);
            label7.Name = "label7";
            label7.Size = new Size(140, 23);
            label7.TabIndex = 6;
            label7.Text = "Search Employee";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(308, 359);
            label8.Name = "label8";
            label8.Size = new Size(46, 23);
            label8.TabIndex = 7;
            label8.Text = "Date";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(34, 87);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(220, 28);
            cmbEmployee.TabIndex = 8;
            cmbEmployee.SelectedIndexChanged += cmbEmployee_SelectedIndexChanged;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = SystemColors.Highlight;
            btnCheckIn.Location = new Point(34, 126);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(94, 29);
            btnCheckIn.TabIndex = 9;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = SystemColors.Highlight;
            btnCheckOut.Location = new Point(160, 126);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(94, 29);
            btnCheckOut.TabIndex = 10;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Location = new Point(56, 431);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = SystemColors.Highlight;
            btnShowAll.Location = new Point(224, 431);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(100, 29);
            btnShowAll.TabIndex = 12;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(34, 387);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 27);
            txtSearch.TabIndex = 16;
            // 
            // dtpSearchDate
            // 
            dtpSearchDate.CalendarMonthBackground = SystemColors.ControlLightLight;
            dtpSearchDate.Location = new Point(308, 385);
            dtpSearchDate.Name = "dtpSearchDate";
            dtpSearchDate.Size = new Size(250, 27);
            dtpSearchDate.TabIndex = 17;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(36, 483);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(850, 150);
            dgvAttendance.TabIndex = 18;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(922, 653);
            Controls.Add(dgvAttendance);
            Controls.Add(dtpSearchDate);
            Controls.Add(txtSearch);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(cmbEmployee);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblTotalHours);
            Controls.Add(lblCheckOut);
            Controls.Add(lblCheckIn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AttendanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AttendanceForm";
            Load += AttendanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblCheckOut;
        private Label lblTotalHours;
        private Label label7;
        private Label label8;
        private ComboBox cmbEmployee;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private Button btnSearch;
        private Button btnShowAll;
        private Label lblCheckIn;
        private TextBox txtSearch;
        private DateTimePicker dtpSearchDate;
        private DataGridView dgvAttendance;
    }
}