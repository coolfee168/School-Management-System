using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class frmPayment : Form
    {
        public int StudentID;
        public string StudentName;

        SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Initial Catalog=SchoolManagementDB;Integrated Security=True");
        public frmPayment()
        {
            InitializeComponent();
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboMonth.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            txtAmount.Clear();
            dtpPayDate.Value = DateTime.Now;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            cboMonth.Items.Add("January");
            cboMonth.Items.Add("February");
            cboMonth.Items.Add("March");
            cboMonth.Items.Add("April");
            cboMonth.Items.Add("May");
            cboMonth.Items.Add("June");
            cboMonth.Items.Add("July");
            cboMonth.Items.Add("August");
            cboMonth.Items.Add("September");
            cboMonth.Items.Add("October");
            cboMonth.Items.Add("November");
            cboMonth.Items.Add("December");

            cboStatus.Items.Add("Paid");
            cboStatus.Items.Add("Unpaid");
            lblStudentID.Text = StudentID.ToString();
            lblStudentName.Text = StudentName;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO tblPayment (StudentID, PayMonth,PayYear, Amount, PaymentStatus ,PayDate )
                        VALUES
                        ( @StudentID, @PayMonth,@PayYear, @Amount,@PaymentStatus, @PayDate)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@StudentID", StudentID);
                cmd.Parameters.AddWithValue("@PayMonth", cboMonth.Text);
                cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                cmd.Parameters.AddWithValue("@PaymentStatus", cboStatus.Text);
                cmd.Parameters.AddWithValue("@PayDate", dtpPayDate.Value);
                cmd.Parameters.AddWithValue("@PayYear",DateTime.Now.Year);

                con.Open();
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
                con.Close();

                MessageBox.Show("Payment Saved Successfully!");

                btnClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblStudentID_Click(object sender, EventArgs e)
        {

        }
    }
}
