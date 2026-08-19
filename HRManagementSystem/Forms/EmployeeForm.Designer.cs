namespace HRManagementSystem.Forms
{
    partial class EmployeeForm
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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtEmployeeCode = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            cmbGender = new ComboBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            cmbDepartment = new ComboBox();
            txtPosition = new TextBox();
            txtSalary = new TextBox();
            txtSearch = new TextBox();
            dtpDateJoined = new DateTimePicker();
            cmbStatus = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            cmbFilterDepartment = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            txtFilterPosition = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            dgvEmployees = new DataGridView();
            chkCreateLogin = new CheckBox();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee Management  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 68);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Employee Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 101);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "First Name ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 134);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 166);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 4;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 202);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 5;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 236);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 271);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 7;
            label8.Text = "Phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 304);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 8;
            label9.Text = "Address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 377);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 9;
            label10.Text = "Department";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(46, 411);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 10;
            label11.Text = "Position";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 444);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 11;
            label12.Text = "Salary";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(46, 479);
            label13.Name = "label13";
            label13.Size = new Size(88, 20);
            label13.TabIndex = 12;
            label13.Text = "Date Joined";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(45, 610);
            label14.Name = "label14";
            label14.Size = new Size(60, 20);
            label14.TabIndex = 13;
            label14.Text = "Search :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(46, 512);
            label15.Name = "label15";
            label15.Size = new Size(49, 20);
            label15.TabIndex = 14;
            label15.Text = "Status";
            // 
            // txtEmployeeCode
            // 
            txtEmployeeCode.Location = new Point(212, 65);
            txtEmployeeCode.Name = "txtEmployeeCode";
            txtEmployeeCode.Size = new Size(226, 27);
            txtEmployeeCode.TabIndex = 15;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(212, 98);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(226, 27);
            txtFirstName.TabIndex = 16;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(212, 131);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(226, 27);
            txtLastName.TabIndex = 17;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(212, 166);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(250, 27);
            dtpDateOfBirth.TabIndex = 18;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(212, 199);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(151, 28);
            cmbGender.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(212, 233);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 20;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(212, 268);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 21;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(212, 301);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(198, 67);
            txtAddress.TabIndex = 22;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(212, 374);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(151, 28);
            cmbDepartment.TabIndex = 23;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(212, 408);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(125, 27);
            txtPosition.TabIndex = 24;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(212, 441);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(125, 27);
            txtSalary.TabIndex = 25;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(151, 610);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 26;
            // 
            // dtpDateJoined
            // 
            dtpDateJoined.Location = new Point(212, 474);
            dtpDateJoined.Name = "dtpDateJoined";
            dtpDateJoined.Size = new Size(250, 27);
            dtpDateJoined.TabIndex = 27;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(212, 509);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 28;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(117, 554);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 30);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(227, 554);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 30);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(327, 556);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 30);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(471, 556);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 30);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cmbFilterDepartment
            // 
            cmbFilterDepartment.FormattingEnabled = true;
            cmbFilterDepartment.Location = new Point(454, 607);
            cmbFilterDepartment.Name = "cmbFilterDepartment";
            cmbFilterDepartment.Size = new Size(151, 28);
            cmbFilterDepartment.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(45, 651);
            label16.Name = "label16";
            label16.Size = new Size(68, 20);
            label16.TabIndex = 35;
            label16.Text = "Position :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(352, 610);
            label17.Name = "label17";
            label17.Size = new Size(96, 20);
            label17.TabIndex = 36;
            label17.Text = "Department :";
            // 
            // txtFilterPosition
            // 
            txtFilterPosition.Location = new Point(151, 651);
            txtFilterPosition.Name = "txtFilterPosition";
            txtFilterPosition.Size = new Size(125, 27);
            txtFilterPosition.TabIndex = 37;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(327, 651);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 40;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(453, 651);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(94, 29);
            btnShowAll.TabIndex = 41;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(46, 704);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(700, 105);
            dgvEmployees.TabIndex = 42;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            // 
            // chkCreateLogin
            // 
            chkCreateLogin.AutoSize = true;
            chkCreateLogin.Location = new Point(676, 444);
            chkCreateLogin.Name = "chkCreateLogin";
            chkCreateLogin.Size = new Size(173, 24);
            chkCreateLogin.TabIndex = 43;
            chkCreateLogin.Text = "Create Login Account";
            chkCreateLogin.UseVisualStyleBackColor = true;
            chkCreateLogin.CheckedChanged += chkCreateLogin_CheckedChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(676, 497);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 44;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(676, 534);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 45;
            lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(767, 497);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 46;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(767, 531);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 47;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 836);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(chkCreateLogin);
            Controls.Add(dgvEmployees);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(txtFilterPosition);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(cmbFilterDepartment);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbStatus);
            Controls.Add(dtpDateJoined);
            Controls.Add(txtSearch);
            Controls.Add(txtSalary);
            Controls.Add(txtPosition);
            Controls.Add(cmbDepartment);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(cmbGender);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmployeeCode);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtEmployeeCode;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cmbGender;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private ComboBox cmbDepartment;
        private TextBox txtPosition;
        private TextBox txtSalary;
        private TextBox txtSearch;
        private DateTimePicker dtpDateJoined;
        private ComboBox cmbStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private ComboBox cmbFilterDepartment;
        private Label label16;
        private Label label17;
        private TextBox txtFilterPosition;
        private Button btnSearch;
        private Button btnShowAll;
        private DataGridView dgvEmployees;
        private CheckBox chkCreateLogin;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}