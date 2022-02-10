using System;
using System.Xml;
using System.Xml.Linq;

namespace LINQTOXML_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            XDocument xDocument = new XDocument(

                 new XDeclaration("1.0", "utf-8", "yes"),
                  new XComment("New XML Document"),
                  new XElement("Customers",
                  new XElement("Customer", new XAttribute("ID", "A-101"),
                  new XElement("First", "Samu"),
                  new XElement("Second","Samu1"),
                  new XElement("State", "CTC")

                      ))
                );
            xDocument.Save("Customers.xml");
        }
    }
}
