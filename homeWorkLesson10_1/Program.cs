using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace homeWorkLesson10_1
{
    class Program
    {
        static readonly string XmlFilePath = "Person.xml";
        static readonly string BinFilePath = "Person.bin";
        static readonly string SoapFilePath = "Person.soap";

        static void Main(string[] args)
        {
            var person = new Person() { Name = "Вася", Surname = "Петров", Age = 35 };

            #region Xml

            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            using (FileStream stream = new FileStream(XmlFilePath, FileMode.Create,
                FileAccess.Write, FileShare.Read))
            {
                serializer.Serialize(stream, person);
            }

            Console.WriteLine("Объект #1 Сериализован!");
            Console.ReadKey();

            #endregion

            #region Binary

            BinaryFormatter formatter = new BinaryFormatter();

            Console.WriteLine("Нажмите любую клавишу для сериализации объекта #2");
            Console.ReadKey();

            using (FileStream stream = File.Create(BinFilePath))
            {
                formatter.Serialize(stream, person);
                Console.WriteLine("Объект #2 Сериализован!");
            }

            #endregion

            #region SOAP

            SoapFormatter soapFormatter = new SoapFormatter();

            Console.WriteLine("Нажмите любую клавишу для сериализации объекта #3");
            Console.ReadKey();

            using (FileStream stream = File.Create(SoapFilePath))
            {
                soapFormatter.Serialize(stream, person);
                Console.WriteLine("Объект #3 Сериализован!");
            }
        
            Console.ReadKey();

            #endregion

        }
    }

}
