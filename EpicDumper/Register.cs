using Auth.GG_Winform_Example;
using System;
using System.Windows.Forms;

namespace Epic_Dumper
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (API.Register(username.Text, password.Text, email.Text, license.Text))
            {
                MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Login().Show();
                this.Hide();
            }
        }
    }
}
