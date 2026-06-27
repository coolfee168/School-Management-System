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
    public partial class frmClass : Form
    {
        SqlConnection con = new SqlConnection(
            "Server= localhost\\SQLEXPRESS ;Initial Catalog=SchoolManagementDB;Integrated Security=True");
        public frmClass()
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            LoadClass();
        }
        private void LoadClass()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblClass", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvClass.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewClass frm = new frmNewClass();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadClass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvClass.CurrentRow == null)
            {
                MessageBox.Show("Please select a class.");
                return;
            }

            int id = Convert.ToInt32(
                dgvClass.CurrentRow.Cells["ClassID"].Value);

            DialogResult result =
                MessageBox.Show(
                    "Delete this class?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "DELETE FROM tblClass WHERE ClassID=@id",
                        con);

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Class deleted.");

                LoadClass();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvClass.CurrentRow == null)
            {
                MessageBox.Show("Please select a class.");
                return;
            }

            int classID = Convert.ToInt32(
                dgvClass.CurrentRow.Cells["ClassID"].Value);

            string className =
                dgvClass.CurrentRow.Cells["ClassName"].Value.ToString();

            frmClassDetail frm =
                new frmClassDetail();

            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
