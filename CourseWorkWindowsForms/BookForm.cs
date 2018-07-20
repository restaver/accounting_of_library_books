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
    abstract public partial class BookForm : Form
    {
        protected RemoveBook remove_b;
        protected Book this_book;
        protected void Create (Book b)
        {
            this_book = b;
            InitializeComponent();
            DescriptionTextBox.Text = this_book.Descripion;
            this.Text = this_book.ToString();
        }
        protected virtual void ChangeOwnerButton_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            remove_b(this_book, this);
            this.Close();
        }
    }




    public class LibraryBookForm : BookForm
    {
        GiveBookToReaderDelegate give_to_reader;
        GetReadersDelegate get_readers;
        ComboBox ComboBoxReaders;
        public LibraryBookForm (Book b, GiveBookToReaderDelegate sender, GetReadersDelegate gr, RemoveBook rb)
        {
            remove_b = rb;
            get_readers = gr;
            give_to_reader = sender;
            base.Create(b);
            ChangeOwnerButton.Text = "передать читателю ->";
            InitializeComboBoxReaders();
            ChangeOwnerButton.Location = new Point(ChangeOwnerButton.Location.X - ChangeOwnerButton.Width - 3, ChangeOwnerButton.Location.Y);
            ComboBoxReaders.Show();
            ComboBoxReaders.Refresh();
        }

        private void InitializeComboBoxReaders()
        {
            this.ComboBoxReaders = new ComboBox()
            {
                Location = ChangeOwnerButton.Location,
                Name = "ComboBoxReaders",
                Width = ChangeOwnerButton.Width,
                Height = ChangeOwnerButton.Height,
                BackColor = System.Drawing.SystemColors.Window,
                DropDownHeight = 100,
                Text = "Выберите читателя",
                DataSource = get_readers()
            };
            //this.ComboBoxReaders.DataSource = get_readers();
            /*foreach (Reader r in get_readers())
            {
                ComboBoxReaders.Items.Add(r);
            }*/
            this.Controls.Add(ComboBoxReaders);
        }
        protected override void ChangeOwnerButton_Click(object sender, EventArgs e)
        {
            if(ComboBoxReaders.SelectedIndex > -1)
            {
                foreach (Reader r in get_readers())
                {
                    if(r == ComboBoxReaders.SelectedItem)
                    {
                        give_to_reader(this_book, r);
                        break;
                    }
                }
            }
            this.Close();
        }
    }




    public class ReaderBookForm : BookForm
    {
        public Reader Reader_parent { get; }
        public ReaderBookForm(Book b, RemoveBook rb, Reader r)
        {
            Reader_parent = r;
            remove_b = rb;
            base.Create(b);
            ChangeOwnerButton.Text = "вернуть в библиотеку";
        }
        protected override void ChangeOwnerButton_Click(object sender, EventArgs e)
        {
            base.ChangeOwnerButton_Click(sender, e);
        }
    }

}
