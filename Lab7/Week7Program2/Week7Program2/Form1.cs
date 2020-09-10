using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public string GetReceipt()
        {
            // Write code to Initialize the variables for total proice and the recipt string
            double totalPrice = 0.0;
            string receipt = "Student Restaurant\n\nYour Order Details:\n\n";

            // Write code to Process each selected food item and calculate the total price
            foreach (int items in itemsList.SelectedIndices)
            {
                // Write code to Concatenate the selected food items and their price.
                receipt = receipt + itemsList.Items[items] + " : $" + priceList.Items[items] + "\n";

                // Write code to Calculate the total price
                totalPrice += Convert.ToDouble(priceList.Items[items]);
               
            }
            // Write code to Add the total price to the Receipt
            receipt = receipt + "\nTotal Price : $" + totalPrice;

            // Write code to Return receipt
            return receipt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            receiptlbl.Text = GetReceipt();
        }
    }
}
