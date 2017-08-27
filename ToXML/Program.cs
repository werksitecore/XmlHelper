using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToXML.Helpers;
using ToXML.Model;

namespace ToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var news = new NewsModel()
            {
                Id = 10,
                Title = "Converting model to XML",
                NewsDate = DateTime.Today,
                Body = "<p>To convert, I use &nbsp;<em>XmlSerializer</em> to serialize.</p>"
            };

            var xml = news.ToXml();

            Console.WriteLine(xml);

            //var xml =
            //    "<News xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
            //    "<Id>10</Id>" +
            //    "<Title>Converting model to XML</Title>" +
            //    "<Date>2017-08-27T00:00:00+02:00</Date>" +
            //    "<Body>&lt;p&gt;To convert, I use &amp;nbsp;&lt;em&gt;XmlSerializer&lt;/em&gt; to serialize.&lt;/p&gt;</Body>" +
            //    "</News>";

            Console.WriteLine("Is Valid XML: {0}", xml.IsValidXml());

            if (xml.IsValidXml())
            {
                var model = xml.ToModel<NewsModel>();
                Console.WriteLine("Is Null: {0}", model == null);
                if (model != null)
                {
                    Console.WriteLine("Title: {0}", model.Title);
                    Console.WriteLine("News Date: {0}", model.NewsDate);
                }
            }

            Console.ReadKey();
        }
    }
}
