using System;
using System.IO;
using System.Xml.Serialization;

namespace homeWorkLesson10_2
{
    class Program
    {
        static readonly string XmlFilePathWithAttributes = "PersonWithXmlAttributes.xml";
        static readonly string XmlFilePathWithoutAttributes = "PersonWithoutXmlAttributes.xml";

        static void Main(string[] args)
        {
            var person1 = new PersonWithXmlAttributes { Name = "Vasya", Surname = "Meshkov", Age = 30 };
            var person2 = new PersonWithoutXmlAttributes { Name = "Petya", Surname = "Ivanov", Age = 99 };

            #region Xml Serialization

            //PersonWithXmlAttributes
            var serializerPersonWithXmlAttributes = new XmlSerializer(typeof(PersonWithXmlAttributes));

            using (FileStream stream = new FileStream(XmlFilePathWithAttributes, FileMode.Create,
                FileAccess.Write, FileShare.Read))
            {
                serializerPersonWithXmlAttributes.Serialize(stream, person1);
            }

            Console.WriteLine("Person1 WithXmlAttributes Сериализован!");
            Console.ReadKey();


            //PersonWithoutXmlAttributes
            var serializerPersonWithoutXmlAttributes = new XmlSerializer(typeof(PersonWithoutXmlAttributes));

            using (FileStream stream = new FileStream(XmlFilePathWithoutAttributes, FileMode.Create,
                FileAccess.Write, FileShare.Read))
            {
                serializerPersonWithoutXmlAttributes.Serialize(stream, person2);
            }

            Console.WriteLine("Person2 WithoutXmlAttributes Сериализован!");
            Console.ReadKey();

            #endregion
        }
    }
}
