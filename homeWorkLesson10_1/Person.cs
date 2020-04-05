using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson10_1
{
    [Serializable]
    public class Person
    {
        private string name;
        private string surname;
        private int age;
        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void IsAPersonAStudent(bool check)
        {
            Console.WriteLine(check ? "Студент" : "Не студент");
        }

        public override string ToString()
        {
            return $"Имя:{this.Name}" +
                   $" Фамилия:{this.Surname}" +
                   $" Возраст:{this.Age}";
        }
    }
}
