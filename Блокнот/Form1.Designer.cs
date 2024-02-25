namespace Блокнот
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            новыйДокументToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem1 = new ToolStripMenuItem();
            печатьToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            форматToolStripMenuItem = new ToolStripMenuItem();
            цветToolStripMenuItem = new ToolStripMenuItem();
            изменитьШрифтToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.None;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, форматToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(218, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новыйДокументToolStripMenuItem, открытьToolStripMenuItem, сохранитьКакToolStripMenuItem, сохранитьКакToolStripMenuItem1, печатьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйДокументToolStripMenuItem
            // 
            новыйДокументToolStripMenuItem.Name = "новыйДокументToolStripMenuItem";
            новыйДокументToolStripMenuItem.Size = new Size(209, 26);
            новыйДокументToolStripMenuItem.Text = "Новый документ";
            новыйДокументToolStripMenuItem.Click += CreateNewDocument;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(209, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += OpenFile;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(209, 26);
            сохранитьКакToolStripMenuItem.Text = "Сохранить ";
            сохранитьКакToolStripMenuItem.Click += Save;
            // 
            // сохранитьКакToolStripMenuItem1
            // 
            сохранитьКакToolStripMenuItem1.Name = "сохранитьКакToolStripMenuItem1";
            сохранитьКакToolStripMenuItem1.Size = new Size(209, 26);
            сохранитьКакToolStripMenuItem1.Text = "Сохранить как";
            сохранитьКакToolStripMenuItem1.Click += SaveAs;
            // 
            // печатьToolStripMenuItem
            // 
            печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            печатьToolStripMenuItem.Size = new Size(209, 26);
            печатьToolStripMenuItem.Text = "Печать";
            печатьToolStripMenuItem.Click += OnPrint;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { копироватьToolStripMenuItem, вырезатьToolStripMenuItem, вставитьToolStripMenuItem });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(74, 24);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size = new Size(176, 26);
            копироватьToolStripMenuItem.Text = "Копировать";
            копироватьToolStripMenuItem.Click += OnCopyClick;
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.Size = new Size(176, 26);
            вырезатьToolStripMenuItem.Text = "Вырезать ";
            вырезатьToolStripMenuItem.Click += OnCutClick;
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(176, 26);
            вставитьToolStripMenuItem.Text = "Вставить";
            вставитьToolStripMenuItem.Click += OnPasteClick;
            // 
            // форматToolStripMenuItem
            // 
            форматToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { цветToolStripMenuItem, изменитьШрифтToolStripMenuItem });
            форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            форматToolStripMenuItem.Size = new Size(77, 24);
            форматToolStripMenuItem.Text = "Формат";
            // 
            // цветToolStripMenuItem
            // 
            цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            цветToolStripMenuItem.Size = new Size(224, 26);
            цветToolStripMenuItem.Text = "Цвет";
            цветToolStripMenuItem.Click += OnChangeColor;
            // 
            // изменитьШрифтToolStripMenuItem
            // 
            изменитьШрифтToolStripMenuItem.Name = "изменитьШрифтToolStripMenuItem";
            изменитьШрифтToolStripMenuItem.Size = new Size(224, 26);
            изменитьШрифтToolStripMenuItem.Text = "Изменить шрифт";
            изменитьШрифтToolStripMenuItem.Click += OnChangeFont;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 31);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 418);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Блокнот";
            FormClosing += OnFormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem новыйДокументToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem форматToolStripMenuItem;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem цветToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem изменитьШрифтToolStripMenuItem;
    }
}