using System.Xml.Linq;

namespace PlayingWithDI
{
    class XmlConnection
    {
        internal static readonly string Url = @"C:\Users\Sumitkiran.Gaurav\source\repos\PlayingWithDI\PlayingWithDI\";
        internal XDocument XmlBooks = XDocument.Load(Url + "Books.xml");
    }
}
