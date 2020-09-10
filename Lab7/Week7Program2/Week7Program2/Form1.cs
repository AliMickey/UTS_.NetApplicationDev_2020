using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Write code to Method to create the payment receipt 
        
        public string GetReceipt()
        {
            // Write code to Initialize the variables for total proice and the recipt string
            double ;
            string ;

            // Write code to Process each selected food item and calculate the total price
            foreach (int items in )
            {
                // Write code to Concatenate the selected food items and their price.
                receipt = receipt +

                // Write code to Calculate the total price
                totalPrice += ;
               
            }
            // Write code to Add the total price to the Receipt
            receipt = receipt + ;

            // Write code to Return receipt
            return ;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
