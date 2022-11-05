using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pr25
{
    class Program
    {
        static void Main(string[] args)
        {
            // заменяет все группы стоящих рядом точек на многоточие.
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\.{4,}");
            string result = regex.Replace(input, @"...");
            Console.WriteLine(result);
            //Вывести на экран все слова-палиндромы, содержащиеся в сообщении.
            Console.WriteLine("Задание 2");

            Console.WriteLine("Введите текст.");
            string text = Console.ReadLine();
            char[] separators = { ' ', ',', ':', ';', '.', '!', '?' };
            string[] splitedText = text.Split(separators);

            foreach (string str in splitedText)
            {
                if (str != null)
                {
                    if (isPolyndrom(str))
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            Console.ReadLine();
        }
        private static bool isPolyndrom(string input)
        {
            if (input.Length > 1)
            {
                char[] temp = input.ToCharArray();
                Array.Reverse(temp);
                if (input == new string(temp))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
