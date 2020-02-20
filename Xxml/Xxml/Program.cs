using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Xxml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlByLinq();
            XmlDocument xld = new XmlDocument();
            xld.Load(@"C:\Users\Admin\source\repos\Xxml\Xxml\XMLFile1.xml");

            XmlNode xn = xld.DocumentElement.FirstChild;
            Console.WriteLine(xn.LastChild.InnerText);

            XmlNode x = xld.DocumentElement.ParentNode;
            Console.WriteLine(x.InnerText);

            Console.ReadKey();
        }
        public static void XmlByLinq()
        {
            XDocument doc = new XDocument(new XElement("Country",
                                          new XElement("State",
                                          new XElement("State_Name", "Maharashtra"),
                                          new XElement("State_Population", "23.5 Million"),
                                          new XElement("State_Capital", "Mumbai")),
                                          new XElement("State",
                                          new XElement("State_Name", "Kerala"),
                                          new XElement("State_Population", "9.5 Million"),
                                          new XElement("State_Capital", "Tiruanantpuram"))));

            doc.Save(Directory.GetCurrentDirectory() + "//state.xml");
        }

        

    }
}
