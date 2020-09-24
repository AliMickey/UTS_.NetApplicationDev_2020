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
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            NewUserForm newuserform = new NewUserForm();
            newuserform.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextEditorForm texteditorform = new TextEditorForm();
            texteditorform.Show();

        }
    }
}
