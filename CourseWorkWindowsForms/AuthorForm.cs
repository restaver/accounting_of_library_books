using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWindowsForms
{
    public partial class AuthorForm : Form
    {
        Author this_author;
        public AuthorForm(Author a)
        {
            this_author = a;
            InitializeComponent();
            this.Text = this_author.ToString();
            this.textBox.Text = this_author.Biography;
        }

        private void textBoxBio_TextChanged(object sender, EventArgs e)
        {
            this_author.Biography = textBox.Text;
        }
    }
}
