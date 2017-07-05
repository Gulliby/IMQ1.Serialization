using System;
using System.Xml.Serialization;

namespace IMQ1.BaseSerialization.Library.Entities
{
    [Serializable]
    [XmlType("genre")]
    public enum Genre
    {
        [XmlEnum(Name = "Computer")]
        Computer,
        [XmlEnum(Name = "Fantasy")]
        Fantasy,
        [XmlEnum(Name = "Romance")]
        Romance,
        [XmlEnum(Name = "Horror")]
        Horror,
        [XmlEnum(Name = "Science Fiction")]
        ScienceFiction
    }
}
