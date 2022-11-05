using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr25
{
    class Program
    {
        static void Main(string[] args)
        {
            //находит порядковые номера первого и последнего вхождения символа x.
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            Console.WriteLine("Введите симаол");
            char c = char.Parse(Console.ReadLine());
            int first = 0;
            for (int i = 0; i < s.Length; ++i) if (s[i] == c)
                {
                    first = i;
                    break;
                }
            int last = 0;
            for (int i = s.Length - 1; i >= 0; --i) if (s[i] == c)
                {
                    last = i;
                    break;
                }
            Console.WriteLine("Первый {0}, последний {1}", first, last);
            //Найти самое длинное слово сообщения.
            Console.WriteLine("Введите сообщение");
            string[] vvod = Console.ReadLine().Split(' ', '.', ',', '!', '?');
            int max = 0;
            string slovo = "";
            for (int i = 0; i < vvod.GetLength(0); i++)
            {
                if (vvod[i].Length > max)
                {
                    max = vvod[i].Length;
                    slovo = vvod[i];
                }
            }
            Console.WriteLine("Самое длинное слово: {0}", slovo);

            Console.ReadKey();
        }
    }
}
