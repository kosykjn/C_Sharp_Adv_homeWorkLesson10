using System;
using System.Text.RegularExpressions;

namespace homeWorkLesson10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password;
            Regex regex;

            string loginPattern = @"^[a-zA-Z]+";
            string passwordPattern = @"^[a-zA-Z0-9]+";

            do
            {
                Console.WriteLine("Введите логин для регистрации:");
                login = Console.ReadLine();
                regex = new Regex(loginPattern);
                if (!regex.IsMatch(login))
                {
                    Console.WriteLine("Неверный формат!!!\n");
                }
            } 
            while (!regex.IsMatch(login));  

            do
            {
                Console.WriteLine("Введите пароль для регистрации:");
                password = Console.ReadLine(); 
                regex = new Regex(passwordPattern);

                if (!regex.IsMatch(password))
                {
                    Console.WriteLine("Неверный формат!!!\n");
                }
            } 
            while (!regex.IsMatch(password));

            Console.WriteLine($"Регистрация прошла успешно!\nВаш логин:{login}\nВаш пароль:{password}");

            Console.ReadKey();
        }
    }
}
