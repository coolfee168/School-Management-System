using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class frmAddStudent : Form
    {
        SqlConnection con = new SqlConnection(
    "Server= localhost\\SQLEXPRESS ;Initial Catalog=SchoolManagementDB;Integrated Security=True");
        public frmAddStudent()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
        }
        public frmAddStudent(
            int studentID,
            string fullName,
            string gender,
            DateTime dob,
            string contact,
            string address,
            DateTime startSchoolDate)
        {
            InitializeComponent();

            txtStudentID.Text = studentID.ToString();
            txtFullName.Text = fullName;
            txtContact.Text = contact;
            txtAddress.Text = address;

            dtpDOB.Value = dob;
            dtpStartSchoolDate.Value = startSchoolDate;

            if (gender == "Male")
                rdoMale.Checked = true;
            else
                rdoFemale.Checked = true;
            btnAdd.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "";

                if (rdoMale.Checked)
                    gender = "Male";
                else if (rdoFemale.Checked)
                    gender = "Female";

                string query = @"INSERT INTO tblStudent
                        (FullName, Gender, DateOfBirth,StartSchoolDate, Contact, Address)
                        VALUES
                        (@FullName, @Gender, @DateOfBirth,@StartSchoolDate, @Contact, @Address)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@StartSchoolDate", dtpStartSchoolDate.Value);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtContact.Clear();
            txtAddress.Clear();

            rdoMale.Checked = false;
            rdoFemale.Checked = false;

            dtpDOB.Value = DateTime.Now;
            dtpStartSchoolDate.Value = DateTime.Now;

            txtFullName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (rdoMale.Checked)
                gender = "Male";
            else if (rdoFemale.Checked)
                gender = "Female";

            string query =
            @"UPDATE tblStudent
      SET
        FullName = @FullName,
        Gender = @Gender,
        DateOfBirth = @DateOfBirth,
        Contact = @Contact,
        Address = @Address,
        StartSchoolDate = @StartSchoolDate
      WHERE StudentID = @StudentID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@StudentID",
                txtStudentID.Text);

            cmd.Parameters.AddWithValue(
                "@FullName",
                txtFullName.Text);

            cmd.Parameters.AddWithValue(
                "@Gender",
                gender);

            cmd.Parameters.AddWithValue(
                "@DateOfBirth",
                dtpDOB.Value);

            cmd.Parameters.AddWithValue(
                "@Contact",
                txtContact.Text);

            cmd.Parameters.AddWithValue(
                "@Address",
                txtAddress.Text);

            cmd.Parameters.AddWithValue(
                "@StartSchoolDate",
                dtpStartSchoolDate.Value);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show(
                "Student Updated Successfully");
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
