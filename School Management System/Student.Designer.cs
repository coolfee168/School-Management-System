namespace School_Management_System
{
    partial class frmStudent
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
            lblTitle = new Label();
            panel1 = new Panel();
            button4 = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            btnPayment = new Button();
            btnRefresh = new Button();
            btnAddStudent = new Button();
            btnUpdate = new Button();
            dgvStudent = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(11, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(325, 54);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Search Students";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 95);
            panel1.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(328, 302);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(955, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(123, 41);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(362, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(552, 34);
            txtSearch.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnPayment);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnAddStudent);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(dgvStudent);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 582);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(465, 507);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(123, 41);
            btnPayment.TabIndex = 11;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click_1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(954, 507);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(123, 41);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(628, 507);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(123, 41);
            btnAddStudent.TabIndex = 9;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(791, 507);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 41);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(11, 24);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(1073, 448);
            dgvStudent.TabIndex = 8;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1097, 674);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmStudent";
            Text = "Student";
            Load += frmStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label lblTitle;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button button4;
        private DataGridView dgvStudent;
        private Button btnUpdate;
        private Button btnRefresh;
        private Button btnAddStudent;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button btnPayment;
    }
}