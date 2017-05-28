using System;


namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Of Ivan Franko",3);
            Console.WriteLine(library.ToString());
            Console.ReadKey();
            
        }
    }
}
