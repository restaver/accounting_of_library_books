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
    public partial class ReaderForm : Form
    {
        const int book_line_height = 30;
        const int border_width = 2;
        RemoveBook remove_b;
        RemoveReader remove_this;
        AddBookDelegate lib_add_book;
        Reader this_reader;
        public ReaderForm(Reader r, AddBookDelegate sender, RemoveBook rb, RemoveReader rr)
        {
            remove_this = rr;
            remove_b = rb;
            this_reader = r;
            this.Text = this_reader.ToString();
            lib_add_book = sender;
            InitializeComponent();
            Controls.Add(new BooksBox(new Point(10,10), Width-40, Height-60, lib_add_book, this_reader, remove_b));
        }

        private class BookLine : Control
        {
            BooksBox.ReDrow redrow;
            AddBookDelegate lib_add_book;
            RemoveBook remove_b;
            Book book;
            //Label book_label;
            //Label time_label;
            DateTime time_to_return;
            //Button BringBackButton;
            Reader parent_reader;
            public BookLine(Point P, Book b, DateTime time_to_return, AddBookDelegate sender, Reader r, int width, int height, BooksBox.ReDrow redrow, RemoveBook remove_b)
            {
                this.redrow = redrow;
                this.BackColor = Color.LightGray;
                Location = P;
                book = b;
                this.time_to_return = time_to_return;
                this.remove_b = remove_b;
                lib_add_book = sender;
                parent_reader = r;
                Width = width;
                Height = height;
                this.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left /*| AnchorStyles.Right | AnchorStyles.Top*/); 
                InitializeControls();
                
            }
            private void BringBack(object sender, EventArgs e)
            {
                lib_add_book(book);
                parent_reader.RemoveBook(book);
                redrow();
            }
            private void RemoveB(object sender, EventArgs e)
            {
                remove_b(book, parent_reader);
                redrow();
            }
            private void ShowBook(object sender, EventArgs e)
            {
                ReaderBookForm rbf = new ReaderBookForm(book, remove_b, parent_reader);
                rbf.ShowDialog();
                redrow();
            }
            private void InitializeControls()
            {
                Label book_label = new Label();
                book_label.Text = book.ToString();
                book_label.Location = new Point(0,0);
                book_label.Width = Width / 4;
                book_label.Height = Height;
                book_label.Cursor = Cursors.Hand;
                book_label.Anchor = (/*AnchorStyles.Bottom | AnchorStyles.Right |*/ AnchorStyles.Left | AnchorStyles.Top);
                book_label.Click += ShowBook;

                Label time_label = new Label();
                time_label.Text = (time_to_return > DateTime.Now ? time_to_return.ToString() : "Книгу следовало уже вернуть");
                time_label.ForeColor = (time_to_return > DateTime.Now ? System.Drawing.Color.Black : System.Drawing.Color.Red);
                time_label.Location = new Point(Location.X + Width / 4, 0);
                time_label.Width = Width / 4;
                time_label.Height = Height;
                time_label.Anchor = (/*AnchorStyles.Bottom | AnchorStyles.Right |*/ AnchorStyles.Left | AnchorStyles.Top);

                Button BringBackButton = new Button();
                BringBackButton.Text = "Вернуть в библиотеку";
                BringBackButton.Location = new Point(Location.X + Width * 2 / 4, 0);
                BringBackButton.Width = Width / 4;
                BringBackButton.Height = Height;
                BringBackButton.Anchor = (/*AnchorStyles.Bottom | AnchorStyles.Right |*/ AnchorStyles.Left | AnchorStyles.Top);
                BringBackButton.Click += BringBack;

                Button Remove = new Button();
                Remove.Text = "Удалить";
                Remove.Location = new Point(Location.X + Width * 3 / 4, 0);
                Remove.Width = Width / 4;
                Remove.Height = Height;
                Remove.Anchor = (/*AnchorStyles.Bottom | AnchorStyles.Right |*/ AnchorStyles.Left | AnchorStyles.Top);
                Remove.Click += RemoveB;

                Controls.Add(book_label);
                Controls.Add(time_label);
                Controls.Add(BringBackButton);
                Controls.Add(Remove);
            }
        }
        private class BooksBox : Control
        {
            public delegate void ReDrow();
            AddBookDelegate del;
            RemoveBook remove_b;
            Reader this_reader;
            //private List<BookLine> lines;
            public BooksBox(Point P, int whidth, int height, AddBookDelegate sender, Reader r, RemoveBook rb)
            {
                del = sender;
                remove_b = rb;
                this_reader = r;
                Location = P;
                Width = whidth;
                Height = height;
                this.BackColor = Color.Gray;
                this.Anchor = (/*AnchorStyles.Bottom | AnchorStyles.Right | */AnchorStyles.Left | AnchorStyles.Top);
                InitializeTable();
            }
            private void InitializeTable()
            {
                Controls.Clear();
                Book[] books = this_reader.GetBooks();
                DateTime[] times = this_reader.GetTimeToReturn();
                for (int i = 0; i < this_reader.GetNumberOfBooks(); i++)
                {
                    Controls.Add(new BookLine(
                            new Point(border_width,border_width + i * (border_width + book_line_height)/*(Height / this_reader.GetNumberOfBooks())*/),
                            books[i],
                            times[i],
                            del,
                            this_reader,
                            Width-2*border_width,
                            book_line_height/*(Height / this_reader.GetNumberOfBooks())*/,
                            InitializeTable,
                            remove_b
                        ));
                }
            }
        }

        private void DeleteReader_Click(object sender, EventArgs e)
        {
            remove_this(this_reader);
            this.Close();
        }
    }
}
