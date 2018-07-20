using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWindowsForms
{
    [Serializable]
    public class Author
    {
        private string name;
        public string Biography { get; set; }

        public Author(string name)
        {
            this.name = name;
        }
        public Author (string name, string bio)
        {
            this.name = name;
            Biography = bio;
        }
        public override string ToString()
        {
            return name;
        }
    }

    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        //public int author_id;
        public string Descripion { get; set; } //Вместо Text
        private List<Author> authors;
        public  Book()
        {

        }
        public Book(string name, string des)
        {
            Name = name;
            Descripion = des;
        }
        public Book(string name, string des, List<Author> a)
        {
            Name = name;
            Descripion = des;
            authors = a;
        }
        public List<Author> GetAuthors()
        {
            return authors;
        }
        public void AddAuthr(Author a)
        {
            authors.Add(a);
        }
        public override string ToString()
        {
            string result = " \"" + Name + "\"";
            if (authors.Count() > 0)
            {
                foreach (Author a in authors)
                {
                    result += (" " + a + ",");
                }
                result.Remove(result.IndexOf(' '), 1);
                result.Remove(result.LastIndexOf(','), 1);
            }
            //result += (" \"" + Name + "\"");
            return result;
        }

    }
    [Serializable]
    public class Reader
    {
        public const int max_number_of_books = 10;
        int number_of_books;
        //private string password;
        private string name;
        Book[] books;
        DateTime[] time_of_return;

        public Reader(string name)
        {
            this.name = name;
            number_of_books = 0;
            books = new Book[max_number_of_books];
            time_of_return = new DateTime[max_number_of_books];
        }
        public override string ToString()
        {
            return name;
        }
        public Book[] GetBooks()
        {
            return books;
        }
        public DateTime[] GetTimeToReturn()
        {
            return time_of_return;
        }
        public void AddBook (Book b)
        {
            if (number_of_books < max_number_of_books)
            {
                books[number_of_books] = b;
                time_of_return[number_of_books] = DateTime.Now.AddSeconds(30); //AddDays(30)
                number_of_books++;
            }
            else
            {
                throw new Exception("У читателя уже максимальное количество книг");
            }
        }
        public void RemoveBook(Book b)
        {
            for (int count = 0; count < number_of_books; count++)
            {
                if (books[count] == b)
                {
                    while (count < number_of_books-1)
                    {
                        books[count] = books[count + 1];
                        time_of_return[count] = time_of_return[count + 1];
                        count++;
                    }
                }
            }
            number_of_books--;
        }
        public List<Book> CheckBooks() //Доработать случай с недозаполененым массивом
        {
            List<Book> result = new List<Book>();
            for (int count = 0; count < number_of_books; count++)
            {
                if ( time_of_return[count] <= DateTime.Now)
                {
                    result.Add(books[count]);
                }
            }
            return result;
        }
        public int GetNumberOfBooks()
        {
            return number_of_books;
        }
    }


    [Serializable]
    public class Library
    {
        private List<Book> books;
        private List<Author> authors;
        private List<Reader> readers;

        public Library()
        {

            books = new List<Book>();
            authors = new List<Author>();
            readers = new List<Reader>();
        }

        public List<Book> GetBooksList()
        {
            return books;
        }
        public List<Author> GetAuthors()
        {
            return authors;
        }
        public List<Reader> GetReaders()
        {
            return readers;
        }

        public void AddBook(Book b)
        {
            books.Add(b);
        }
        public void AddAuthor(Author a)
        {
            authors.Add(a);
        }
        public void AddReader(Reader r)
        {
            readers.Add(r);
        }


        public void GiveBookToReader (Book b, Reader r)
        {
            r.AddBook(b);
            books.Remove(b);
        }
        public void GetBookBack(Book b, Reader r)
        {
            books.Add(b);
            r.RemoveBook(b);
        }

        public void RemoveBook(Book b, Object o)
        {
            if (books.Contains(b))
                books.Remove(b);
            else
            {
                try
                {
                    ((Reader)o).RemoveBook(b);
                }
                catch
                {
                    ((ReaderBookForm)o).Reader_parent.RemoveBook(b);
                }
            }
        }
        public void RemoveReader(Reader r)
        {
            readers.Remove(r);
        }
    }
}
