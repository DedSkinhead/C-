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
            // меняет местами первую букву со второй, третью с четвертой и т.д.
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            char[] m = str.ToCharArray();

            for (int i = 0; i < m.Length - 1; i += 2)
            {

                char tmp1 = m[i];
                char tmp2 = m[i + 1];

                m[i] = tmp2;
                m[i + 1] = tmp1;

            }
            Console.WriteLine(m);
            // Вывести только те слова сообщения, которые содержат не более чем n букв.
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите строку:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите количество символов в слове:");
            int n = int.Parse(Console.ReadLine());
            var msv = str1.Split(new char[] { ' ', ',', '.', '!', '?', '-' }).Where(x => x.Length <= n).ToArray();
            foreach (var item in msv)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
