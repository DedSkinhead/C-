using System;
using System.Collections.Generic;
using static System.StringSplitOptions;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr25_MAX
{
    class Program
    {
        static void Main(string[] args)
        {
            //определяет, сколько различных символов встречается в строке.
            WriteLine("Задание 1");
            var str = Console.ReadLine();
            var set = str.Distinct();
            WriteLine("Различных символов встречается в строке: " + set.Count());
            // Вывести слова сообщения в алфавитном порядке.
            WriteLine("Задание 2");
            Write("Введите осмысленное сообщения: ");
            string s = ReadLine();
            char[] div = { ' ', ',', '.', ':', '!', '?', ';', ';', '-' };
            List<string> words = s.Split(div, RemoveEmptyEntries).ToList();
            words.Sort();
            WriteLine(string.Join(" | ", words));
            // выход из программы
            WriteLine("Нажмите любую клавишу для выхода...");
            ReadKey(true);
        }
    }
}
