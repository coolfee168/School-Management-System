using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class frmMain : Form
    {
        int currentImage = 0;

        string[] imagePaths;
        string[] messages;
        SqlConnection con = new SqlConnection(
            "Server= localhost\\SQLEXPRESS ;Initial Catalog=SchoolManagementDB;Integrated Security=True");
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtTotalStudent_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadTotalStudent()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM tblStudent", con);

            lblTotalStudent.Text = cmd.ExecuteScalar().ToString();

            con.Close();
        }
        private void LoadTotalClass()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM tblClass", con);

            lblTotalClass.Text = cmd.ExecuteScalar().ToString();

            con.Close();
        }
        private void LoadTotalTeacher()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM tblTeacher", con);

            lblTotalTeacher.Text = cmd.ExecuteScalar().ToString();

            con.Close();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadTotalStudent();
            LoadTotalClass();
            LoadTotalTeacher();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmAddStudent addstudent = new frmAddStudent();
            addstudent.ShowDialog();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalStudent_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
