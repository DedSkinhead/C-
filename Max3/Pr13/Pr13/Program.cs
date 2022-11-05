using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr13
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
            int kol0 = 0;
            
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = m.Next(-10, 10);
                Console.Write(" {0}", a[i]);
            }
            int sum = a[0] + a[n - 1];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > sum)
                {
                    kol0++;
                }
            }
            int x;
            x = a[6];
            a[6] = a[10];
            a[10] = x;
            Console.WriteLine();
            Console.WriteLine("Количество  : "+kol0);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" {0}", a[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите число");
            int pi = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину массива");
            int n1 = int.Parse(Console.ReadLine());
            int[] a1 = new int[n1];
            Random m1 = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = m1.Next(-10, 10);
                Console.Write(" {0}", a1[i]);
            }
            int g = 0;
            while (g < n1)
            {
                if (a1[g]<pi)
                {
                    for (int j = g; j < n1 - 1; j++)
                       a1[j] = a1[j + 1];
                    a1[n1 - 1] = 0;
                    n1 = n1 - 1;
                }
                else
                    g++;
            }
            Console.WriteLine();
            Console.WriteLine("Массив без чисел которые меньше заданного числа");
            for (int i = 0; i < n1; i++)
            {
                Console.Write(" {0}", a1[i]);
            }
            Console.ReadLine();
        }
    }
}
