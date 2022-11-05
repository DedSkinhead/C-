using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        static void Task1()
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            Random m = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < n; i++)
            {
                a[i] = m.Next(-10, 20);
                Console.Write(" {0}", a[i]);
            }
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                if (a[j] > 0)
                {
                    int w = j;
                    for (int i = n - 1; i >= w + 1; i--)
                        a[i + 1] = a[i];
                    a[w + 1] = 55;
                    break;
                }
            }
            Console.WriteLine("Массив после изменений ");
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(" {0}", a[i]);
            }
            Console.ReadKey();
            Console.WriteLine();
        }
        static void Task2()
        {
            // Задать случайным образом N элементов числового массива. Вставить число 50 перед нечётными отрицательными элементами массива.
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n * 2];
            Random m = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < n; i++)
            {
                a[i] = m.Next(-35, 36);
                Console.Write(" {0}", a[i]);
            }
            Console.WriteLine();
            int w = n - 1;
            while (w >= 0)
            {
                if (a[w] % 2 != 0 && a[w] < 0)
                {

                    for (int i = n - 1; i >= w; i--)
                        a[i + 1] = a[i];
                    a[w] = 50;
                    n++;
                }
                w--;
            }
            Console.WriteLine("Массив после изменений ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0}", a[i]);
            }
            Console.ReadKey();
        }
    }
}
}
