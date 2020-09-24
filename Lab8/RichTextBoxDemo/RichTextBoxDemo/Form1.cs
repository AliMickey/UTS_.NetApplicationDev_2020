using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fontName = richTextBox1.SelectionFont.Name;
            richTextBox1.SelectionFont = new Font(fontName, richTextBox1.SelectionFont.Size + 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fontName = richTextBox1.SelectionFont.Name;
            richTextBox1.SelectionFont = new Font(fontName, richTextBox1.SelectionFont.Size - 2);
        }
    }
}
