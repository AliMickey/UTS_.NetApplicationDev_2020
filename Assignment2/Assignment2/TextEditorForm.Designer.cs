namespace Assignment2
{
    partial class TextEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripTop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNew = new System.Windows.Forms.ToolStripButton();
            this.toolOpen = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBold = new System.Windows.Forms.ToolStripButton();
            this.toolItalics = new System.Windows.Forms.ToolStripButton();
            this.toolUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolUserName = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolCut = new System.Windows.Forms.ToolStripButton();
            this.toolCopy = new System.Windows.Forms.ToolStripButton();
            this.toolPaste = new System.Windows.Forms.ToolStripButton();
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripTop,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripTop
            // 
            this.menuStripTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.toolStripSeparator1,
            this.menuSave,
            this.menuSaveAs,
            this.toolStripSeparator2,
            this.menuLogout});
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(37, 20);
            this.menuStripTop.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.Image = global::Assignment2.Properties.Resources.NewFile_16x;
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeyDisplayString = "Ctrl+N";
            this.menuNew.Size = new System.Drawing.Size(146, 22);
            this.menuNew.Text = "New";
            this.menuNew.Click += new System.EventHandler(this.toolNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Image = global::Assignment2.Properties.Resources.OpenFolder_16x;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeyDisplayString = "Ctrl+O";
            this.menuOpen.Size = new System.Drawing.Size(146, 22);
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.toolOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menuSave
            // 
            this.menuSave.Image = global::Assignment2.Properties.Resources.SaveStatusBar1_16x;
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeyDisplayString = "Ctrl+S";
            this.menuSave.Size = new System.Drawing.Size(146, 22);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Image = global::Assignment2.Properties.Resources.SaveAs_16x;
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(146, 22);
            this.menuSaveAs.Text = "Save As";
            this.menuSaveAs.Click += new System.EventHandler(this.toolSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // menuLogout
            // 
            this.menuLogout.Image = global::Assignment2.Properties.Resources.Login_16x;
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(146, 22);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCut,
            this.menuCopy,
            this.menuPaste});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem2.Text = "Edit";
            // 
            // menuCut
            // 
            this.menuCut.Image = global::Assignment2.Properties.Resources.Cut_16x;
            this.menuCut.Name = "menuCut";
            this.menuCut.ShortcutKeyDisplayString = "Ctrl+X";
            this.menuCut.Size = new System.Drawing.Size(144, 22);
            this.menuCut.Text = "Cut";
            this.menuCut.Click += new System.EventHandler(this.toolCut_Click);
            // 
            // menuCopy
            // 
            this.menuCopy.Image = global::Assignment2.Properties.Resources.Copy_16x;
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.ShortcutKeyDisplayString = "Ctrl+C";
            this.menuCopy.Size = new System.Drawing.Size(144, 22);
            this.menuCopy.Text = "Copy";
            this.menuCopy.Click += new System.EventHandler(this.toolCopy_Click);
            // 
            // menuPaste
            // 
            this.menuPaste.Image = global::Assignment2.Properties.Resources.Paste_16x;
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.ShortcutKeyDisplayString = "Ctrl+V";
            this.menuPaste.Size = new System.Drawing.Size(144, 22);
            this.menuPaste.Text = "Paste";
            this.menuPaste.Click += new System.EventHandler(this.toolPaste_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem3.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Image = global::Assignment2.Properties.Resources.InformationSymbol_16x;
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(116, 22);
            this.menuAbout.Text = "About...";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNew,
            this.toolOpen,
            this.toolSave,
            this.toolSaveAs,
            this.toolStripSeparator3,
            this.toolBold,
            this.toolItalics,
            this.toolUnderline,
            this.toolFontSize,
            this.toolStripSeparator4,
            this.toolUserName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1013, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStripTop";
            // 
            // toolNew
            // 
            this.toolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNew.Image = global::Assignment2.Properties.Resources.NewFile_16x;
            this.toolNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNew.Name = "toolNew";
            this.toolNew.Size = new System.Drawing.Size(23, 22);
            this.toolNew.Text = "New";
            this.toolNew.ToolTipText = "New";
            this.toolNew.Click += new System.EventHandler(this.toolNew_Click);
            // 
            // toolOpen
            // 
            this.toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOpen.Image = global::Assignment2.Properties.Resources.OpenFolder_16x;
            this.toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpen.Name = "toolOpen";
            this.toolOpen.Size = new System.Drawing.Size(23, 22);
            this.toolOpen.Text = "Open";
            this.toolOpen.Click += new System.EventHandler(this.toolOpen_Click);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = global::Assignment2.Properties.Resources.SaveStatusBar1_16x;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(23, 22);
            this.toolSave.Text = "Save";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolSaveAs
            // 
            this.toolSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSaveAs.Image = global::Assignment2.Properties.Resources.SaveAs_16x;
            this.toolSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSaveAs.Name = "toolSaveAs";
            this.toolSaveAs.Size = new System.Drawing.Size(23, 22);
            this.toolSaveAs.Text = "Save As";
            this.toolSaveAs.Click += new System.EventHandler(this.toolSaveAs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBold
            // 
            this.toolBold.CheckOnClick = true;
            this.toolBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBold.Image = global::Assignment2.Properties.Resources.Bold_16x;
            this.toolBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBold.Name = "toolBold";
            this.toolBold.Size = new System.Drawing.Size(23, 22);
            this.toolBold.Text = "Bold";
            this.toolBold.Click += new System.EventHandler(this.toolBold_Click);
            // 
            // toolItalics
            // 
            this.toolItalics.CheckOnClick = true;
            this.toolItalics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolItalics.Image = global::Assignment2.Properties.Resources.Italic_16x;
            this.toolItalics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolItalics.Name = "toolItalics";
            this.toolItalics.Size = new System.Drawing.Size(23, 22);
            this.toolItalics.Text = "Italics";
            this.toolItalics.Click += new System.EventHandler(this.toolItalics_Click);
            // 
            // toolUnderline
            // 
            this.toolUnderline.CheckOnClick = true;
            this.toolUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUnderline.Image = global::Assignment2.Properties.Resources.Underline_16x;
            this.toolUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUnderline.Name = "toolUnderline";
            this.toolUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolUnderline.Text = "Underline";
            this.toolUnderline.Click += new System.EventHandler(this.toolUnderline_Click);
            // 
            // toolFontSize
            // 
            this.toolFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.toolFontSize.Name = "toolFontSize";
            this.toolFontSize.Size = new System.Drawing.Size(121, 25);
            this.toolFontSize.ToolTipText = "Font Size";
            this.toolFontSize.SelectedIndexChanged += new System.EventHandler(this.toolFontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolUserName
            // 
            this.toolUserName.Name = "toolUserName";
            this.toolUserName.Size = new System.Drawing.Size(71, 22);
            this.toolUserName.Text = "User Name: ";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCut,
            this.toolCopy,
            this.toolPaste});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 618);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStripLeft";
            // 
            // toolCut
            // 
            this.toolCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCut.Image = global::Assignment2.Properties.Resources.Cut_16x;
            this.toolCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCut.Name = "toolCut";
            this.toolCut.Size = new System.Drawing.Size(21, 20);
            this.toolCut.Text = "Cut";
            this.toolCut.Click += new System.EventHandler(this.toolCut_Click);
            // 
            // toolCopy
            // 
            this.toolCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCopy.Image = global::Assignment2.Properties.Resources.Copy_16x;
            this.toolCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCopy.Name = "toolCopy";
            this.toolCopy.Size = new System.Drawing.Size(21, 20);
            this.toolCopy.Text = "Copy";
            this.toolCopy.Click += new System.EventHandler(this.toolCopy_Click);
            // 
            // toolPaste
            // 
            this.toolPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPaste.Image = global::Assignment2.Properties.Resources.Paste_16x;
            this.toolPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPaste.Name = "toolPaste";
            this.toolPaste.Size = new System.Drawing.Size(21, 20);
            this.toolPaste.Text = "Paste";
            this.toolPaste.Click += new System.EventHandler(this.toolPaste_Click);
            // 
            // richTxtBox
            // 
            this.richTxtBox.Location = new System.Drawing.Point(27, 52);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.Size = new System.Drawing.Size(974, 543);
            this.richTxtBox.TabIndex = 3;
            this.richTxtBox.Text = "";
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 667);
            this.ControlBox = false;
            this.Controls.Add(this.richTxtBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditorForm";
            this.Text = "Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolNew;
        private System.Windows.Forms.ToolStripButton toolOpen;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolBold;
        private System.Windows.Forms.ToolStripButton toolItalics;
        private System.Windows.Forms.ToolStripButton toolUnderline;
        private System.Windows.Forms.ToolStripComboBox toolFontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolUserName;
        private System.Windows.Forms.ToolStripButton toolCut;
        private System.Windows.Forms.ToolStripButton toolCopy;
        private System.Windows.Forms.ToolStripButton toolPaste;
        private System.Windows.Forms.RichTextBox richTxtBox;
    }
}