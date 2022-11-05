using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random m = new Random();
            Console.WriteLine("Массив");
            int kol = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = m.Next(-10, 10);
                Console.Write(" {0}", a[i]);
                
            }
            Console.WriteLine();
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i - 1] > a[i])
                {
                    Console.WriteLine("Не по возрастанию");
                    break;
                }
                else
                {
                    kol++;
                }
            }
            if (kol == n-1)
            {
                Console.WriteLine("По возрастанию");
            }
            int x;
            x = a[3];
            a[3] = a[8];
            a[8] = x;
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" {0}", a[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите длину массива");
            int count = int.Parse(Console.ReadLine());
            int[] mass = new int[count];
            int[] result = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                mass[i] = rnd.Next(count + count);
            }
            Console.WriteLine("Исходные данные: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(mass[i] + " ");
            }
            int countUnic = 0;
            for (int i = 0; i < count; i++)
            {
                if (!result.Contains(mass[i]))
                    result[countUnic++] = mass[i];
            }
            Array.Resize(ref result, countUnic);
            Console.WriteLine("\nУникальный массив: ");
            for (int i = 0; i < countUnic; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
