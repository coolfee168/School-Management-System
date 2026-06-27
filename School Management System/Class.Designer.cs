namespace School_Management_System
{
    partial class frmClass
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
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dgvClass = new DataGridView();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 96);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label2.Location = new Point(354, 18);
            label2.Name = "label2";
            label2.Size = new Size(396, 57);
            label2.TabIndex = 3;
            label2.Text = "Class Management";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(201, 118);
            button1.Name = "button1";
            button1.Size = new Size(183, 61);
            button1.TabIndex = 0;
            button1.Text = "Add Class";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(452, 118);
            button2.Name = "button2";
            button2.Size = new Size(183, 61);
            button2.TabIndex = 1;
            button2.Text = "Update Class";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(703, 118);
            button3.Name = "button3";
            button3.Size = new Size(183, 61);
            button3.TabIndex = 2;
            button3.Text = "Delete Class";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dgvClass
            // 
            dgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClass.Location = new Point(75, 215);
            dgvClass.Name = "dgvClass";
            dgvClass.RowHeadersWidth = 51;
            dgvClass.Size = new Size(943, 380);
            dgvClass.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(835, 601);
            button4.Name = "button4";
            button4.Size = new Size(183, 61);
            button4.TabIndex = 4;
            button4.Text = "Open Class";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // frmClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 674);
            Controls.Add(button4);
            Controls.Add(dgvClass);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "frmClass";
            Text = "Class";
            Load += frmClass_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dgvClass;
        private Label label2;
        private Button button4;
    }
}