using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using Core;

namespace NoteIt
{
    public partial class MainForm : Form
    {
        private FindForm _findForm;
        private ReplaceForm _replaceForm;
        
        private (int line, int column) CaretPosition
        {
            get
            {
                var selectionStart = documentContentTextBox.SelectionStart;
                var line = documentContentTextBox.GetLineFromCharIndex(selectionStart);
                var column =
                    selectionStart - documentContentTextBox.GetFirstCharIndexFromLine(line);

                return (line, column);
            }
            set
            {
                var selectionStart =
                    documentContentTextBox.GetFirstCharIndexFromLine(value.line) + value.column;
                documentContentTextBox.Select(selectionStart, 0);
                documentContentTextBox.ScrollToCaret();
            }
        }

        private int LineIndex
        {
            get => CaretPosition.line;
            set
            {
                var destLineIndex = value;
                
                if (destLineIndex < 0)
                {
                    destLineIndex = 0;
                }
                
                if (destLineIndex >= documentContentTextBox.Lines.Length)
                {
                    destLineIndex = documentContentTextBox.Lines.Length - 1;
                }
                
                var charIndex = documentContentTextBox.GetFirstCharIndexFromLine(destLineIndex);
                SelectionStart = charIndex;
                CaretPosition = (destLineIndex, 0);
            }
        }

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

        public string SelectedText
        {
            get => documentContentTextBox.SelectedText;
            set
            {
                documentContentTextBox.SelectedText = value;
                IsDirty = true;
            }
        }

        private int SelectionLength
        {
            get => documentContentTextBox.SelectionLength;
            set => documentContentTextBox.SelectionLength = value;
        }

        private int SelectionStart
        {
            get => documentContentTextBox.SelectionStart;
            set
            {
                documentContentTextBox.SelectionStart = value;
                documentContentTextBox.ScrollToCaret();
            }
        }
        
        private int SelectionEnd => SelectionStart + SelectionLength;

        private string DocumentContent
        {
            get => documentContentTextBox.Text;
            set => documentContentTextBox.Text = value;
        }

        private Font DocumentFont
        {
            get => documentContentTextBox.Font;
            set => documentContentTextBox.Font = value;
        }

        private PageSettings _pageSettings;

        private PageSettings PageSettings
        {
            get
            {
                if (_pageSettings != null)
                {
                    return _pageSettings;
                }

                _pageSettings = new PageSettings { Margins = new Margins(75, 75, 100, 100) };

                return _pageSettings;
            }
            set => _pageSettings = value;
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

        private void UpdateStatusBar()
        {
            if (documentStatusLabel.Tag == null)
            {
                documentStatusLabel.Tag = documentStatusLabel.Text;
            }

            var (line, column) = CaretPosition;
            documentStatusLabel.Text = (documentStatusLabel.Tag as string).FormatUsingObject(
                new { LineNumber = line + 1, ColumnNumber = column + 1 }
            );
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
            else if (new FileInfo(Filename).IsReadOnly)
            {
                SaveAsFile();
                return;
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
        
        public bool FindAndSelect(string searchText, bool matchCase, bool bSearchDown)
        {
            var content = DocumentContent;
            var eStringComparison = matchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;
            var index = bSearchDown
                ? content.IndexOf(searchText, SelectionStart - 1, eStringComparison)
                : content.LastIndexOf(searchText, SelectionStart - 1, SelectionStart, eStringComparison);

            if (index == -1)
            {
                return false;
            }

            SelectionStart = index;
            SelectionLength = searchText.Length;
            return true;
        }
        
        public bool ReplaceAll(string searchText, string replaceText, bool matchCase)
        {
            var content = DocumentContent;
            var eStringComparison = matchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;
           
            if (!content.Contains(searchText))
            {
                return false;
            }
            
            DocumentContent = content.Replace(searchText, replaceText);
            return true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTitle();
            UpdateStatusBar();
            DocumentFont = new Font("Arial", 12);
            documentContentTextBox.WordWrap = wordWrapMenuItem.Checked = false;
            documentStatusBar.Visible = statusBarMenuItem.Checked = true;
            documentContentTextBox.BringToFront();
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            EnsureFileSaved();
            Filename = null;
            DocumentContent = string.Empty;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            EnsureFileSaved();
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

        private void pageSetupMenuItem_Click(object sender, EventArgs e)
        {
            var pageSetupDialog = new PageSetupDialog();
            pageSetupDialog.PageSettings = PageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                PageSettings = pageSetupDialog.PageSettings;
            }
        }

        private void documentContentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateStatusBar();
        }

        private void documentContentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpdateStatusBar();
        }

        private void documentContentTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateStatusBar();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void viewHelpMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(
                "https://www.google.com/search?q=get+help+for+notepad&rlz=1C1AVUC_enRO1015RO1015&oq=get+help+for+notepad&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIICAEQABgWGB4yBggCEEUYQDIGCAMQRRg80gEIMzAzNWowajeoAgCwAgA&sourceid=chrome&ie=UTF-8"
            );
        }

        private void fontMenuItem_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog { Font = DocumentFont };

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                DocumentFont = fontDialog.Font;
            }
        }

        private void wordWrapMenuItem_Click(object sender, EventArgs e)
        {
            documentContentTextBox.WordWrap = wordWrapMenuItem.Checked = !wordWrapMenuItem.Checked;
        }

        private void documentContentTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateStatusBar();
        }

        private void statusBarMenuItem_Click(object sender, EventArgs e)
        {
            documentStatusBar.Visible = statusBarMenuItem.Checked = !statusBarMenuItem.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EnsureFileSaved();
        }

        private void undoMenuItem_Click(object sender, EventArgs e)
        {
            documentContentTextBox.Undo();
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            documentContentTextBox.Cut();
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            documentContentTextBox.Copy();
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            documentContentTextBox.Paste();
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectionLength == 0)
            {
                SelectionLength = 1;
            }

            documentContentTextBox.SelectedText = string.Empty;
        }

        private void selectAllMenuItem_Click(object sender, EventArgs e)
        {
            documentContentTextBox.SelectAll();
        }

        private void timeDateMenuItem_Click(object sender, EventArgs e)
        {
            SelectedText = $"{DateTime.Now.ToShortTimeString()} {DateTime.Now.ToShortDateString()}";
        }

        private void gotoMenuItem_Click(object sender, EventArgs e)
        {
            var gotoForm = new GoToLineForm(LineIndex + 1, documentContentTextBox.Lines.Length);
            gotoForm.Left = Left + 10;
            gotoForm.Top = Top + 50;

            if (gotoForm.ShowDialog() != DialogResult.OK)
                return;
            
            LineIndex = gotoForm.LineNumber - 1;
        }

        private void findMenuItem_Click(object sender, EventArgs e)
        {
            if (_findForm == null)
            {
                _findForm = new FindForm(this);
            }

            _findForm.Left = Left + 10;
            _findForm.Top = Top + 50;

            _findForm.Show();
        }

        private void replaceMenuItem_Click(object sender, EventArgs e)
        {
            if (_replaceForm == null)
            {
                _replaceForm = new ReplaceForm(this);
            }

            _replaceForm.Left = Left + 10;
            _replaceForm.Top = Top + 50;
            
            _replaceForm.Show();
        }
    }
}
