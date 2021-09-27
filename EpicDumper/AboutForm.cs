using Auth.GG_Winform_Example;
using System;
using System.Windows.Forms;

namespace Epic_Dumper
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {

            InitializeComponent();
            userid.Text = "ID: " + User.ID;
            username.Text = "Username: " + User.Username;
            email.Text = "Email: " + User.Email;
            hwid.Text = "HWID: " + User.HWID;
            uservariable.Text = "User Variable: " + User.UserVariable;
            userrank.Text = "Rank: " + User.Rank;
            ip.Text = "IP: " + User.IP;
            expiry.Text = "Expiry: " + User.Expiry;
            lastlogin.Text = "Last Login: " + User.LastLogin;
            registerdate.Text = "Register Date: " + User.RegisterDate;
        }

        void ButtonCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
