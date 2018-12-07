using System;
using System.Collections.Generic;
using System.Text;
using PlayingWithDI.Interface;

namespace PlayingWithDI
{
    class ReadFactory
    {
        public IBookReader BookReader { get; set; }

        public ReadFactory(int choice)
        {
            switch (choice)
            {
                case 1:
                    BookReader = new JsonBookDataReader();
                    break;
                case 2:
                    BookReader = new XmlBookDataReader();
                    break;
            
                default:
                    break;
            }
            
        }

    }
}
