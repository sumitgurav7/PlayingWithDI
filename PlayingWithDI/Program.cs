using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using PlayingWithDI.Interface;

namespace PlayingWithDI
{
    class Program
    {
        
        private static List<BookModel> _books = new List<BookModel>();

        static void Main()
        {
            IBookReader bookReader = new ReadFactory(1).BookReader;
            _books = bookReader.GetBookCollection();
            Console.WriteLine("Book Titles");
            Console.WriteLine("____________________________________________________________");
            foreach (BookModel book in _books)
            {
                Console.WriteLine(book.Title);
            }

        }
    }
}
