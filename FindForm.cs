using System;
using System.Windows.Forms;

namespace NoteIt
{
    public partial class FindForm : Form
    {
        private MainForm _MainForm;
        
        public FindForm(MainForm mainForm)
        {
            InitializeComponent();
            _MainForm = mainForm;
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

            if (!_MainForm.FindAndSelect(searchText, matchCase, bSearchDown))
            {
                MessageBox.Show(this, @"Cannot find the text you are looking for.", @"NoteIt");
            }
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            downRadioButton.Checked = true;
            findWhatTextBox.Text = _MainForm.SelectedText;
            findWhatTextBox.SelectAll();
        }
    }
}