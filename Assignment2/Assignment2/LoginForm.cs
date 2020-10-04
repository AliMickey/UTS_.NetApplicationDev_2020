using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Login : Form
    {
        readonly UserList users = new UserList();
        public Login()
        {
            InitializeComponent();
            users.LoadUsers("login.txt");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Hide();
            NewUserForm newuserform = new NewUserForm();
            newuserform.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (users.UserExists(txtUsername.Text, txtPassword.Text))
            {
                Hide();
                TextEditorForm texteditorform = new TextEditorForm();
                texteditorform.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials\n\nPlease Try Again", "Error");
            } 
        }
    }
}
