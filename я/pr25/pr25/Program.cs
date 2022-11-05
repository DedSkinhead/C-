using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace pr25
{
    class Program
    {
        static void Main(string[] args)
        {
            //удваивает каждое вхождение заданного символа x.
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите символ");
            string x = Console.ReadLine();
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            string newS = s.Replace(x, x + x);
            Console.WriteLine(newS);
            // Вывести только те слова сообщения, которые заканчиваются прописной буквой.
            Console.WriteLine("Задание 2");
            var str = Console.ReadLine();
            foreach (Match match in Regex.Matches(str, @"[а-яёА-ЯЁ]*[А-ЯЁ]"))
            {
                Console.WriteLine(match.Value);
            }

            Console.ReadKey();
        }
    }
}
