using System;
using System.Windows.Forms;
using Core;

namespace NoteIt
{
    public partial class GoToLineForm : Form
    {
        public int LineNumber { get; private set; }
        
        private int LineCount { get; set; }
        
        public GoToLineForm(int lineNumber, int lineCount)
        {
            InitializeComponent();
            LineNumber = lineNumber;
            LineCount = lineCount;
            lineNumberTextBox.Text = LineNumber.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GoToLineForm_Load(object sender, EventArgs e)
        {
            lineNumberTextBox.SelectAll();
        }

        private void gotoButton_Click(object sender, EventArgs e)
        {
            if (lineNumberTextBox.Text.IsEmpty())
            {
                MessageBox.Show(this, @"You must enter a value.", @"NoteIt - Go to Line");
                return;
            }

            var potentialLineNumber = int.Parse(lineNumberTextBox.Text);

            if (potentialLineNumber == 0)
            {
                MessageBox.Show(this, @"Zero (0) is not a valid line number, line numbers start at 1.", @"NoteIt - Go to Line");
                return;
            }
            
            if (potentialLineNumber > LineCount)
            {
                MessageBox.Show(this, @"The line number is greater than the total number of lines.", @"NoteIt - Go to Line");
                return;
            }

            LineNumber = potentialLineNumber;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lineNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b') return;
            
            var senderTextBox = (TextBox)sender;
            lineNumberToolTip.Show(@"Unacceptable Character - You can only type a number here.", senderTextBox);
            e.Handled = true;
        }
    }
}