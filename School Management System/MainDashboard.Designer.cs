namespace School_Management_System
{
    partial class frmMain
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
            dtpToday = new DateTimePicker();
            panel4 = new Panel();
            label4 = new Label();
            lblTotalTeacher = new Label();
            panel3 = new Panel();
            label2 = new Label();
            lblTotalClass = new Label();
            panel2 = new Panel();
            label1 = new Label();
            lblTotalStudent = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnAddStudent = new Button();
            panelMain = new Panel();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // dtpToday
            // 
            dtpToday.Enabled = false;
            dtpToday.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpToday.Location = new Point(793, 3);
            dtpToday.Name = "dtpToday";
            dtpToday.Size = new Size(301, 30);
            dtpToday.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblTotalTeacher);
            panel4.Location = new Point(749, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(289, 122);
            panel4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 19);
            label4.Name = "label4";
            label4.Size = new Size(244, 46);
            label4.TabIndex = 3;
            label4.Text = "Total Teachers";
            // 
            // lblTotalTeacher
            // 
            lblTotalTeacher.AutoSize = true;
            lblTotalTeacher.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTeacher.Location = new Point(129, 65);
            lblTotalTeacher.Name = "lblTotalTeacher";
            lblTotalTeacher.Size = new Size(28, 31);
            lblTotalTeacher.TabIndex = 2;
            lblTotalTeacher.Text = "C";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblTotalClass);
            panel3.Location = new Point(403, 130);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 122);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 19);
            label2.Name = "label2";
            label2.Size = new Size(220, 46);
            label2.TabIndex = 2;
            label2.Text = "Total Classes";
            label2.Click += label2_Click;
            // 
            // lblTotalClass
            // 
            lblTotalClass.AutoSize = true;
            lblTotalClass.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalClass.Location = new Point(129, 65);
            lblTotalClass.Name = "lblTotalClass";
            lblTotalClass.Size = new Size(28, 31);
            lblTotalClass.TabIndex = 1;
            lblTotalClass.Text = "B";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTotalStudent);
            panel2.Location = new Point(53, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 122);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(248, 46);
            label1.TabIndex = 1;
            label1.Text = "Total Students";
            // 
            // lblTotalStudent
            // 
            lblTotalStudent.AutoSize = true;
            lblTotalStudent.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStudent.Location = new Point(129, 65);
            lblTotalStudent.Name = "lblTotalStudent";
            lblTotalStudent.Size = new Size(29, 31);
            lblTotalStudent.TabIndex = 0;
            lblTotalStudent.Text = "A";
            lblTotalStudent.Click += lblTotalStudent_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F);
            label3.Location = new Point(8, 8);
            label3.Name = "label3";
            label3.Size = new Size(770, 67);
            label3.TabIndex = 4;
            label3.Text = "Hello, Welcome to the Dashboard";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnAddStudent);
            groupBox1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(749, 309);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 353);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quick Action";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button4.Location = new Point(54, 289);
            button4.Name = "button4";
            button4.Size = new Size(180, 45);
            button4.TabIndex = 3;
            button4.Text = "Announcment";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button3.Location = new Point(54, 214);
            button3.Name = "button3";
            button3.Size = new Size(180, 45);
            button3.TabIndex = 2;
            button3.Text = "Report";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button2.Location = new Point(54, 140);
            button2.Name = "button2";
            button2.Size = new Size(180, 45);
            button2.TabIndex = 1;
            button2.Text = "Add New Class";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnAddStudent.Location = new Point(54, 65);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(180, 45);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add New Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += button1_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dtpToday);
            panelMain.Controls.Add(groupBox1);
            panelMain.Controls.Add(panel4);
            panelMain.Controls.Add(panel2);
            panelMain.Controls.Add(panel3);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1097, 674);
            panelMain.TabIndex = 10;
            panelMain.Paint += panelMain_Paint;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1097, 674);
            Controls.Add(label3);
            Controls.Add(panelMain);
            Name = "frmMain";
            Text = "MainDashboard";
            Load += frmMain_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpToday;
        private Panel panel4;
        private Label lblTotalTeacher;
        private Panel panel3;
        private Label lblTotalClass;
        private Panel panel2;
        private Label lblTotalStudent;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnAddStudent;
        private Panel panelMain;
    }
}