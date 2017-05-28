using System;
using System.Runtime.Remoting.Messaging;


namespace LibraryApp
{
    public class Book : IComparable<Book>
    {
        private string name { get; set; }
        private string publisher { get; set; }
        private int pagesCount { get; set; }
        private int year { get; set; }
        private Author author { get; set; }

        public Book()
        {
        }

        public Book(string name,string publisher, int pagescount, int year, Author author)
        {
            this.name = name;
            this.publisher = publisher;
            this.pagesCount = pagescount;
            this.year = year;
            this.author = author;
        }

        //public int CompareTo(Book other)
        //{
        //    if (this.pagesCount>other.pagesCount)
        //    { return 1;}
        //    if (this.pagesCount < other.pagesCount)
        //    { return -1;}
        //    else
        //    {
        //        return 0;
        //    }
        //}

        public int CompareTo(Book book)
        {
            return this.pagesCount.CompareTo(book.pagesCount);
        }
    }
}