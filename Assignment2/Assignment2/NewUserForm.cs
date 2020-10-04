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
            this.Close();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UserList users = new UserList();
            users.NewUser(txtUsername.Text, txtUsername.Text, boxUserType.Text, txtFName.Text, txtLName.Text, dateDOB.Text);
            Console.WriteLine("Yes");
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
