using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson10_5
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }

        public Product(string name, int price, DateTime date)
        {
            Name = name;
            Price = price;
            Date = date;
        }
    }
}
