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
            string dob = dateDOB.Text;
            dob = dob.Replace("/", "-");
            if (password != txtPassword2.Text)
            {
                MessageBox.Show("Passwords Do Not Match\n\nPlease Try Again.", "Error");
            }
            else if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password) &&
                !String.IsNullOrEmpty(type) && !String.IsNullOrEmpty(fName) &&
                !String.IsNullOrEmpty(lName) && !String.IsNullOrEmpty(dob))
            {
                UserList users = new UserList();
                users.NewUser(username, password, type, fName, lName, dob);
                Login loginForm = new Login();
                loginForm.Show();
                Close();           
            }
            else
            {
                MessageBox.Show("Invalid Input/s\n\nPlease Try Again.", "Error");
            }            
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
