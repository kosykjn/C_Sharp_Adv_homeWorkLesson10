using homeWorkLesson10_1;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace homeWorkLesson10_3
{
    class Program
    {
        static readonly string XmlFilePath = "Person.xml";
        static readonly string BinFilePath = "Person.bin";
        static readonly string SoapFilePath = "Person.soap";
        static void Main(string[] args)
        {
            #region Xml

            Console.WriteLine("Нажмите любую клавишу для десериализации объекта #1 (XML)");
            Console.ReadKey();

            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            using (FileStream stream = new FileStream(XmlFilePath, FileMode.Open,
               FileAccess.Read, FileShare.Read))
            {
                Person deserializePerson = serializer.Deserialize(stream) as Person;

                Console.WriteLine("Объект #1 десериализован!");
                Console.WriteLine(deserializePerson);
            }
            #endregion

            #region Binary

            Console.WriteLine("Нажмите любую клавишу для десериализации объекта #2 (Binary)");
            Console.ReadKey();

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = File.OpenRead(BinFilePath))
            {
                var deserializePerson = formatter.Deserialize(stream) as Person;

                Console.WriteLine("Объект #2 десериализован!");
                Console.WriteLine(deserializePerson);
            }
            #endregion

            #region SOAP

            Console.WriteLine("Нажмите любую клавишу для десериализации объекта #3 (SOAP)");
            Console.ReadKey();

            SoapFormatter soapFormatter = new SoapFormatter();

            using (FileStream stream = File.OpenRead(SoapFilePath))
            {
                var deserializePerson = soapFormatter.Deserialize(stream) as Person;

                Console.WriteLine("Объект #3 десериализован!");
                Console.WriteLine(deserializePerson);
            }

            Console.ReadKey();

            #endregion

        }
    }
}
