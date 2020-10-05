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
    public partial class TextEditorForm : Form
    {
        private string clipboard;
        public TextEditorForm(string username)
        {
            InitializeComponent();
            toolUserName.Text = "User Name: " + username;
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
            
        }

        private void toolBold_Click(object sender, EventArgs e)
        {
            // If selected text is bold make it regular.
            FontStyle style = richTxtBox.SelectionFont.Style;
            if (richTxtBox.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
                toolBold.Font = new Font(toolBold.Font, FontStyle.Regular);
            }
            // Otherwise make it bold.
            else
            {
                style |= FontStyle.Bold;
                toolBold.Font = new Font(toolBold.Font, FontStyle.Bold);
            }
            richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont, style);
            richTxtBox.Focus();
        }

        private void toolItalics_Click(object sender, EventArgs e)
        {
            // If selected text is italics make it regular.
            FontStyle style = richTxtBox.SelectionFont.Style;
            if (richTxtBox.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
                toolItalics.Font = new Font(toolItalics.Font, FontStyle.Regular);
            }
            // Otherwise make it italics.
            else
            {
                style |= FontStyle.Italic;
                toolItalics.Font = new Font(toolItalics.Font, FontStyle.Bold);
            }
            richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont, style);
            richTxtBox.Focus();
        }

        private void toolUnderline_Click(object sender, EventArgs e)
        {
            // If selected text is underlined make it regular.
            FontStyle style = richTxtBox.SelectionFont.Style;
            if (richTxtBox.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
                toolUnderline.Font = new Font(toolUnderline.Font, FontStyle.Regular);
            }
            // Otherwise make it underlined.
            else
            {
                style |= FontStyle.Underline;
                toolUnderline.Font = new Font(toolUnderline.Font, FontStyle.Bold);
            }
            richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont, style);
            richTxtBox.Focus();
        }

        private void toolFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font currentFont = richTxtBox.SelectionFont;
            FontStyle newFontStyle = (FontStyle)(currentFont.Style | FontStyle.Bold);
            richTxtBox.SelectionFont = new Font(currentFont.FontFamily, Int32.Parse(toolFontSize.SelectedItem.ToString()), newFontStyle);
        }

        private void toolCut_Click(object sender, EventArgs e)
        {
            // Copy selected text to clipboard string and clear selected text.
            clipboard = richTxtBox.SelectedText;
            richTxtBox.SelectedText = "";
        }

        private void toolCopy_Click(object sender, EventArgs e)
        {
            // Copy selected text to clipboard string.
            clipboard = richTxtBox.SelectedText;
        }

        private void toolPaste_Click(object sender, EventArgs e)
        {
            // Get current typing location.
            var cursor = richTxtBox.SelectionStart;
            // Insert clipboard string and move cursor to end of string.
            richTxtBox.Text = richTxtBox.Text.Insert(cursor, clipboard);
            richTxtBox.SelectionStart = cursor + clipboard.Length;
        }
    }
}
