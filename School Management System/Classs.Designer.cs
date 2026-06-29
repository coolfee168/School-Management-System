namespace School_Management_System
{
    partial class frmClasss
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
            lblClass = new Label();
            btnOpenclass = new Button();
            dgvClass = new DataGridView();
            btnDeleteclass = new Button();
            btnUpdateclass = new Button();
            btnAddclass = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            SuspendLayout();
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblClass.Location = new Point(351, 11);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(396, 57);
            lblClass.TabIndex = 9;
            lblClass.Text = "Class Management";
            // 
            // btnOpenclass
            // 
            btnOpenclass.Location = new Point(837, 603);
            btnOpenclass.Name = "btnOpenclass";
            btnOpenclass.Size = new Size(183, 61);
            btnOpenclass.TabIndex = 10;
            btnOpenclass.Text = "Open Class";
            btnOpenclass.UseVisualStyleBackColor = true;
            // 
            // dgvClass
            // 
            dgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClass.Location = new Point(77, 217);
            dgvClass.Name = "dgvClass";
            dgvClass.RowHeadersWidth = 51;
            dgvClass.Size = new Size(943, 380);
            dgvClass.TabIndex = 8;
            // 
            // btnDeleteclass
            // 
            btnDeleteclass.Location = new Point(705, 120);
            btnDeleteclass.Name = "btnDeleteclass";
            btnDeleteclass.Size = new Size(183, 61);
            btnDeleteclass.TabIndex = 7;
            btnDeleteclass.Text = "Delete Class";
            btnDeleteclass.UseVisualStyleBackColor = true;
            // 
            // btnUpdateclass
            // 
            btnUpdateclass.Location = new Point(454, 120);
            btnUpdateclass.Name = "btnUpdateclass";
            btnUpdateclass.Size = new Size(183, 61);
            btnUpdateclass.TabIndex = 6;
            btnUpdateclass.Text = "Update Class";
            btnUpdateclass.UseVisualStyleBackColor = true;
            // 
            // btnAddclass
            // 
            btnAddclass.Location = new Point(203, 120);
            btnAddclass.Name = "btnAddclass";
            btnAddclass.Size = new Size(183, 61);
            btnAddclass.TabIndex = 5;
            btnAddclass.Text = "Add Class";
            btnAddclass.UseVisualStyleBackColor = true;
            btnAddclass.Click += btnAddclass_Click;
            // 
            // frmClasss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 674);
            Controls.Add(lblClass);
            Controls.Add(btnOpenclass);
            Controls.Add(dgvClass);
            Controls.Add(btnDeleteclass);
            Controls.Add(btnUpdateclass);
            Controls.Add(btnAddclass);
            Name = "frmClasss";
            Text = "Classs";
//            Load += Classs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClass;
        private Button btnOpenclass;
        private DataGridView dgvClass;
        private Button btnDeleteclass;
        private Button btnUpdateclass;
        private Button btnAddclass;
    }
}