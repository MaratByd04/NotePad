using System.Drawing.Printing;

namespace Блокнот
{
    public partial class Form1 : Form
    {
        public string filename;
        public bool isFileChanged;

        public PrintDocument printDocument = new PrintDocument();

        public Form1()
        {
            InitializeComponent();

            Init();

            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
        }

        /// <summary>
        /// Методы для адекватной печати 
        /// проверить не выйдет, но вкладка печати появляется 
        /// </summary>
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = richTextBox1.Font;
            Brush brush = Brushes.Black;

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            e.Graphics.DrawString(richTextBox1.Text, font, brush, x, y);
            e.HasMorePages = false;
        }
        private void PrintDocument(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void Print(object sender, EventArgs e)
        {
            PrintDocument(null, null);
        }

        public void Init()
        {
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }

        public void CreateNewDocument(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            richTextBox1.Text = "";
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }

        public void OpenFile(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                    isFileChanged = false;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл");
                }
                UpdateTextWithTitle();
            }
        }

        public void SaveFile(string _filename)
        {
            if (_filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_filename);
                sw.Write(richTextBox1.Text);
                sw.Close();
                filename = _filename;
                isFileChanged = false;
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить файл");
            }
            UpdateTextWithTitle();
        }

        public void Save(object sender, EventArgs e)
        {
            SaveFile(filename);
        }
        public void SaveAs(object sender, EventArgs e)
        {
            SaveFile("");
        }
        private void OnTextChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                isFileChanged = true;
            }
        }
        public void UpdateTextWithTitle()
        {
            if (filename != "")
            {
                this.Text = filename + " - Блокнот";
            }
            else
            {
                this.Text = filename + "Безымянный - Блокнот";
            }
        }

        public void SaveUnsavedFile()
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения в файле?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        }

        public void CopyText()
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }
        public void CutText()
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
        }
        public void PasteText()
        {
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart) + Clipboard.GetText() + richTextBox1.Text.Substring(richTextBox1.SelectionStart, richTextBox1.Text.Length - richTextBox1.SelectionStart);
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            CopyText();
        }

        private void OnCutClick(object sender, EventArgs e)
        {
            CutText();
        }

        private void OnPasteClick(object sender, EventArgs e)
        {
            PasteText();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsavedFile();
        }

        private void OnPrint(object sender, EventArgs e)
        {
            Print(sender, e);
        }

        private void OnChangeColor(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void OnChangeFont(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }
    }
}