using System.ComponentModel;

namespace NoteIt
{
    partial class GoToLineForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoToLineForm));
            this.lineNumberLabel = new System.Windows.Forms.Label();
            this.lineNumberTextBox = new System.Windows.Forms.TextBox();
            this.gotoButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.lineNumberToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lineNumberLabel
            // 
            this.lineNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineNumberLabel.Location = new System.Drawing.Point(12, 21);
            this.lineNumberLabel.Name = "lineNumberLabel";
            this.lineNumberLabel.Size = new System.Drawing.Size(150, 23);
            this.lineNumberLabel.TabIndex = 0;
            this.lineNumberLabel.Text = "Line number:";
            // 
            // lineNumberTextBox
            // 
            this.lineNumberTextBox.Location = new System.Drawing.Point(12, 47);
            this.lineNumberTextBox.Name = "lineNumberTextBox";
            this.lineNumberTextBox.Size = new System.Drawing.Size(447, 22);
            this.lineNumberTextBox.TabIndex = 1;
            this.lineNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lineNumberTextBox_KeyPress);
            // 
            // gotoButton
            // 
            this.gotoButton.Location = new System.Drawing.Point(229, 90);
            this.gotoButton.Name = "gotoButton";
            this.gotoButton.Size = new System.Drawing.Size(101, 28);
            this.gotoButton.TabIndex = 2;
            this.gotoButton.Text = "Go To";
            this.gotoButton.UseVisualStyleBackColor = true;
            this.gotoButton.Click += new System.EventHandler(this.gotoButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(358, 90);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 28);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // GoToLineForm
            // 
            this.AcceptButton = this.gotoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(471, 140);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.gotoButton);
            this.Controls.Add(this.lineNumberTextBox);
            this.Controls.Add(this.lineNumberLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GoToLineForm";
            this.Text = "Go To Line";
            this.Load += new System.EventHandler(this.GoToLineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolTip lineNumberToolTip;

        private System.Windows.Forms.TextBox lineNumberTextBox;
        private System.Windows.Forms.Button gotoButton;
        private System.Windows.Forms.Button cancelButton;

        private System.Windows.Forms.Label lineNumberLabel;

        #endregion
    }
}