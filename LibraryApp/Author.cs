using System;

namespace LibraryApp
{
    public class Author:ICountingBooks<Book>
    {
        private string name { get; set; }
        public Book[] Books;
        private static int counter;

        int ICountingBooks<Book>.counter(Book obj)
        {
            return Books.Length;
        }
    }
}