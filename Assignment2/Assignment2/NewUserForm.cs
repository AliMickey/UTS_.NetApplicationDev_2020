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
            // Call custom class and show the same instance of login form.
            FormProvider.Log.Show();
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
            if (Login.users.UserNameExists(username))
            {
                MessageBox.Show("Username Already Exists\n\nPlease Try Again.", "Error");
            }
            else if (password != txtPassword2.Text)
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
                Login.users.NewUser(username, password, type, fName, lName, dob);
                FormProvider.Log.Show();
                Close();
            }            
        }

        private void btnPassVisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                txtPassword2.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPassword2.PasswordChar = '*';
            }          
        }
    }
}