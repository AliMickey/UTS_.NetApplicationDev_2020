using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class TextEditorForm : Form
    {
        private string currentFile;
        public TextEditorForm(string username, string type)
        {
            InitializeComponent();
            toolFontSize.SelectedIndex = 2;
            toolUserName.Text = "User Name: " + username;
            if (type == "View")
            {
                richTxtBox.ReadOnly = true;
            }
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
            FontStyle newFontStyle = (FontStyle)(currentFont.Style);
            richTxtBox.SelectionFont = new Font(currentFont.FontFamily, Int32.Parse(toolFontSize.SelectedItem.ToString()), newFontStyle);
        }

        private void toolCut_Click(object sender, EventArgs e)
        {
            // Copy selected text to clipboard and clear selected text.
            richTxtBox.Cut();
        }

        private void toolCopy_Click(object sender, EventArgs e)
        {
            // Copy selected text to clipboard.
            richTxtBox.Copy();
        }

        private void toolPaste_Click(object sender, EventArgs e)
        {
            // Paste clipboard.
            richTxtBox.Paste();
        }

        private void toolNew_Click(object sender, EventArgs e)
        {
            // If file is empty clear it out in case.
            if (richTxtBox.Text == "")
            {
                richTxtBox.Clear();
            }
            else
            {
                // Ask user to save or not.
                DialogResult result1 = MessageBox.Show("Do you want to save changes?", "Warning", MessageBoxButtons.YesNoCancel);
                // Save the file by calling save method.
                if (result1 == DialogResult.Yes)
                {
                    toolSave_Click(sender, e);
                }
                // Clear the file out.
                if (result1 == DialogResult.No)
                {
                    richTxtBox.Clear();
                }
            }  
        }

        private void toolOpen_Click(object sender, EventArgs e)
        {
            // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.richtextbox.loadfile?view=netcore-3.1
            OpenFileDialog openFile = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile.ShowDialog() == DialogResult.OK && openFile.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                currentFile = openFile.FileName;
                richTxtBox.LoadFile(currentFile);       
            }
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(currentFile))
            {
                richTxtBox.SaveFile(currentFile);
            }

            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "*.rtf";
                saveFile.Filter = "RTF Files|*.rtf";

                saveFile.FilterIndex = 2;
                saveFile.RestoreDirectory = true;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    currentFile = saveFile.FileName;
                    richTxtBox.SaveFile(currentFile);
                    Text = "Text Editor - " + currentFile;
                }
            }
        }

        private void toolSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.rtf";
            saveFile.Filter = "RTF Files|*.rtf";

            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                currentFile = saveFile.FileName;
                richTxtBox.SaveFile(currentFile);
                richTxtBox.LoadFile(currentFile);
                Text = "Text Editor - " + currentFile;
            }
        }
    }
}