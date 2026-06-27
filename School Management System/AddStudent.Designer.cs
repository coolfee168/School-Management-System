namespace School_Management_System
{
    partial class frmAddStudent
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
            txtFullName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpDOB = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnClose = new Button();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            label4 = new Label();
            txtContact = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dtpStartSchoolDate = new DateTimePicker();
            txtAddress = new TextBox();
            label7 = new Label();
            txtStudentID = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(54, 106);
            label1.Name = "label1";
            label1.Size = new Size(120, 35);
            label1.TabIndex = 0;
            label1.Text = "FullName";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 14F);
            txtFullName.Location = new Point(215, 106);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(275, 40);
            txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(614, 111);
            label2.Name = "label2";
            label2.Size = new Size(159, 35);
            label2.TabIndex = 2;
            label2.Text = "Birth Of Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(54, 193);
            label3.Name = "label3";
            label3.Size = new Size(96, 35);
            label3.TabIndex = 3;
            label3.Text = "Gender";
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarFont = new Font("Segoe UI", 12F);
            dtpDOB.Location = new Point(798, 116);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(250, 27);
            dtpDOB.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(47, 567);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(182, 56);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(252, 567);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(182, 56);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(460, 567);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(182, 56);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(859, 567);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(182, 56);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(215, 206);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(63, 24);
            rdoMale.TabIndex = 11;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(373, 206);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(78, 24);
            rdoFemale.TabIndex = 12;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(614, 193);
            label4.Name = "label4";
            label4.Size = new Size(100, 35);
            label4.TabIndex = 13;
            label4.Text = "Contact";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 14F);
            txtContact.Location = new Point(746, 193);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(302, 39);
            txtContact.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(54, 273);
            label5.Name = "label5";
            label5.Size = new Size(206, 35);
            label5.TabIndex = 15;
            label5.Text = "Start School Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(54, 353);
            label6.Name = "label6";
            label6.Size = new Size(105, 35);
            label6.TabIndex = 16;
            label6.Text = "Address";
            // 
            // dtpStartSchoolDate
            // 
            dtpStartSchoolDate.CalendarFont = new Font("Segoe UI", 12F);
            dtpStartSchoolDate.Location = new Point(318, 283);
            dtpStartSchoolDate.Name = "dtpStartSchoolDate";
            dtpStartSchoolDate.Size = new Size(249, 27);
            dtpStartSchoolDate.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14F);
            txtAddress.Location = new Point(202, 353);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(846, 40);
            txtAddress.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(54, 30);
            label7.Name = "label7";
            label7.Size = new Size(316, 38);
            label7.TabIndex = 19;
            label7.Text = "Student Information";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(958, 41);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(90, 27);
            txtStudentID.TabIndex = 20;
            txtStudentID.Visible = false;
            // 
            // frmAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 674);
            Controls.Add(txtStudentID);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(dtpStartSchoolDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtContact);
            Controls.Add(label4);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpDOB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Name = "frmAddStudent";
            Text = "AddStudent";
            Load += frmAddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDOB;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnClose;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private Label label4;
        private TextBox txtContact;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpStartSchoolDate;
        private TextBox txtAddress;
        private Label label7;
        private TextBox txtStudentID;
    }
}