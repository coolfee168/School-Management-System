using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class frmStudent : Form
    {
        SqlConnection con = new SqlConnection(
    @"Server=localhost\SQLEXPRESS;
      Initial Catalog=SchoolManagementDB;
      Integrated Security=True");
        public frmStudent()
        {
            InitializeComponent();
        }

        int studentID;
        string studentName;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent addstudent = new frmAddStudent();
            addstudent.ShowDialog();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblStudent", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvStudent.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(
    "SELECT * FROM tblStudent WHERE FullName LIKE '%" +
    txtSearch.Text + "%'",
    con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvStudent.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadStudents();
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow == null)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            frmPayment frm = new frmPayment();

            frm.StudentID =
                Convert.ToInt32(dgvStudent.CurrentRow.Cells["StudentID"].Value);

            frm.StudentName =
                dgvStudent.CurrentRow.Cells["FullName"].Value.ToString();

            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            frmAddStudent frm = new frmAddStudent(

                Convert.ToInt32(
                dgvStudent.CurrentRow.Cells["StudentID"].Value),
                dgvStudent.CurrentRow.Cells["FullName"].Value.ToString(),
                dgvStudent.CurrentRow.Cells["Gender"].Value.ToString(),

                Convert.ToDateTime(
                dgvStudent.CurrentRow.Cells["DateOfBirth"].Value),
                dgvStudent.CurrentRow.Cells["Contact"].Value.ToString(),
                dgvStudent.CurrentRow.Cells["Address"].Value.ToString(),

                Convert.ToDateTime(
                dgvStudent.CurrentRow.Cells["StartSchoolDate"].Value)
            );

            frm.ShowDialog();
        }
    }
}
