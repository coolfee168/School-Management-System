namespace School_Management_System
{
    partial class frmLogin
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.gggg;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 301);
            label1.Name = "label1";
            label1.Size = new Size(125, 24);
            label1.TabIndex = 1;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(455, 346);
            label2.Name = "label2";
            label2.Size = new Size(120, 24);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnLogin.Location = new Point(615, 405);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 52);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(615, 298);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(267, 27);
            txtUser.TabIndex = 4;
            txtUser.TextChanged += txtUser_TextChanged;
            txtUser.KeyDown += txtUser_KeyDown;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(615, 347);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(267, 27);
            txtPass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            label3.Location = new Point(615, 239);
            label3.Name = "label3";
            label3.Size = new Size(161, 30);
            label3.TabIndex = 6;
            label3.Text = "SBS System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 17F, FontStyle.Bold);
            label4.Location = new Point(569, 236);
            label4.Name = "label4";
            label4.Size = new Size(0, 35);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 17F, FontStyle.Bold);
            label5.Location = new Point(635, 192);
            label5.Name = "label5";
            label5.Size = new Size(135, 35);
            label5.TabIndex = 8;
            label5.Text = "Login to";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(424, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 350);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1348, 721);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
    }
}