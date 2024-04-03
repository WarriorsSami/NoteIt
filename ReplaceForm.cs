using System;
using System.Windows.Forms;

namespace NoteIt
{
    public partial class ReplaceForm : Form
    {
        private readonly MainForm _mainForm;

        public ReplaceForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void ReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
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

            if (!_mainForm.FindAndSelect(searchText, matchCase, true))
            {
                MessageBox.Show(this, @"Cannot find the text you are looking for.", @"NoteIt");
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            var searchText = findWhatTextBox.Text;
            var replaceText = replaceWithTextBox.Text;
            var matchCase = matchCaseCheckBox.Checked;

            if (_mainForm.SelectedText == searchText)
            {
                _mainForm.SelectedText = replaceText;
            }

            if (!_mainForm.FindAndSelect(replaceText, matchCase, true))
            {
                MessageBox.Show(this, @"Cannot find the text you are looking for.", @"NoteIt");
            }
        }

        private void ReplaceForm_Load(object sender, EventArgs e)
        {
            findWhatTextBox.Text = _mainForm.SelectedText;
            findWhatTextBox.SelectAll();
        }

        private void replaceAllButton_Click(object sender, EventArgs e)
        {
            var searchText = findWhatTextBox.Text;
            var replaceText = replaceWithTextBox.Text;
            var matchCase = matchCaseCheckBox.Checked;

            if (!_mainForm.ReplaceAll(searchText, replaceText, matchCase))
            {
                MessageBox.Show(this, @"Cannot find the text you are looking for.", @"NoteIt");
            }
        }
    }
}
