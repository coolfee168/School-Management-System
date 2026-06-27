using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class frmManage : Form
    {
        public frmManage()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmManage_Load(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {
            panelManage.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelManage.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnStudentPayment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStudentPayment());
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTeacher());
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAnalyze());
        }
    }
}
