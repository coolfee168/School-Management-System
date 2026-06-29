
namespace School_Management_System
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmMain());             //Auto dashboard in panel
            lblUser.Text = "User: " + Session.Username;
            lblRole.Text = "Role: " + Session.Role;

            if (Session.Role == "Teacher")
            {
                // Example:
                // btnUserManagement.Visible = false;
            }

        }
        private void OpenChildForm(Form childForm)
        {
            panelMain.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(childForm);
            childForm.Show();
        }
        private void OpenFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to logout?",
            "Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();

                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMain());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStudent());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmManage());
        }
        private Form activeForm = null;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPayment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStudentPayment());
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmClasss());
        }
    }
}
