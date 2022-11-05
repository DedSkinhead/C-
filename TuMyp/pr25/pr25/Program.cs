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
            Task1();
            Task2();
        }
            static void Task1(){
            //определяет, сколько раз  два заданных символа встречаются в строке и каких из них встретилось больше.
            Console.WriteLine("Введите строку: ");
                string line = Console.ReadLine();
                Console.WriteLine("Исходная строка: " + line);
                Console.WriteLine("Введите символ x: ");
                char x = char.Parse(Console.ReadLine());
                Console.WriteLine("Введите символ y: ");
                char y = char.Parse(Console.ReadLine());
                int countX = line.Where(a => a == x).Count();
                int countY = line.Where(a => a == y).Count();
                string result = "Символ '{0}' встречается чаще в строке.";
                if (countX > countY)
                    Console.WriteLine(result, x);
                else if (countY > countX)
                    Console.WriteLine(result, y);
                else
                    Console.WriteLine("Символы '{0}' и '{1}' встречаются одинаковое количество раз в строке.", x, y);
                Console.ReadKey();
            }
        static void Task2()
        {
            //Удалить из сообщения все слова, которые начинаются на заданный символ.
            Console.WriteLine("Введите строку: ");
            string line = Console.ReadLine();
            Console.WriteLine("Введите символ x: ");
            char x = char.Parse(Console.ReadLine());    
            Console.WriteLine(Regex.Replace(line, $@"\s*{x}\w*\b", "").Trim());
            Console.ReadKey();
        }
    }
}
