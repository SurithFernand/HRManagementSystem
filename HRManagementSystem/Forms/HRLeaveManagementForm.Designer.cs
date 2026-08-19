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
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(299, 13);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 0;
            label1.Text = "Leave Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(47, 73);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 1;
            label2.Text = "Leave Requests ";
            // 
            // dgvLeaveRequests
            // 
            dgvLeaveRequests.AllowUserToAddRows = false;
            dgvLeaveRequests.AllowUserToDeleteRows = false;
            dgvLeaveRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLeaveRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeaveRequests.Location = new Point(47, 101);
            dgvLeaveRequests.MultiSelect = false;
            dgvLeaveRequests.Name = "dgvLeaveRequests";
            dgvLeaveRequests.ReadOnly = true;
            dgvLeaveRequests.RowHeadersWidth = 51;
            dgvLeaveRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLeaveRequests.Size = new Size(764, 220);
            dgvLeaveRequests.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(47, 360);
            label3.Name = "label3";
            label3.Size = new Size(159, 23);
            label3.TabIndex = 3;
            label3.Text = "Decision Comment:";
            // 
            // txtDecisionComment
            // 
            txtDecisionComment.Location = new Point(47, 392);
            txtDecisionComment.Multiline = true;
            txtDecisionComment.Name = "txtDecisionComment";
            txtDecisionComment.Size = new Size(764, 78);
            txtDecisionComment.TabIndex = 4;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.DeepSkyBlue;
            btnApprove.Location = new Point(164, 478);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(100, 29);
            btnApprove.TabIndex = 5;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.LightBlue;
            btnReject.Location = new Point(570, 478);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(100, 29);
            btnReject.TabIndex = 6;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // HRLeaveManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
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