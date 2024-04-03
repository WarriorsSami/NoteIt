using System.ComponentModel;

namespace NoteIt
{
    partial class FindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindForm));
            this.findWhatLabel = new System.Windows.Forms.Label();
            this.findWhatTextBox = new System.Windows.Forms.TextBox();
            this.findNextButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.directionGroupBox = new System.Windows.Forms.GroupBox();
            this.downRadioButton = new System.Windows.Forms.RadioButton();
            this.upRadioButton = new System.Windows.Forms.RadioButton();
            this.directionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // findWhatLabel
            // 
            this.findWhatLabel.Location = new System.Drawing.Point(24, 33);
            this.findWhatLabel.Name = "findWhatLabel";
            this.findWhatLabel.Size = new System.Drawing.Size(86, 22);
            this.findWhatLabel.TabIndex = 0;
            this.findWhatLabel.Text = "Find what:";
            // 
            // findWhatTextBox
            // 
            this.findWhatTextBox.Location = new System.Drawing.Point(116, 33);
            this.findWhatTextBox.Name = "findWhatTextBox";
            this.findWhatTextBox.Size = new System.Drawing.Size(380, 22);
            this.findWhatTextBox.TabIndex = 1;
            // 
            // findNextButton
            // 
            this.findNextButton.Location = new System.Drawing.Point(522, 25);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(113, 30);
            this.findNextButton.TabIndex = 2;
            this.findNextButton.Text = "Find Next";
            this.findNextButton.UseVisualStyleBackColor = true;
            this.findNextButton.Click += new System.EventHandler(this.findNextButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(522, 74);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 28);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.Location = new System.Drawing.Point(24, 108);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(137, 30);
            this.matchCaseCheckBox.TabIndex = 4;
            this.matchCaseCheckBox.Text = "Match case";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // directionGroupBox
            // 
            this.directionGroupBox.Controls.Add(this.downRadioButton);
            this.directionGroupBox.Controls.Add(this.upRadioButton);
            this.directionGroupBox.Location = new System.Drawing.Point(350, 93);
            this.directionGroupBox.Name = "directionGroupBox";
            this.directionGroupBox.Size = new System.Drawing.Size(146, 53);
            this.directionGroupBox.TabIndex = 6;
            this.directionGroupBox.TabStop = false;
            this.directionGroupBox.Text = "Direction";
            // 
            // downRadioButton
            // 
            this.downRadioButton.Location = new System.Drawing.Point(70, 21);
            this.downRadioButton.Name = "downRadioButton";
            this.downRadioButton.Size = new System.Drawing.Size(76, 24);
            this.downRadioButton.TabIndex = 1;
            this.downRadioButton.TabStop = true;
            this.downRadioButton.Text = "Down";
            this.downRadioButton.UseVisualStyleBackColor = true;
            // 
            // upRadioButton
            // 
            this.upRadioButton.Location = new System.Drawing.Point(6, 21);
            this.upRadioButton.Name = "upRadioButton";
            this.upRadioButton.Size = new System.Drawing.Size(62, 24);
            this.upRadioButton.TabIndex = 0;
            this.upRadioButton.TabStop = true;
            this.upRadioButton.Text = "Up";
            this.upRadioButton.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AcceptButton = this.findNextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(647, 172);
            this.Controls.Add(this.directionGroupBox);
            this.Controls.Add(this.matchCaseCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.findWhatTextBox);
            this.Controls.Add(this.findWhatLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindForm";
            this.Text = "Find";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.directionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton upRadioButton;
        private System.Windows.Forms.RadioButton downRadioButton;

        private System.Windows.Forms.Label findWhatLabel;
        private System.Windows.Forms.TextBox findWhatTextBox;
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
        private System.Windows.Forms.GroupBox directionGroupBox;

        #endregion
    }
}