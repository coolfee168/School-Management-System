namespace School_Management_System
{
    partial class frmPayment
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
            cboMonth = new ComboBox();
            cboStatus = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpPayDate = new DateTimePicker();
            btnSave = new Button();
            btnClear = new Button();
            btnClose = new Button();
            lblStudentID = new Label();
            lblStudentName = new Label();
            label5 = new Label();
            txtAmount = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // cboMonth
            // 
            cboMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonth.FormattingEnabled = true;
            cboMonth.Location = new Point(253, 281);
            cboMonth.Name = "cboMonth";
            cboMonth.Size = new Size(232, 28);
            cboMonth.TabIndex = 2;
            cboMonth.SelectedIndexChanged += cboMonth_SelectedIndexChanged;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(253, 506);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(232, 28);
            cboStatus.TabIndex = 3;
            cboStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 57);
            label1.TabIndex = 4;
            label1.Text = "Payment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(31, 274);
            label2.Name = "label2";
            label2.Size = new Size(88, 35);
            label2.TabIndex = 5;
            label2.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(31, 499);
            label3.Name = "label3";
            label3.Size = new Size(81, 35);
            label3.TabIndex = 6;
            label3.Text = "Status";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(31, 424);
            label4.Name = "label4";
            label4.Size = new Size(67, 35);
            label4.TabIndex = 7;
            label4.Text = "Date";
            // 
            // dtpPayDate
            // 
            dtpPayDate.Location = new Point(253, 432);
            dtpPayDate.Name = "dtpPayDate";
            dtpPayDate.Size = new Size(232, 27);
            dtpPayDate.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(28, 616);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 46);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(191, 616);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(139, 46);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(354, 616);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 46);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 15F);
            lblStudentID.Location = new Point(253, 124);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(151, 35);
            lblStudentID.TabIndex = 12;
            lblStudentID.Text = "lblStudentID";
            lblStudentID.Click += lblStudentID_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 15F);
            lblStudentName.Location = new Point(253, 199);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(193, 35);
            lblStudentName.TabIndex = 13;
            lblStudentName.Text = "lblStudentName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(31, 349);
            label5.Name = "label5";
            label5.Size = new Size(104, 35);
            label5.TabIndex = 14;
            label5.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(253, 358);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(232, 27);
            txtAmount.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(31, 124);
            label6.Name = "label6";
            label6.Size = new Size(164, 35);
            label6.TabIndex = 16;
            label6.Text = "StudentID    : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(31, 199);
            label7.Name = "label7";
            label7.Size = new Size(206, 35);
            label7.TabIndex = 17;
            label7.Text = "StudentName    : ";
            // 
            // frmPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 674);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtAmount);
            Controls.Add(label5);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentID);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(dtpPayDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboStatus);
            Controls.Add(cboMonth);
            Name = "frmPayment";
            Text = "Payment";
            Load += Payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private Label StudentID;
        //private Label StudentName;
        private ComboBox cboMonth;
        private ComboBox cboStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpPayDate;
        private Button btnSave;
        private Button btnClear;
        private Button btnClose;
        private Label lblStudentID;
        private Label lblStudentName;
        private Label label5;
        private TextBox txtAmount;
        private Label label6;
        private Label label7;
    }
}