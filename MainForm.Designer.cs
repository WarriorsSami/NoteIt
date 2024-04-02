using System.ComponentModel;

namespace NoteIt
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.findMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPreviousMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeDateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentContentTextBox = new System.Windows.Forms.TextBox();
            this.documentStatusBar = new System.Windows.Forms.StatusStrip();
            this.documentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu.SuspendLayout();
            this.documentStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.AutoSize = false;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileSubmenu, this.editSubmenu, this.formatSubmenu, this.viewSubmenu, this.helpSubmenu });
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainMenu.Size = new System.Drawing.Size(1081, 26);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.TabStop = true;
            // 
            // fileSubmenu
            // 
            this.fileSubmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.newMenuItem, this.newWindowMenuItem, this.openMenuItem, this.saveMenuItem, this.toolStripSeparator1, this.saveAsMenuItem, this.pageSetupMenuItem, this.toolStripSeparator2, this.exitMenuItem });
            this.fileSubmenu.Name = "fileSubmenu";
            this.fileSubmenu.Size = new System.Drawing.Size(44, 22);
            this.fileSubmenu.Text = "&File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuItem.Size = new System.Drawing.Size(260, 24);
            this.newMenuItem.Text = "&New";
            this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
            // 
            // newWindowMenuItem
            // 
            this.newWindowMenuItem.Name = "newWindowMenuItem";
            this.newWindowMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.N)));
            this.newWindowMenuItem.Size = new System.Drawing.Size(260, 24);
            this.newWindowMenuItem.Text = "New &Window";
            this.newWindowMenuItem.Click += new System.EventHandler(this.newWindowMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(260, 24);
            this.openMenuItem.Text = "&Open...";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(260, 24);
            this.saveMenuItem.Text = "&Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.S)));
            this.saveAsMenuItem.Size = new System.Drawing.Size(260, 24);
            this.saveAsMenuItem.Text = "Save &As...";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // pageSetupMenuItem
            // 
            this.pageSetupMenuItem.Name = "pageSetupMenuItem";
            this.pageSetupMenuItem.Size = new System.Drawing.Size(260, 24);
            this.pageSetupMenuItem.Text = "Page Set&up...";
            this.pageSetupMenuItem.Click += new System.EventHandler(this.pageSetupMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(257, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(260, 24);
            this.exitMenuItem.Text = "&Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editSubmenu
            // 
            this.editSubmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.undoMenuItem, this.toolStripSeparator3, this.cutMenuItem, this.copyMenuItem, this.pasteMenuItem, this.deleteMenuItem, this.toolStripSeparator4, this.findMenuItem, this.findNextMenuItem, this.findPreviousMenuItem, this.replaceMenuItem, this.gotoMenuItem, this.toolStripSeparator5, this.selectAllMenuItem, this.timeDateMenuItem });
            this.editSubmenu.Name = "editSubmenu";
            this.editSubmenu.Size = new System.Drawing.Size(47, 22);
            this.editSubmenu.Text = "&Edit";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem.Size = new System.Drawing.Size(229, 24);
            this.undoMenuItem.Text = "&Undo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(226, 6);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenuItem.Size = new System.Drawing.Size(229, 24);
            this.cutMenuItem.Text = "Cu&t";
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuItem.Size = new System.Drawing.Size(229, 24);
            this.copyMenuItem.Text = "&Copy";
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuItem.Size = new System.Drawing.Size(229, 24);
            this.pasteMenuItem.Text = "&Paste";
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteMenuItem.Size = new System.Drawing.Size(229, 24);
            this.deleteMenuItem.Text = "De&lete";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(226, 6);
            // 
            // findMenuItem
            // 
            this.findMenuItem.Name = "findMenuItem";
            this.findMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findMenuItem.Size = new System.Drawing.Size(229, 24);
            this.findMenuItem.Text = "&Find...";
            // 
            // findNextMenuItem
            // 
            this.findNextMenuItem.Name = "findNextMenuItem";
            this.findNextMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.findNextMenuItem.Size = new System.Drawing.Size(229, 24);
            this.findNextMenuItem.Text = "Find &Next";
            // 
            // findPreviousMenuItem
            // 
            this.findPreviousMenuItem.Name = "findPreviousMenuItem";
            this.findPreviousMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.findPreviousMenuItem.Size = new System.Drawing.Size(229, 24);
            this.findPreviousMenuItem.Text = "Fi&nd Previous";
            // 
            // replaceMenuItem
            // 
            this.replaceMenuItem.Name = "replaceMenuItem";
            this.replaceMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceMenuItem.Size = new System.Drawing.Size(229, 24);
            this.replaceMenuItem.Text = "&Replace...";
            // 
            // gotoMenuItem
            // 
            this.gotoMenuItem.Name = "gotoMenuItem";
            this.gotoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gotoMenuItem.Size = new System.Drawing.Size(229, 24);
            this.gotoMenuItem.Text = "&Go To...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(226, 6);
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            this.selectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMenuItem.Size = new System.Drawing.Size(229, 24);
            this.selectAllMenuItem.Text = "Select &All";
            // 
            // timeDateMenuItem
            // 
            this.timeDateMenuItem.Name = "timeDateMenuItem";
            this.timeDateMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.timeDateMenuItem.Size = new System.Drawing.Size(229, 24);
            this.timeDateMenuItem.Text = "Time/&Date";
            // 
            // formatSubmenu
            // 
            this.formatSubmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.wordWrapMenuItem, this.fontMenuItem });
            this.formatSubmenu.Name = "formatSubmenu";
            this.formatSubmenu.Size = new System.Drawing.Size(68, 22);
            this.formatSubmenu.Text = "F&ormat";
            // 
            // wordWrapMenuItem
            // 
            this.wordWrapMenuItem.Name = "wordWrapMenuItem";
            this.wordWrapMenuItem.Size = new System.Drawing.Size(154, 24);
            this.wordWrapMenuItem.Text = "&Word Wrap";
            this.wordWrapMenuItem.Click += new System.EventHandler(this.wordWrapMenuItem_Click);
            // 
            // fontMenuItem
            // 
            this.fontMenuItem.Name = "fontMenuItem";
            this.fontMenuItem.Size = new System.Drawing.Size(154, 24);
            this.fontMenuItem.Text = "&Font...";
            this.fontMenuItem.Click += new System.EventHandler(this.fontMenuItem_Click);
            // 
            // viewSubmenu
            // 
            this.viewSubmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.statusBarMenuItem });
            this.viewSubmenu.Name = "viewSubmenu";
            this.viewSubmenu.Size = new System.Drawing.Size(53, 22);
            this.viewSubmenu.Text = "&View";
            // 
            // statusBarMenuItem
            // 
            this.statusBarMenuItem.Name = "statusBarMenuItem";
            this.statusBarMenuItem.Size = new System.Drawing.Size(144, 24);
            this.statusBarMenuItem.Text = "&Status Bar";
            this.statusBarMenuItem.Click += new System.EventHandler(this.statusBarMenuItem_Click);
            // 
            // helpSubmenu
            // 
            this.helpSubmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.viewHelpMenuItem, this.aboutMenuItem });
            this.helpSubmenu.Name = "helpSubmenu";
            this.helpSubmenu.Size = new System.Drawing.Size(53, 22);
            this.helpSubmenu.Text = "&Help";
            // 
            // viewHelpMenuItem
            // 
            this.viewHelpMenuItem.Name = "viewHelpMenuItem";
            this.viewHelpMenuItem.Size = new System.Drawing.Size(146, 24);
            this.viewHelpMenuItem.Text = "View &Help";
            this.viewHelpMenuItem.Click += new System.EventHandler(this.viewHelpMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(146, 24);
            this.aboutMenuItem.Text = "&About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // documentContentTextBox
            // 
            this.documentContentTextBox.AcceptsReturn = true;
            this.documentContentTextBox.AcceptsTab = true;
            this.documentContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentContentTextBox.HideSelection = false;
            this.documentContentTextBox.Location = new System.Drawing.Point(0, 26);
            this.documentContentTextBox.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.documentContentTextBox.MaxLength = 0;
            this.documentContentTextBox.Multiline = true;
            this.documentContentTextBox.Name = "documentContentTextBox";
            this.documentContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.documentContentTextBox.Size = new System.Drawing.Size(1081, 651);
            this.documentContentTextBox.TabIndex = 1;
            this.documentContentTextBox.WordWrap = false;
            this.documentContentTextBox.TextChanged += new System.EventHandler(this.documentContentTextBox_TextChanged);
            this.documentContentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.documentContentTextBox_KeyDown);
            this.documentContentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.documentContentTextBox_KeyPress);
            this.documentContentTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.documentContentTextBox_KeyUp);
            this.documentContentTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.documentContentTextBox_MouseDown);
            // 
            // documentStatusBar
            // 
            this.documentStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.documentStatusLabel });
            this.documentStatusBar.Location = new System.Drawing.Point(0, 652);
            this.documentStatusBar.Name = "documentStatusBar";
            this.documentStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.documentStatusBar.Size = new System.Drawing.Size(1081, 25);
            this.documentStatusBar.SizingGrip = false;
            this.documentStatusBar.TabIndex = 2;
            // 
            // documentStatusLabel
            // 
            this.documentStatusLabel.Name = "documentStatusLabel";
            this.documentStatusLabel.Size = new System.Drawing.Size(267, 20);
            this.documentStatusLabel.Text = "Ln {LineNumber}, Col {ColumnNumber}";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1081, 677);
            this.Controls.Add(this.documentStatusBar);
            this.Controls.Add(this.documentContentTextBox);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.Text = "{DocumentName} - NoteIt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.documentStatusBar.ResumeLayout(false);
            this.documentStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripStatusLabel documentStatusLabel;

        private System.Windows.Forms.StatusStrip documentStatusBar;

        private System.Windows.Forms.TextBox documentContentTextBox;

        private System.Windows.Forms.ToolStripMenuItem viewHelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;

        private System.Windows.Forms.ToolStripMenuItem wordWrapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarMenuItem;

        private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeDateMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

        private System.Windows.Forms.ToolStripMenuItem gotoMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem findMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPreviousMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceMenuItem;

        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;

        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;

        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;

        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripMenuItem pageSetupMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;

        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;

        private System.Windows.Forms.ToolStripMenuItem openMenuItem;

        private System.Windows.Forms.ToolStripMenuItem newWindowMenuItem;

        private System.Windows.Forms.ToolStripMenuItem newMenuItem;

        private System.Windows.Forms.ToolStripMenuItem helpSubmenu;

        private System.Windows.Forms.ToolStripMenuItem editSubmenu;
        private System.Windows.Forms.ToolStripMenuItem formatSubmenu;
        private System.Windows.Forms.ToolStripMenuItem viewSubmenu;

        private System.Windows.Forms.ToolStripMenuItem fileSubmenu;

        private System.Windows.Forms.MenuStrip mainMenu;

        #endregion
    }
}