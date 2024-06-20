using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Variant_6
{
    public class Task1
    {

        public struct Book
        {
            private static int _nextIsbn = 0;
            public string Title { get; }
            public int ISBN { get; }
            public string Author { get; }
            public int Year { get; }

            public Book(string title, string author, int year)
            {
                Title = title;
                ISBN = _nextIsbn++;
                Author = author;
                Year = year;
            }
            public override string ToString()
            {
                return $"Title = {Title}, ISBN = {ISBN}, author = {Author}, year = {Year}";
            }



            public static List<Book> Select(Book[] books, string author)
            {
                List<Book> result = new List<Book>();
                foreach (Book book in books)
                {
                    if (book.Author == author)
                    {
                        result.Add(book);
                    }
                }
                return result;
            }
            public static List<Book> Select(Book[] books, int year)
            {
                List<Book> result = new List<Book>();
                foreach (Book book in books)
                {
                    if (book.Year == year)
                    {
                        result.Add(book);
                    }
                }
                return result;
            }
        }
        //продолжение класса
        private Book[] _books;

        public Book[] Books
        {
            get { return _books; }
        }

        public Task1(Book[] books)
        {
            _books = books;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Book book in _books)
            {
                result += book.ToString() + Environment.NewLine;
            }
            return result;
        }

        public void Sorting()
        {
            int n = _books.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (_books[j].Year > _books[j + 1].Year)
                    {

                        Book temp = _books[j];
                        _books[j] = _books[j + 1];
                        _books[j + 1] = temp;
                    }
                }
            }
        }


    }
}
