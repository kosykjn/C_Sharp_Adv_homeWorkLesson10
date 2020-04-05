using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace homeWorkLesson10_5
{
    class Program
    {
        static Product[] ReadProducts()
        {
            var productList = new List<Product>();

            XDocument document = XDocument.Load("products.xml");

            foreach (XElement element in document.Element("Products").Elements("Product"))
            {
                productList.Add(new Product(
                    element.Element("Name").Value,
                    Convert.ToInt32(element.Element("Price").Value),
                    Convert.ToDateTime(element.Element("Date").Value)
                    )); 
            }

            return productList.ToArray();
        }

        static void Main(string[] args)
        {
            var productList = ReadProducts();

            RegionInfo regionInfo = RegionInfo.CurrentRegion;
            Console.WriteLine(regionInfo.NativeName);

            foreach (var products in productList)
            {
                Console.WriteLine($"{products.Name} {products.Price} { regionInfo.CurrencySymbol}" +
                    $" {products.Date.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern)}");
            }

            Console.WriteLine(new string ('-', 40));

            CultureInfo cultureInfo = new CultureInfo("en-Us");
            Console.WriteLine(cultureInfo.NativeName);

            NumberFormatInfo USformat = NumberFormatInfo.GetInstance(cultureInfo);

            foreach (var products in productList)
            {
                Console.WriteLine($"{products.Name} {products.Price} {USformat.CurrencySymbol} " +
                    $"{products.Date.ToString(cultureInfo.DateTimeFormat.ShortDatePattern)}");
            }


            Console.ReadKey();
        }
    }
}
