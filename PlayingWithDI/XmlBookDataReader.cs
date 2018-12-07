using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayingWithDI.Interface;

namespace PlayingWithDI
{
    class XmlBookDataReader : XmlConnection, IBookReader
    {

        private List<BookModel> _books = new List<BookModel>();
        public List<BookModel> GetBookCollection()
        {
            _books = (from book in XmlBooks.Element("root")?.Elements("row")



                select new BookModel(
                    book.Element("Title")?.Value,
                    book.Element("Author")?.Value,
                    book.Element("Genre")?.Value,
                    book.Element("SubGenre")?.Value,
                    int.Parse((string) book.Element("Height")?.Value),
                    book.Element("Publisher")?.Value
                )).ToList();

            return _books;
        }
    }
}
