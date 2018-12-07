using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingWithDI.Interface
{
    interface IBookReader
    {
        List<BookModel> GetBookCollection();
    }
}
