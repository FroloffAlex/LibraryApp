

using System;

namespace LibraryApp
{
    public class Department:ICountingBooks<Book>,IComparable
    {
        private string name { get; set; }
        public Book[] Books;

        public int counter(Book obj)
        {
            return Books.Length;
        }

       

        public int CompareTo(object obj)
        {
            return Books.Length;
        }
    }
}