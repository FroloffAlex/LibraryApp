
using System;

namespace LibraryApp
{
    public class Library : ICountingBooks<Book>
    {
        private string name { get; set; }
        public Department[] Departments;
        public Book[] Books;
        private static int countOfDeps = 0;
        private int capacityOfDeps;
        
        Library()
        {
        }

        internal Library(string name,int capasityOfDeps)
        {
            this.name = name;
            this.capacityOfDeps = capasityOfDeps;
        }

        public override string ToString()
        {
            return string.Format("The Library {0} created",name);
        }

        public int counter(Book obj)
        {
            return Books.Length;
        }
    }
}
