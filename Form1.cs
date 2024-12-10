using System;
using System.Windows.Forms;

namespace loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "12345" && txtUser.Text == "naeem")
            {
                
                MessageBox.Show($"Welcome, {txtUser.Text}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                this.Hide();
                main ss = new main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
