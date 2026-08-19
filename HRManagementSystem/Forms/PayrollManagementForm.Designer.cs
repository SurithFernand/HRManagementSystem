namespace HRManagementSystem.Forms
{
    partial class PayrollManagementForm
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
            lblEmployee = new Label();
            lblYear = new Label();
            lblMonth = new Label();
            lblOvertime = new Label();
            lblOtherDeductions = new Label();
            cmbEmployee = new ComboBox();
            nudYear = new NumericUpDown();
            cmbMonth = new ComboBox();
            txtOvertime = new TextBox();
            btnGenerate = new Button();
            dgvPayrolls = new DataGridView();
            btnDelete = new Button();
            txtDeductions = new TextBox();
            lblAllowances = new Label();
            txtAllowances = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayrolls).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(345, 22);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 0;
            label1.Text = "Payroll Management";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(53, 140);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(78, 20);
            lblEmployee.TabIndex = 1;
            lblEmployee.Text = "Employee:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(53, 181);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(40, 20);
            lblYear.TabIndex = 2;
            lblYear.Text = "Year:";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Location = new Point(53, 215);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(55, 20);
            lblMonth.TabIndex = 3;
            lblMonth.Text = "Month:";
            // 
            // lblOvertime
            // 
            lblOvertime.AutoSize = true;
            lblOvertime.Location = new Point(53, 252);
            lblOvertime.Name = "lblOvertime";
            lblOvertime.Size = new Size(99, 20);
            lblOvertime.TabIndex = 4;
            lblOvertime.Text = "Overtime Pay:";
            // 
            // lblOtherDeductions
            // 
            lblOtherDeductions.AutoSize = true;
            lblOtherDeductions.Location = new Point(53, 309);
            lblOtherDeductions.Name = "lblOtherDeductions";
            lblOtherDeductions.Size = new Size(128, 20);
            lblOtherDeductions.TabIndex = 5;
            lblOtherDeductions.Text = "Other Deductions:";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(233, 132);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(151, 28);
            cmbEmployee.TabIndex = 6;
            // 
            // nudYear
            // 
            nudYear.Location = new Point(166, 174);
            nudYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(150, 27);
            nudYear.TabIndex = 7;
            nudYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(153, 212);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(151, 28);
            cmbMonth.TabIndex = 8;
            // 
            // txtOvertime
            // 
            txtOvertime.Location = new Point(166, 249);
            txtOvertime.Name = "txtOvertime";
            txtOvertime.Size = new Size(125, 27);
            txtOvertime.TabIndex = 9;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(167, 332);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(149, 29);
            btnGenerate.TabIndex = 10;
            btnGenerate.Text = "Generate Payroll";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // dgvPayrolls
            // 
            dgvPayrolls.AllowUserToAddRows = false;
            dgvPayrolls.AllowUserToDeleteRows = false;
            dgvPayrolls.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPayrolls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayrolls.Location = new Point(53, 357);
            dgvPayrolls.MultiSelect = false;
            dgvPayrolls.Name = "dgvPayrolls";
            dgvPayrolls.ReadOnly = true;
            dgvPayrolls.RowHeadersWidth = 51;
            dgvPayrolls.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayrolls.Size = new Size(697, 188);
            dgvPayrolls.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(400, 332);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete Payroll";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtDeductions
            // 
            txtDeductions.Location = new Point(205, 306);
            txtDeductions.Name = "txtDeductions";
            txtDeductions.Size = new Size(125, 27);
            txtDeductions.TabIndex = 13;
            // 
            // lblAllowances
            // 
            lblAllowances.AutoSize = true;
            lblAllowances.Location = new Point(53, 282);
            lblAllowances.Name = "lblAllowances";
            lblAllowances.Size = new Size(87, 20);
            lblAllowances.TabIndex = 14;
            lblAllowances.Text = "Allowances:";
            // 
            // txtAllowances
            // 
            txtAllowances.Location = new Point(167, 282);
            txtAllowances.Name = "txtAllowances";
            txtAllowances.Size = new Size(125, 27);
            txtAllowances.TabIndex = 15;
            // 
            // PayrollManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(txtAllowances);
            Controls.Add(lblAllowances);
            Controls.Add(txtDeductions);
            Controls.Add(btnDelete);
            Controls.Add(dgvPayrolls);
            Controls.Add(btnGenerate);
            Controls.Add(txtOvertime);
            Controls.Add(cmbMonth);
            Controls.Add(nudYear);
            Controls.Add(cmbEmployee);
            Controls.Add(lblOtherDeductions);
            Controls.Add(lblOvertime);
            Controls.Add(lblMonth);
            Controls.Add(lblYear);
            Controls.Add(lblEmployee);
            Controls.Add(label1);
            Name = "PayrollManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayrollManagementForm";
            Load += PayrollManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayrolls).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblEmployee;
        private Label lblYear;
        private Label lblMonth;
        private Label lblOvertime;
        private Label lblOtherDeductions;
        private ComboBox cmbEmployee;
        private NumericUpDown nudYear;
        private ComboBox cmbMonth;
        private TextBox txtOvertime;
        private Button btnGenerate;
        private DataGridView dgvPayrolls;
        private Button btnDelete;
        private TextBox txtDeductions;
        private Label lblAllowances;
        private TextBox txtAllowances;
    }
}