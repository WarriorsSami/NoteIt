using System;
using System.IO;
using System.Windows.Forms;
using Core;

namespace NoteIt
{
    public partial class MainForm : Form
    {
        private bool _isDirty;

        private bool IsDirty
        {
            get
            {
                if (Filename == null && DocumentContent.IsEmpty())
                {
                    return false;
                }

                return _isDirty;
            }
            set
            {
                _isDirty = value;
                UpdateTitle();
            }
        }

        private string _filename;

        private string Filename
        {
            get => _filename;
            set
            {
                _filename = value;
                UpdateTitle();
            }
        }

        private string DocumentName => Filename == null ? "Untitled" : Path.GetFileName(Filename);

        private string DocumentContent
        {
            get => documentContentTextBox.Text;
            set => documentContentTextBox.Text = value;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateTitle()
        {
            if (Tag == null)
            {
                Tag = base.Text;
            }

            if (IsDirty)
            {
                base.Text = $@"{DocumentName}* - NoteIt";
                return;
            }

            base.Text = (Tag as string).FormatUsingObject(new { DocumentName });
        }

        private void EnsureFileSaved()
        {
            if (!IsDirty)
                return;

            var result = MessageBox.Show(
                @"Do you want to save the changes you made to this document?",
                @"NoteIt",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation
            );

            switch (result)
            {
                case DialogResult.Yes:
                    SaveFile();
                    break;
                case DialogResult.No:
                case DialogResult.Cancel:
                    break; 
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                FilterIndex = 1
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            Filename = openFileDialog.FileName;
            DocumentContent = File.ReadAllText(Filename);
            IsDirty = false;
        }
        
        private void SaveFile()
        {
            if (Filename == null)
            {
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = @"Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                    FilterIndex = 1
                };

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                Filename = saveFileDialog.FileName;
            }

            File.WriteAllText(Filename, DocumentContent);
            IsDirty = false;
        }
        
        private void SaveAsFile()
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = @"Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                FilterIndex = 1
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            Filename = saveFileDialog.FileName;
            File.WriteAllText(Filename, DocumentContent);
            IsDirty = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTitle();
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            EnsureFileSaved();
            Filename = null;
            DocumentContent = string.Empty;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newWindowMenuItem_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            EnsureFileSaved();
            OpenFile();
        }

        private void documentContentTextBox_TextChanged(object sender, EventArgs e)
        {
            IsDirty = true;
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }
    }
}
