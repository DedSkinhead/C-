using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paha_pr25
{
    class Program
    {
        static void Main(string[] args)
        {
            //определяет, имеются ли в строке два соседствующих одинаковых символа.
            Console.WriteLine("Введите строку: ");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            for (int i = 0; i + 1 < a.Length; i++)
            {
                if (a[i] == a[i + 1])
                {
                    Console.WriteLine("Да ");
                    break;
                }
            }
            //Подсчитать сколько раз заданное слово встречается в сообщении.
            Console.WriteLine("Введите предложение: ");
            string A = Console.ReadLine();
            Console.WriteLine("Введите слово: ");
            string W = Console.ReadLine();
            int x = 0;
            string[] M = A.Split(' ', '.', ',', '-', '!', '?');
            foreach(string q in M)
            {
                if (q == W)
                {
                    x++;
                }
            }
            Console.WriteLine("Слово '{0}' встречается в тексте {1} раз", W, x);
            Console.ReadKey();
        }
    }
}
