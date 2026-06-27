using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;                //Install Nuget Package System.Data.SqlClient
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class frmLogin : Form
    {
        //Connect to Database
        string connStr = "Server= localhost\\SQLEXPRESS;Database = SchoolManagementDB ;Integrated Security= true;Trusted_Connection= true;";
        public frmLogin()      
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;        //Add function
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);         //Open SQL
            try
            {           
                con.Open();
                string sql =
                    "SELECT Username, Role " +
                    "FROM tblUser " +
                    "WHERE Username=@Username AND Password=@Password";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Username", txtUser.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPass.Text.Trim());

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())                  //if the Username&pass correct -> new dashboard with session below
                {
                    Session.Username = dr["Username"].ToString();           
                    Session.Role = dr["Role"].ToString();

                    frmDashboard dashboard = new frmDashboard();
                    dashboard.Show();

                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Invalid Username or Password");            //Or wrong pass and user
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)// When click enter in username textbox, it will move to password textbox
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void txtPass_KeyDown(object sender, KeyEventArgs e)     //Enter password and click enter, it will perform login button click
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }













}
