using System;
using System.Windows.Forms;

namespace NoteIt
{
    public partial class FindForm : Form
    {
        private readonly MainForm _mainForm;
        
        public FindForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void findNextButton_Click(object sender, EventArgs e)
        {
            var searchText = findWhatTextBox.Text;
            var matchCase = matchCaseCheckBox.Checked;
            var bSearchDown = downRadioButton.Checked;

            if (!_mainForm.FindAndSelect(searchText, matchCase, bSearchDown))
            {
                MessageBox.Show(this, @"Cannot find the text you are looking for.", @"NoteIt");
            }
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            downRadioButton.Checked = true;
            findWhatTextBox.Text = _mainForm.SelectedText;
            findWhatTextBox.SelectAll();
        }
    }
}