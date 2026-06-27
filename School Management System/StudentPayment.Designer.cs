namespace School_Management_System
{
    partial class frmStudentPayment
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
            cboMonth = new ComboBox();
            cboYear = new ComboBox();
            dgvPayment = new DataGridView();
            btnRefresh = new Button();
            btnComfirm = new Button();
            btnUnpaid = new Button();
            btnPaid = new Button();
            btnShowAll = new Button();
            btnPayment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(472, 57);
            label1.TabIndex = 5;
            label1.Text = "Payment Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 84);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 6;
            label2.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 137);
            label3.Name = "label3";
            label3.Size = new Size(58, 31);
            label3.TabIndex = 7;
            label3.Text = "Year";
            // 
            // cboMonth
            // 
            cboMonth.FormattingEnabled = true;
            cboMonth.Location = new Point(127, 87);
            cboMonth.Name = "cboMonth";
            cboMonth.Size = new Size(151, 28);
            cboMonth.TabIndex = 8;
            cboMonth.SelectedIndexChanged += cboMonth_SelectedIndexChanged;
            // 
            // cboYear
            // 
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(127, 142);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(151, 28);
            cboYear.TabIndex = 9;
            // 
            // dgvPayment
            // 
            dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Location = new Point(27, 257);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.RowHeadersWidth = 51;
            dgvPayment.Size = new Size(1042, 326);
            dgvPayment.TabIndex = 10;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(916, 186);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(153, 47);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnComfirm
            // 
            btnComfirm.Location = new Point(27, 606);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(153, 47);
            btnComfirm.TabIndex = 13;
            btnComfirm.Text = "Comfirm";
            btnComfirm.UseVisualStyleBackColor = true;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // btnUnpaid
            // 
            btnUnpaid.Location = new Point(345, 186);
            btnUnpaid.Name = "btnUnpaid";
            btnUnpaid.Size = new Size(153, 47);
            btnUnpaid.TabIndex = 14;
            btnUnpaid.Text = "Unpaid";
            btnUnpaid.UseVisualStyleBackColor = true;
            btnUnpaid.Click += btnUnpaid_Click;
            // 
            // btnPaid
            // 
            btnPaid.Location = new Point(186, 186);
            btnPaid.Name = "btnPaid";
            btnPaid.Size = new Size(153, 47);
            btnPaid.TabIndex = 15;
            btnPaid.Text = "Paid";
            btnPaid.UseVisualStyleBackColor = true;
            btnPaid.Click += button2_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(27, 186);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(153, 47);
            btnShowAll.TabIndex = 16;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(916, 132);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(153, 47);
            btnPayment.TabIndex = 17;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // frmStudentPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 674);
            Controls.Add(btnPayment);
            Controls.Add(btnShowAll);
            Controls.Add(btnPaid);
            Controls.Add(btnUnpaid);
            Controls.Add(btnComfirm);
            Controls.Add(btnRefresh);
            Controls.Add(dgvPayment);
            Controls.Add(cboYear);
            Controls.Add(cboMonth);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStudentPayment";
            Text = "StudentPayment";
            Load += frmStudentPayment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboMonth;
        private ComboBox cboYear;
        private DataGridView dgvPayment;
        private Button btnRefresh;
        private Button btnComfirm;
        private Button btnUnpaid;
        private Button btnPaid;
        private Button btnShowAll;
        private Button btnPayment;
    }
}