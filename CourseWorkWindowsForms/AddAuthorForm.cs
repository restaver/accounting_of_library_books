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
    public partial class AddAuthorForm : Form
    {
        AddAuthorDelegate AAD_sender;
        public AddAuthorForm(AddAuthorDelegate sender)
        {
            AAD_sender = sender;
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AuthorName.Text == "" || AuthorName.Text == "Введите имя автора (обязательно для заполнения)")
            {
                MessageBox.Show("Вы не ввели имя автора");
            }
            else
            {
                if (Biography.Text == "Биография автора (не обязательно)")
                {
                    Biography.Text = "";
                }
                AAD_sender(new Author(AuthorName.Text, Biography.Text));
                this.Close();
            }

        }
    }
}
