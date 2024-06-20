using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Variant_6.Task2;
using Variant_6;

namespace Variant_6
{
    public class Task2
    {

        public abstract class Book
        {
            private static int _nextIsbn = 0;
            public string Title { get; set; }
            public int ISBN { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }

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
            public int Cost()
            {
                return 500 + (DateTime.Now.Year - Year);
            }
            //конец класса Book
            public class PaperBook : Book //классы наследники
            {

                public PaperBook(string title, int iSBN, string author, int year)
                {

                }
                

                private bool _isHardCover;

                public bool IsHardCover
                {
                    get { return _isHardCover; }
                    set { _isHardCover = value; }
                }

                public override string ToString()
                {
                    return base.ToString() + $", hardcover = {IsHardCover}";
                }
            }

            public class ElectronicBook : Book
            {
                public string group;
                public ElectronicBook(int g)
                {
                    group = g;
                }
                private string _format;

                public string Format
                {
                    get { return _format; }
                    set { _format = value; }
                }

                public override string ToString()
                {
                    return base.ToString() + $", format = {Format}";
                }
            }

            public class AudioBook : Book
            {

                private bool _isStudioRecord;

                public bool IsStudioRecord
                {
                    get { return _isStudioRecord; }
                    set { _isStudioRecord = value; }
                }

                public override string ToString()
                {
                    return base.ToString() + $", studio record = {IsStudioRecord}";
                }
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
