﻿using System;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Login : Form
    {
        public static UserList users = new UserList();

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
            NewUserForm newuserform = new NewUserForm();
            newuserform.Show();
            // Call custom class to hide the login form.
            FormProvider.Log.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // If user exists, launch the text editor.
            if (users.UserExists(txtUsername.Text, txtPassword.Text))
            {
                TextEditorForm texteditorform = new TextEditorForm(txtUsername.Text, users.UserType(txtUsername.Text));
                texteditorform.Show();
                FormProvider.Log.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Credentials\n\nPlease Try Again", "Error");
            } 
        }

        private void btnPassVisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }

            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
        }
    }
}