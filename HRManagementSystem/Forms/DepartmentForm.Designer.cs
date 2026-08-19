namespace HRManagementSystem.Forms
{
    partial class DepartmentForm
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
            txtDepartmentName = new TextBox();
            txtDescription = new TextBox();
            label4 = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            dgvDepartments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 36);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 0;
            label1.Text = "Department Management ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 77);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 1;
            label2.Text = "Department Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 140);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(78, 100);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(125, 27);
            txtDepartmentName.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(78, 163);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 244);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 5;
            label4.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(78, 279);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(90, 211);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(208, 211);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(324, 211);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(437, 211);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(233, 279);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvDepartments
            // 
            dgvDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartments.Location = new Point(78, 326);
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.RowHeadersWidth = 51;
            dgvDepartments.Size = new Size(628, 94);
            dgvDepartments.TabIndex = 12;
            dgvDepartments.CellContentClick += dgvDepartments_CellContentClick;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDepartments);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(txtDepartmentName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            Load += DepartmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDepartmentName;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSearch;
        private DataGridView dgvDepartments;
    }
}