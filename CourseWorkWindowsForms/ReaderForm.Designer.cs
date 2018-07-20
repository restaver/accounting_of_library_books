namespace CourseWorkWindowsForms
{
    partial class ReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderForm));
            this.DeleteReader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteReader
            // 
            this.DeleteReader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteReader.Location = new System.Drawing.Point(490, 592);
            this.DeleteReader.Name = "DeleteReader";
            this.DeleteReader.Size = new System.Drawing.Size(115, 26);
            this.DeleteReader.TabIndex = 0;
            this.DeleteReader.Text = "Удалить читателя";
            this.DeleteReader.UseVisualStyleBackColor = true;
            this.DeleteReader.Click += new System.EventHandler(this.DeleteReader_Click);
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 630);
            this.Controls.Add(this.DeleteReader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReaderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteReader;
    }
}