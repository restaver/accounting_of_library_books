using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CourseWorkWindowsForms
{
    #region delegates
    public delegate void AddBookDelegate(Book b);
    public delegate void AddAuthorDelegate(Author a);
    public delegate void AddReaderDelegate(Reader r);
    public delegate void GiveBookToReaderDelegate(Book b, Reader r);
    public delegate void RemoveBook (Book b, Object o);
    public delegate void RemoveReader (Reader r);
    public delegate List<Author> GetAuthorsDelegate();
    public delegate List<Reader> GetReadersDelegate();
    #endregion

    public partial class LibraryForm : Form
    {
        const string LibrarySaveFile = "LibSave.dat";
        private Library lib;
        public LibraryForm()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(LibrarySaveFile))
            {
                using (FileStream fs = new FileStream(LibrarySaveFile, FileMode.OpenOrCreate))
                {
                    try
                    {
                        lib = (Library)formatter.Deserialize(fs);
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось открыть файл " + LibrarySaveFile);
                        lib = new Library();
                    }
                    fs.Close();
                }
            }
            else
            {
                lib = new Library();
            }
            InitializeComponent();
        }

        private void UpdateLibBooksListBox()
        {
            LibBooksListBox.Items.Clear();
            List<Book> books = lib.GetBooksList();
            foreach (Book b in books)
            {
                LibBooksListBox.Items.Add(b);
            }
            //LibBooksListBox.ClearSelected();
        }
        private void UpdateLibAuthorsListBox()
        {
            LibAuthorsListBox.Items.Clear();
            List<Author> authors = lib.GetAuthors();
            foreach (Author a in authors)
            {
                LibAuthorsListBox.Items.Add(a);
            }
        }
        private void UpdateLibReadersListBox()
        {
            LibReadersListBox.Items.Clear();
            List<Reader> readers = lib.GetReaders();
            foreach (Reader r in readers)
            {
                LibReadersListBox.Items.Add(r);
            }
        }

        private void CheckReadersBooks()
        {
            int number_of_alerts = 0;
            foreach (Reader r in lib.GetReaders())
            {
                foreach (Book b in r.CheckBooks())
                {
                    number_of_alerts++;

                }
            }
            AlertLabel.Text = String.Format("{0} новых уведомлений", number_of_alerts);
            if (number_of_alerts > 0)
            {
                AlertLabel.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                AlertLabel.BackColor = System.Drawing.Color.Linen;
            }
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            UpdateLibBooksListBox();
            UpdateLibAuthorsListBox();
            UpdateLibReadersListBox();
            CheckReadersBooks();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AddBookForm ABF = new AddBookForm(new AddBookDelegate(lib.AddBook), new GetAuthorsDelegate(lib.GetAuthors), new AddAuthorDelegate(lib.AddAuthor));
            ABF.ShowDialog();
            UpdateLibBooksListBox();
            UpdateLibAuthorsListBox();
        }
        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            AddAuthorForm AAF = new AddAuthorForm(new AddAuthorDelegate(lib.AddAuthor));
            AAF.ShowDialog();
            UpdateLibAuthorsListBox();
        }
        private void AddReaderBatton_Click(object sender, EventArgs e)
        {
            AddReaderForm ARF = new AddReaderForm(new AddReaderDelegate(lib.AddReader));
            ARF.ShowDialog();
            UpdateLibReadersListBox();
        }

        private void LibBooksListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (LibBooksListBox.SelectedItems.Count > 0)
                foreach (Book b in lib.GetBooksList())
                {
                    if (LibBooksListBox.SelectedItem.Equals(b))
                    {
                        BookForm BF = new LibraryBookForm(b, new GiveBookToReaderDelegate(lib.GiveBookToReader), new GetReadersDelegate(lib.GetReaders), new RemoveBook(lib.RemoveBook));
                        BF.ShowDialog();
                        break;
                    }
                }
            UpdateLibBooksListBox();      
        }
        private void LibAuthorsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (LibAuthorsListBox.SelectedItems.Count > 0)
                foreach (Author a in lib.GetAuthors())
                {
                    if (LibAuthorsListBox.SelectedItem.Equals(a))
                    {
                        AuthorForm AF = new AuthorForm(a);
                        AF.ShowDialog();
                    }
                }
                LibAuthorsListBox.ClearSelected();
        }
        private void LibReadersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (LibReadersListBox.SelectedItems.Count > 0)
                foreach (Reader r in lib.GetReaders())
                {
                    if (LibReadersListBox.SelectedItem.Equals(r))
                    {
                        ReaderForm RF = new ReaderForm(r, lib.AddBook, lib.RemoveBook, lib.RemoveReader);
                        RF.ShowDialog();
                        UpdateLibBooksListBox();
                        break;
                    }
                }
                UpdateLibReadersListBox();
                //LibReadersListBox.ClearSelected();
                CheckReadersBooks();
        }

        private void Time_to_chek_readers_books_Tick(object sender, EventArgs e)
        {
            CheckReadersBooks();
        }

        private void AlertLabel_MouseEnter(object sender, EventArgs e)
        {
            if (AlertLabel.Text != "0 новых уведомлений")
            foreach (Reader r in lib.GetReaders())
            {
                foreach (Book b in r.CheckBooks())
                {
                    BooksBackList.Text += "Читатель ";
                    BooksBackList.Text += r;
                    BooksBackList.Text += "должен вернуть книгу ";
                    BooksBackList.Text += b;
                    BooksBackList.Text += "\n";
                }
            }
            BooksBackList.Location = new Point(AlertLabel.Location.X + AlertLabel.Width - BooksBackList.Width, AlertLabel.Location.Y);
            BooksBackList.Show();
        }

        //enum mb_buttons :{ SaveEndExit, Exit, Casnsel}
        private void LibraryForm_FormClosing(object sender, FormClosingEventArgs e)
        { 
            DialogResult mb_result =  MessageBox.Show("Сохранить изменения перед выходом из программы?", "Выход", MessageBoxButtons.YesNoCancel);
            if (mb_result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (mb_result == DialogResult.Yes)
            {
                e.Cancel = true;
                Save();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
            }
        }
        public void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(LibrarySaveFile, FileMode.OpenOrCreate))
            {
                try
                {
                    formatter.Serialize(fs, lib);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                fs.Close();
            }
        }

        private void BooksBackList_MouseLeave(object sender, EventArgs e)
        {
            BooksBackList.Hide();
            BooksBackList.Text = "";
        }
    }
}
