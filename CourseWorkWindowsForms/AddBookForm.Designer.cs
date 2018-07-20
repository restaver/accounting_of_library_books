namespace CourseWorkWindowsForms
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.BookName = new System.Windows.Forms.TextBox();
            this.Desctiption = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAuthorButton = new System.Windows.Forms.Button();
            this.checkedListBoxAuthors = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(12, 25);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(308, 20);
            this.BookName.TabIndex = 0;
            this.BookName.Text = "Введите название книги";
            this.BookName.TextChanged += new System.EventHandler(this.BookName_TextChanged);
            // 
            // Desctiption
            // 
            this.Desctiption.Location = new System.Drawing.Point(357, 12);
            this.Desctiption.Multiline = true;
            this.Desctiption.Name = "Desctiption";
            this.Desctiption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Desctiption.Size = new System.Drawing.Size(445, 381);
            this.Desctiption.TabIndex = 1;
            this.Desctiption.Text = "Введите описание книги";
            this.Desctiption.TextChanged += new System.EventHandler(this.Desctiption_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(493, 399);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(137, 27);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(636, 399);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(167, 27);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поле с  названием книги является обязательным";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вы можете выбрать автора из списка или добавить нового";
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.Location = new System.Drawing.Point(12, 363);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(308, 30);
            this.AddAuthorButton.TabIndex = 8;
            this.AddAuthorButton.Text = "Добавить автора";
            this.AddAuthorButton.UseVisualStyleBackColor = true;
            this.AddAuthorButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
            // 
            // checkedListBoxAuthors
            // 
            this.checkedListBoxAuthors.FormattingEnabled = true;
            this.checkedListBoxAuthors.Location = new System.Drawing.Point(12, 64);
            this.checkedListBoxAuthors.Name = "checkedListBoxAuthors";
            this.checkedListBoxAuthors.Size = new System.Drawing.Size(308, 289);
            this.checkedListBoxAuthors.Sorted = true;
            this.checkedListBoxAuthors.TabIndex = 9;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 442);
            this.Controls.Add(this.checkedListBoxAuthors);
            this.Controls.Add(this.AddAuthorButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Desctiption);
            this.Controls.Add(this.BookName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBookForm";
            this.Text = "Добавление книги";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox Desctiption;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddAuthorButton;
        private System.Windows.Forms.CheckedListBox checkedListBoxAuthors;
    }
}