using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public string GetReceipt()
        {
            double totalPrice = 0.0;
            string receipt = "Student Restaurant\n\nYour Order Details:\n\n";

            CheckBox[] menuItems = new CheckBox[7];
            menuItems[0] = teaCoffee;
            menuItems[1] = juice;
            menuItems[2] = bananaBread;
            menuItems[3] = cereal;
            menuItems[4] = sushi;
            menuItems[5] = pizza;
            menuItems[6] = drinks;

            Label[] price = new Label[7];
            price[0] = teaCoffeePrice;
            price[1] = juicePrice;
            price[2] = bananaBreadPrice;
            price[3] = cerealPrice;
            price[4] = sushiPrice;
            price[5] = pizzaPrice;
            price[6] = drinksPrice;

            for (int loopVar = 0; loopVar < 7; loopVar++ )
            {
                if (menuItems[loopVar].Checked == true)
                {
                    receipt = receipt + menuItems[loopVar].Text + " : $" + price[loopVar].Text + "\n";
                    totalPrice += Convert.ToDouble(price[loopVar].Text);
                }
                
            }
            receipt = receipt + "Your Price : $" + totalPrice;
            return receipt;
        }

     
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string receipt = GetReceipt();
            MessageBox.Show(receipt, "Receipt");
        }
    }
}
