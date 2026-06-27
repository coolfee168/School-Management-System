namespace School_Management_System
{
    partial class frmManage
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
            btnTeacher = new Button();
            btnAnalyze = new Button();
            btnStudentPayment = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panelManage = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTeacher
            // 
            btnTeacher.Location = new Point(444, 12);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(194, 51);
            btnTeacher.TabIndex = 2;
            btnTeacher.Text = "Teacher ";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(710, 12);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(194, 51);
            btnAnalyze.TabIndex = 3;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnStudentPayment
            // 
            btnStudentPayment.Location = new Point(178, 12);
            btnStudentPayment.Name = "btnStudentPayment";
            btnStudentPayment.Size = new Size(194, 51);
            btnStudentPayment.TabIndex = 4;
            btnStudentPayment.Text = "Student Payment";
            btnStudentPayment.UseVisualStyleBackColor = true;
            btnStudentPayment.Click += btnStudentPayment_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 78);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 78);
            panel2.TabIndex = 6;
            // 
            // panelManage
            // 
            panelManage.Dock = DockStyle.Fill;
            panelManage.Location = new Point(0, 78);
            panelManage.Name = "panelManage";
            panelManage.Size = new Size(1097, 596);
            panelManage.TabIndex = 6;
            // 
            // frmManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 674);
            Controls.Add(panelManage);
            Controls.Add(btnStudentPayment);
            Controls.Add(btnAnalyze);
            Controls.Add(btnTeacher);
            Controls.Add(panel1);
            Name = "frmManage";
            Text = "manage";
            Load += frmManage_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnTeacher;
        private Button btnAnalyze;
        private Button button3;
        private Button btnStudentPayment;
        private Panel panel1;
        private Panel panel2;
        private Panel panelManage;
    }
}