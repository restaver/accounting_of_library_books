namespace CourseWorkWindowsForms
{
    partial class AddAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthorForm));
            this.Cancel = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Biography = new System.Windows.Forms.TextBox();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(292, 222);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(99, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(199, 222);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Biography
            // 
            this.Biography.Location = new System.Drawing.Point(12, 38);
            this.Biography.Multiline = true;
            this.Biography.Name = "Biography";
            this.Biography.Size = new System.Drawing.Size(379, 178);
            this.Biography.TabIndex = 11;
            this.Biography.Text = "Биография автора (не обязательно)";
            // 
            // AuthorName
            // 
            this.AuthorName.Location = new System.Drawing.Point(12, 12);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(379, 20);
            this.AuthorName.TabIndex = 10;
            this.AuthorName.Text = "Введите имя автора (обязательно для заполнения)";
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 253);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Biography);
            this.Controls.Add(this.AuthorName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAuthorForm";
            this.Text = "Добавление автора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox Biography;
        private System.Windows.Forms.TextBox AuthorName;
    }
}