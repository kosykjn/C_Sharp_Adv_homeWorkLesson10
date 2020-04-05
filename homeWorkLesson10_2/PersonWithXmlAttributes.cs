using System.Xml.Serialization;

namespace homeWorkLesson10_2
{
    public class PersonWithXmlAttributes
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Surname { get; set; }

        [XmlAttribute]
        public int Age { get; set; }
    }
}
