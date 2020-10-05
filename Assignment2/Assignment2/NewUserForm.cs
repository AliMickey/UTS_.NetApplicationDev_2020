using System;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {          
            // Make new instance of login page and close this form.
            Login loginForm = new Login();
            loginForm.Show();
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string type = boxUserType.Text;
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string dob = dateDOB.Text.Replace("/", "-");
            if (password != txtPassword2.Text)
            {
                MessageBox.Show("Passwords Do Not Match\n\nPlease Try Again.", "Error");
            }
            else if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) ||
                String.IsNullOrEmpty(type) || String.IsNullOrEmpty(fName) ||
                String.IsNullOrEmpty(lName) || String.IsNullOrEmpty(dob))
            {
                MessageBox.Show("Invalid Input/s\n\nPlease Try Again.", "Error");
            }
            else
            {
                UserList users = new UserList();
                users.NewUser(username, password, type, fName, lName, dob);
                Login loginForm = new Login();
                loginForm.Show();
                Close();              
            }            
        }
    }
}
