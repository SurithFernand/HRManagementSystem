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
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(340, 9);
            label1.Name = "label1";
            label1.Size = new Size(297, 32);
            label1.TabIndex = 0;
            label1.Text = "Employee Management  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(46, 68);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Employee Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 117);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "First Name ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(527, 117);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 157);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 4;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(527, 157);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 5;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 199);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(527, 199);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 7;
            label8.Text = "Phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(527, 241);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 8;
            label9.Text = "Address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 244);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 9;
            label10.Text = "Department";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(46, 288);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 10;
            label11.Text = "Position";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 331);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 11;
            label12.Text = "Salary";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(46, 376);
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
            label15.Location = new Point(45, 419);
            label15.Name = "label15";
            label15.Size = new Size(49, 20);
            label15.TabIndex = 14;
            label15.Text = "Status";
            // 
            // txtEmployeeCode
            // 
            txtEmployeeCode.Location = new Point(174, 65);
            txtEmployeeCode.Name = "txtEmployeeCode";
            txtEmployeeCode.Size = new Size(250, 27);
            txtEmployeeCode.TabIndex = 15;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(174, 110);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 27);
            txtFirstName.TabIndex = 16;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(646, 110);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 27);
            txtLastName.TabIndex = 17;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(174, 152);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(250, 27);
            dtpDateOfBirth.TabIndex = 18;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(646, 151);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(250, 28);
            cmbGender.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(174, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 20;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(646, 194);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 21;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(646, 238);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 100);
            txtAddress.TabIndex = 22;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(174, 241);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(250, 28);
            cmbDepartment.TabIndex = 23;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(174, 285);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(250, 27);
            txtPosition.TabIndex = 24;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(174, 329);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(250, 27);
            txtSalary.TabIndex = 25;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(111, 607);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 26;
            // 
            // dtpDateJoined
            // 
            dtpDateJoined.Location = new Point(174, 372);
            dtpDateJoined.Name = "dtpDateJoined";
            dtpDateJoined.Size = new Size(250, 27);
            dtpDateJoined.TabIndex = 27;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(174, 416);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(250, 28);
            cmbStatus.TabIndex = 28;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkTurquoise;
            btnAdd.Location = new Point(46, 497);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 30);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkTurquoise;
            btnUpdate.Location = new Point(182, 497);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 30);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkTurquoise;
            btnDelete.Location = new Point(313, 497);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 30);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkTurquoise;
            btnClear.Location = new Point(453, 497);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 30);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // cmbFilterDepartment
            // 
            cmbFilterDepartment.FormattingEnabled = true;
            cmbFilterDepartment.Location = new Point(469, 607);
            cmbFilterDepartment.Name = "cmbFilterDepartment";
            cmbFilterDepartment.Size = new Size(200, 28);
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
            label17.Location = new Point(367, 610);
            label17.Name = "label17";
            label17.Size = new Size(96, 20);
            label17.TabIndex = 36;
            label17.Text = "Department :";
            // 
            // txtFilterPosition
            // 
            txtFilterPosition.Location = new Point(111, 648);
            txtFilterPosition.Name = "txtFilterPosition";
            txtFilterPosition.Size = new Size(200, 27);
            txtFilterPosition.TabIndex = 37;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightBlue;
            btnSearch.Location = new Point(416, 647);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 40;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.LightBlue;
            btnShowAll.Location = new Point(597, 647);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(94, 29);
            btnShowAll.TabIndex = 41;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(22, 688);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(940, 150);
            dgvEmployees.TabIndex = 42;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            // 
            // chkCreateLogin
            // 
            chkCreateLogin.AutoSize = true;
            chkCreateLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkCreateLogin.ForeColor = Color.Aqua;
            chkCreateLogin.Location = new Point(527, 361);
            chkCreateLogin.Name = "chkCreateLogin";
            chkCreateLogin.Size = new Size(181, 24);
            chkCreateLogin.TabIndex = 43;
            chkCreateLogin.Text = "Create Login Account";
            chkCreateLogin.UseVisualStyleBackColor = true;
            chkCreateLogin.CheckedChanged += chkCreateLogin_CheckedChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(546, 397);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 44;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(546, 437);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 45;
            lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(646, 393);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(199, 27);
            txtUsername.TabIndex = 46;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(646, 433);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(199, 27);
            txtPassword.TabIndex = 47;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F);
            label18.Location = new Point(22, 575);
            label18.Name = "label18";
            label18.Size = new Size(140, 23);
            label18.TabIndex = 48;
            label18.Text = "Search Employee";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(982, 853);
            Controls.Add(label18);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label18;
    }
}