using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace IMQ1.BaseSerialization.Library.Entities
{
    [Serializable]
    [XmlType(TypeName = "catalog")]
    [XmlRoot(Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        [XmlElement("book")]
        public List<Book> Books { get; set; }

        [XmlAttribute("date")]
        public DateTime Date { get; set; }
    }
}
