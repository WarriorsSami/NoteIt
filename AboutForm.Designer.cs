using System.ComponentModel;

namespace NoteIt
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.aboutImage = new System.Windows.Forms.PictureBox();
            this.aboutTitle = new System.Windows.Forms.Label();
            this.aboutDescription = new System.Windows.Forms.Label();
            this.aboutAuthorName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.aboutImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel2.Controls.Add(this.aboutAuthorName);
            this.splitContainer1.Panel2.Controls.Add(this.aboutDescription);
            this.splitContainer1.Panel2.Controls.Add(this.aboutTitle);
            this.splitContainer1.Size = new System.Drawing.Size(704, 333);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 1;
            // 
            // aboutImage
            // 
            this.aboutImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.aboutImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutImage.Image = ((System.Drawing.Image)(resources.GetObject("aboutImage.Image")));
            this.aboutImage.InitialImage = null;
            this.aboutImage.Location = new System.Drawing.Point(0, 0);
            this.aboutImage.Name = "aboutImage";
            this.aboutImage.Size = new System.Drawing.Size(280, 333);
            this.aboutImage.TabIndex = 0;
            this.aboutImage.TabStop = false;
            // 
            // aboutTitle
            // 
            this.aboutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTitle.Location = new System.Drawing.Point(29, 30);
            this.aboutTitle.Name = "aboutTitle";
            this.aboutTitle.Size = new System.Drawing.Size(215, 52);
            this.aboutTitle.TabIndex = 0;
            this.aboutTitle.Text = "NoteIt";
            // 
            // aboutDescription
            // 
            this.aboutDescription.Location = new System.Drawing.Point(29, 94);
            this.aboutDescription.Name = "aboutDescription";
            this.aboutDescription.Size = new System.Drawing.Size(379, 50);
            this.aboutDescription.TabIndex = 1;
            this.aboutDescription.Text = "A Notepad clone implemented using .NET Framework 4.8 WinForms.";
            // 
            // aboutAuthorName
            // 
            this.aboutAuthorName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.aboutAuthorName.Location = new System.Drawing.Point(29, 144);
            this.aboutAuthorName.Name = "aboutAuthorName";
            this.aboutAuthorName.Size = new System.Drawing.Size(155, 38);
            this.aboutAuthorName.TabIndex = 2;
            this.aboutAuthorName.Text = "by Sami Barbut-Dica";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(704, 333);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AboutForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aboutImage)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label aboutDescription;
        private System.Windows.Forms.Label aboutAuthorName;

        private System.Windows.Forms.Label aboutTitle;

        private System.Windows.Forms.PictureBox aboutImage;

        private System.Windows.Forms.SplitContainer splitContainer1;

        #endregion
    }
}