using Auth.GG_Winform_Example;
using System;
using System.Windows.Forms;

namespace Epic_Dumper
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (API.Login(username.Text, password.Text))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
        }
    }
}
