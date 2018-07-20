namespace CourseWorkWindowsForms
{
    partial class LibraryForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.LibBooksListBox = new System.Windows.Forms.ListBox();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.AddAuthorButton = new System.Windows.Forms.Button();
            this.LibAuthorsListBox = new System.Windows.Forms.ListBox();
            this.AddReaderBatton = new System.Windows.Forms.Button();
            this.LibReadersListBox = new System.Windows.Forms.ListBox();
            this.labelBooks = new System.Windows.Forms.Label();
            this.labelAuthors = new System.Windows.Forms.Label();
            this.labelReaders = new System.Windows.Forms.Label();
            this.time_to_chek_readers_books = new System.Windows.Forms.Timer(this.components);
            this.AlertLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BooksBackList = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibBooksListBox
            // 
            this.LibBooksListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LibBooksListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibBooksListBox.FormattingEnabled = true;
            this.LibBooksListBox.Location = new System.Drawing.Point(11, 43);
            this.LibBooksListBox.Name = "LibBooksListBox";
            this.LibBooksListBox.Size = new System.Drawing.Size(246, 434);
            this.LibBooksListBox.TabIndex = 1;
            this.LibBooksListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LibBooksListBox_MouseClick);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddBookButton.Location = new System.Drawing.Point(13, 402);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(246, 23);
            this.AddBookButton.TabIndex = 2;
            this.AddBookButton.Text = "Добавить книгу";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddAuthorButton.Location = new System.Drawing.Point(264, 403);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(246, 23);
            this.AddAuthorButton.TabIndex = 5;
            this.AddAuthorButton.Text = "Добавить автора";
            this.AddAuthorButton.UseVisualStyleBackColor = true;
            this.AddAuthorButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
            // 
            // LibAuthorsListBox
            // 
            this.LibAuthorsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LibAuthorsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibAuthorsListBox.FormattingEnabled = true;
            this.LibAuthorsListBox.Location = new System.Drawing.Point(264, 43);
            this.LibAuthorsListBox.Name = "LibAuthorsListBox";
            this.LibAuthorsListBox.Size = new System.Drawing.Size(246, 434);
            this.LibAuthorsListBox.TabIndex = 4;
            this.LibAuthorsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LibAuthorsListBox_MouseClick);
            // 
            // AddReaderBatton
            // 
            this.AddReaderBatton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddReaderBatton.Location = new System.Drawing.Point(515, 403);
            this.AddReaderBatton.Name = "AddReaderBatton";
            this.AddReaderBatton.Size = new System.Drawing.Size(246, 23);
            this.AddReaderBatton.TabIndex = 7;
            this.AddReaderBatton.Text = "Добавить читателя";
            this.AddReaderBatton.UseVisualStyleBackColor = true;
            this.AddReaderBatton.Click += new System.EventHandler(this.AddReaderBatton_Click);
            // 
            // LibReadersListBox
            // 
            this.LibReadersListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LibReadersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibReadersListBox.FormattingEnabled = true;
            this.LibReadersListBox.Location = new System.Drawing.Point(514, 43);
            this.LibReadersListBox.Name = "LibReadersListBox";
            this.LibReadersListBox.Size = new System.Drawing.Size(246, 434);
            this.LibReadersListBox.TabIndex = 6;
            this.LibReadersListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LibReadersListBox_MouseClick);
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Location = new System.Drawing.Point(12, 27);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(70, 13);
            this.labelBooks.TabIndex = 8;
            this.labelBooks.Text = "Список книг";
            // 
            // labelAuthors
            // 
            this.labelAuthors.AutoSize = true;
            this.labelAuthors.Location = new System.Drawing.Point(266, 25);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Size = new System.Drawing.Size(88, 13);
            this.labelAuthors.TabIndex = 9;
            this.labelAuthors.Text = "Список авторов";
            // 
            // labelReaders
            // 
            this.labelReaders.AutoSize = true;
            this.labelReaders.Location = new System.Drawing.Point(514, 24);
            this.labelReaders.Name = "labelReaders";
            this.labelReaders.Size = new System.Drawing.Size(98, 13);
            this.labelReaders.TabIndex = 10;
            this.labelReaders.Text = "Список читателей";
            // 
            // time_to_chek_readers_books
            // 
            this.time_to_chek_readers_books.Enabled = true;
            this.time_to_chek_readers_books.Interval = 10000;
            this.time_to_chek_readers_books.Tick += new System.EventHandler(this.Time_to_chek_readers_books_Tick);
            // 
            // AlertLabel
            // 
            this.AlertLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AlertLabel.BackColor = System.Drawing.Color.Linen;
            this.AlertLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlertLabel.Location = new System.Drawing.Point(620, 0);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(130, 13);
            this.AlertLabel.TabIndex = 16;
            this.AlertLabel.MouseEnter += new System.EventHandler(this.AlertLabel_MouseEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.72093F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.42894F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.85013F));
            this.tableLayoutPanel1.Controls.Add(this.AddBookButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelReaders, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddAuthorButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAuthors, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddReaderBatton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelBooks, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LibAuthorsListBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LibBooksListBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LibReadersListBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.AlertLabel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 434);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // BooksBackList
            // 
            this.BooksBackList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BooksBackList.AutoSize = true;
            this.BooksBackList.Location = new System.Drawing.Point(629, 9);
            this.BooksBackList.Name = "BooksBackList";
            this.BooksBackList.Size = new System.Drawing.Size(0, 13);
            this.BooksBackList.TabIndex = 18;
            this.BooksBackList.Visible = false;
            this.BooksBackList.MouseLeave += new System.EventHandler(this.BooksBackList_MouseLeave);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(774, 434);
            this.Controls.Add(this.BooksBackList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "LibraryForm";
            this.Text = "Программа библиотечного учета";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibraryForm_FormClosing);
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LibBooksListBox;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button AddAuthorButton;
        private System.Windows.Forms.ListBox LibAuthorsListBox;
        private System.Windows.Forms.Button AddReaderBatton;
        private System.Windows.Forms.ListBox LibReadersListBox;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.Label labelAuthors;
        private System.Windows.Forms.Label labelReaders;
        private System.Windows.Forms.Timer time_to_chek_readers_books;
        private System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label BooksBackList;
    }
}

