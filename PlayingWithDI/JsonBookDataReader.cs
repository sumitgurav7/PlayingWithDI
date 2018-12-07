using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using PlayingWithDI.Interface;


namespace PlayingWithDI
{
    class JsonBookDataReader : JsonConnection, IBookReader
    {
        private List<BookModel> _books = new List<BookModel>();

        public List<BookModel> GetBookCollection()
        {
            string bookText = File.ReadAllText(Url);
            
            return JsonConvert.DeserializeObject<List<BookModel>>(bookText);
        }
    }
}
