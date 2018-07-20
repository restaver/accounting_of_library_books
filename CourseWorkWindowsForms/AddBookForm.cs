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
    public partial class AddBookForm : Form
    {
        //private Library Lib;
        private string book_name = "";
        private string description = "";
        private List<Author> authors;

        AddAuthorDelegate AAD_sender;
        AddBookDelegate ABD_sender;
        GetAuthorsDelegate get_authors;
        public AddBookForm(AddBookDelegate ab_sender, GetAuthorsDelegate ga, AddAuthorDelegate aa_sender)
        {
            ABD_sender = ab_sender;
            AAD_sender = aa_sender;
            get_authors = ga;
            InitializeComponent();
                foreach (Author a in get_authors())
                {
                    checkedListBoxAuthors.Items.Add(a);
                }
        }

        private void BookName_TextChanged(object sender, EventArgs e)
        {
            book_name = BookName.Text;
        }
        private void Desctiption_TextChanged(object sender, EventArgs e)
        {
            description = Desctiption.Text;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (book_name == "" || BookName.Text == "Введите название книги")
            {
                MessageBox.Show("Необходимо ввести название книги");
            }
            else
            {
                authors = new List<Author>();
                try
                {
                    foreach (Author a in get_authors())
                    {
                        if (checkedListBoxAuthors.CheckedItems.Contains(a))
                        {
                            authors.Add(a);
                        }
                    }
                }
                catch
                {

                }
                ABD_sender(new Book(book_name,description,authors));
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            AddAuthorForm AAF = new AddAuthorForm(AAD_sender);
            AAF.ShowDialog();
            checkedListBoxAuthors.Items.Clear();//Обновление списка авторов
            foreach (Author a in get_authors())
            {
                checkedListBoxAuthors.Items.Add(a);
            }
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
