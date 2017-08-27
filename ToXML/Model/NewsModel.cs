using System;
using System.Xml.Serialization;

namespace ToXML.Model
{
    [XmlRoot("News")]
    public class NewsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [XmlElement(ElementName = "Date")]
        public DateTime NewsDate { get; set; }
        public string Body { get; set; }
    }
}
