using System;
using System.Windows.Forms;

namespace NoteIt
{
    public partial class ReplaceForm : Form
    {
        private MainForm _MainForm;
        
        public ReplaceForm(MainForm mainForm)
        {
            InitializeComponent();
            _MainForm = mainForm;
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
    }
}