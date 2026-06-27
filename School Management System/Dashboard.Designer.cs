namespace School_Management_System
{
    partial class frmDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUser = new Label();
            lblRole = new Label();
            panel1 = new Panel();
            frmPayment = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnStudent = new Button();
            btnManage = new Button();
            btnClass = new Button();
            btnDashboard = new Button();
            btnLogout = new Button();
            panelMain = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblUser.Location = new Point(33, 536);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(76, 41);
            lblUser.TabIndex = 0;
            lblUser.Text = "user";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(38, 577);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(35, 20);
            lblRole.TabIndex = 1;
            lblRole.Text = "role";
            lblRole.Click += lblRole_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveBorder;
            panel1.Controls.Add(frmPayment);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnStudent);
            panel1.Controls.Add(btnManage);
            panel1.Controls.Add(btnClass);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 721);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // frmPayment
            // 
            frmPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            frmPayment.Location = new Point(38, 326);
            frmPayment.Name = "frmPayment";
            frmPayment.Size = new Size(150, 56);
            frmPayment.TabIndex = 16;
            frmPayment.Text = "Payment";
            frmPayment.UseVisualStyleBackColor = true;
            frmPayment.Click += frmPayment_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.sovabb;
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 62);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.Location = new Point(79, 58);
            label2.Name = "label2";
            label2.Size = new Size(135, 19);
            label2.TabIndex = 14;
            label2.Text = "School Management";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(79, 28);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 13;
            label1.Text = "SBS System";
            label1.Click += label1_Click;
            // 
            // btnStudent
            // 
            btnStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(38, 182);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(150, 56);
            btnStudent.TabIndex = 12;
            btnStudent.Text = "Students";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += button3_Click;
            // 
            // btnManage
            // 
            btnManage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManage.Location = new Point(38, 398);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(150, 56);
            btnManage.TabIndex = 11;
            btnManage.Text = "Manage";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += button2_Click_1;
            // 
            // btnClass
            // 
            btnClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClass.Location = new Point(38, 254);
            btnClass.Name = "btnClass";
            btnClass.Size = new Size(150, 56);
            btnClass.TabIndex = 10;
            btnClass.Text = "Classes";
            btnClass.UseVisualStyleBackColor = true;
            btnClass.Click += button1_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(38, 110);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(150, 56);
            btnDashboard.TabIndex = 9;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += button6_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(38, 613);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(107, 41);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button5_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Dock = DockStyle.Right;
            panelMain.Location = new Point(233, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1115, 721);
            panelMain.TabIndex = 3;
            panelMain.Paint += panelMain_Paint;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "frmDashboard";
            Text = "Dashboard";
            Load += frmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUser;
        private Label lblRole;
        private Panel panel1;
        private Button button5;
        private Label label1;
        private Button btnStudent;
        private Button btnManage;
        private Button btnClass;
        private Button btnDashboard;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panelMain;
        private Button btnLogout;
        private Button frmPayment;
    }
}
