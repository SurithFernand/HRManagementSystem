namespace HRManagementSystem.Forms
{
    partial class HRLeaveManagementForm
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
            dgvLeaveRequests = new DataGridView();
            label3 = new Label();
            txtDecisionComment = new TextBox();
            btnApprove = new Button();
            btnReject = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLeaveRequests).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(322, 25);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Leave Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 73);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Leave Requests ";
            // 
            // dgvLeaveRequests
            // 
            dgvLeaveRequests.AllowUserToAddRows = false;
            dgvLeaveRequests.AllowUserToDeleteRows = false;
            dgvLeaveRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLeaveRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeaveRequests.Location = new Point(81, 110);
            dgvLeaveRequests.MultiSelect = false;
            dgvLeaveRequests.Name = "dgvLeaveRequests";
            dgvLeaveRequests.ReadOnly = true;
            dgvLeaveRequests.RowHeadersWidth = 51;
            dgvLeaveRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLeaveRequests.Size = new Size(764, 188);
            dgvLeaveRequests.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 344);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 3;
            label3.Text = "Decision Comment:";
            // 
            // txtDecisionComment
            // 
            txtDecisionComment.Location = new Point(81, 378);
            txtDecisionComment.Multiline = true;
            txtDecisionComment.Name = "txtDecisionComment";
            txtDecisionComment.Size = new Size(301, 65);
            txtDecisionComment.TabIndex = 4;
            // 
            // btnApprove
            // 
            btnApprove.Location = new Point(143, 449);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(94, 29);
            btnApprove.TabIndex = 5;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.Location = new Point(391, 449);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(94, 29);
            btnReject.TabIndex = 6;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // HRLeaveManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 540);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(txtDecisionComment);
            Controls.Add(label3);
            Controls.Add(dgvLeaveRequests);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HRLeaveManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HRLeaveManagementForm";
            Load += HRLeaveManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLeaveRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvLeaveRequests;
        private Label label3;
        private TextBox txtDecisionComment;
        private Button btnApprove;
        private Button btnReject;
    }
}