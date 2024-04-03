using System.ComponentModel;

namespace NoteIt
{
    partial class ReplaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.findNextButton = new System.Windows.Forms.Button();
            this.findWhatTextBox = new System.Windows.Forms.TextBox();
            this.findWhatLabel = new System.Windows.Forms.Label();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceWithTextBox = new System.Windows.Forms.TextBox();
            this.replaceWithLabel = new System.Windows.Forms.Label();
            this.replaceButton = new System.Windows.Forms.Button();
            this.replaceAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(569, 169);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 28);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // findNextButton
            // 
            this.findNextButton.Location = new System.Drawing.Point(569, 21);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(113, 30);
            this.findNextButton.TabIndex = 9;
            this.findNextButton.Text = "Find Next";
            this.findNextButton.UseVisualStyleBackColor = true;
            // 
            // findWhatTextBox
            // 
            this.findWhatTextBox.Location = new System.Drawing.Point(149, 29);
            this.findWhatTextBox.Name = "findWhatTextBox";
            this.findWhatTextBox.Size = new System.Drawing.Size(380, 22);
            this.findWhatTextBox.TabIndex = 8;
            // 
            // findWhatLabel
            // 
            this.findWhatLabel.Location = new System.Drawing.Point(25, 29);
            this.findWhatLabel.Name = "findWhatLabel";
            this.findWhatLabel.Size = new System.Drawing.Size(86, 22);
            this.findWhatLabel.TabIndex = 7;
            this.findWhatLabel.Text = "Find what:";
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.Location = new System.Drawing.Point(22, 169);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(121, 28);
            this.matchCaseCheckBox.TabIndex = 11;
            this.matchCaseCheckBox.Text = "Match case";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceWithTextBox
            // 
            this.replaceWithTextBox.Location = new System.Drawing.Point(149, 79);
            this.replaceWithTextBox.Name = "replaceWithTextBox";
            this.replaceWithTextBox.Size = new System.Drawing.Size(380, 22);
            this.replaceWithTextBox.TabIndex = 15;
            // 
            // replaceWithLabel
            // 
            this.replaceWithLabel.Location = new System.Drawing.Point(25, 79);
            this.replaceWithLabel.Name = "replaceWithLabel";
            this.replaceWithLabel.Size = new System.Drawing.Size(105, 22);
            this.replaceWithLabel.TabIndex = 14;
            this.replaceWithLabel.Text = "Repalce with:";
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(569, 72);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(113, 30);
            this.replaceButton.TabIndex = 16;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            // 
            // replaceAllButton
            // 
            this.replaceAllButton.Location = new System.Drawing.Point(569, 121);
            this.replaceAllButton.Name = "replaceAllButton";
            this.replaceAllButton.Size = new System.Drawing.Size(113, 30);
            this.replaceAllButton.TabIndex = 17;
            this.replaceAllButton.Text = "Replace All";
            this.replaceAllButton.UseVisualStyleBackColor = true;
            // 
            // ReplaceForm
            // 
            this.AcceptButton = this.findNextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(711, 231);
            this.Controls.Add(this.replaceAllButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.replaceWithTextBox);
            this.Controls.Add(this.replaceWithLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.findWhatTextBox);
            this.Controls.Add(this.findWhatLabel);
            this.Controls.Add(this.matchCaseCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReplaceForm";
            this.Text = "Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button replaceAllButton;

        private System.Windows.Forms.TextBox replaceWithTextBox;
        private System.Windows.Forms.Label replaceWithLabel;

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.TextBox findWhatTextBox;
        private System.Windows.Forms.Label findWhatLabel;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;

        #endregion
    }
}