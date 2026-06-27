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
    public partial class frmStudentPayment : Form
    {
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Initial Catalog=SchoolManagementDB;Integrated Security=True");
        public frmStudentPayment()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmStudentPayment_Load(object sender, EventArgs e)
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

            for (int i = 2025; i <= 2035; i++)
            {
                cboYear.Items.Add(i);
            }

            cboMonth.Text = DateTime.Now.ToString("MMMM");
            cboYear.Text = DateTime.Now.Year.ToString();
            LoadPayment();
        }
        private void LoadPayment()
        {
            string query = @"
    SELECT
        s.StudentID,
        s.FullName,

        ISNULL(p.Amount, 0) AS Amount,

        CASE
            WHEN p.StudentID IS NULL THEN 'Unpaid'
            ELSE 'Paid'
        END AS Status,

        p.PayDate

    FROM tblStudent s

    LEFT JOIN tblPayment p
        ON s.StudentID = p.StudentID
        AND p.PayMonth = @PayMonth
        AND p.PayYear = @PayYear";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            da.SelectCommand.Parameters.AddWithValue("@PayMonth", cboMonth.Text);
            da.SelectCommand.Parameters.AddWithValue("@PayYear", cboYear.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvPayment.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadPayment();
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPayment();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPayment();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (dgvPayment.CurrentRow.Cells["Status"].Value.ToString() == "Paid")
            {
                MessageBox.Show("This student has already paid for this month.");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataView dv = ((DataTable)dgvPayment.DataSource).DefaultView;
            dv.RowFilter = "Status = 'Paid'";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadPayment();
        }

        private void btnUnpaid_Click(object sender, EventArgs e)
        {
            DataView dv = ((DataTable)dgvPayment.DataSource).DefaultView;
            dv.RowFilter = "Status = 'Unpaid'";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (dgvPayment.CurrentRow == null)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            frmPayment frm = new frmPayment();

            frm.StudentID =
                Convert.ToInt32(dgvPayment.CurrentRow.Cells["StudentID"].Value);

            frm.StudentName =
                dgvPayment.CurrentRow.Cells["FullName"].Value.ToString();

            frm.ShowDialog();

        }
    }
}
