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
            //Дан одномерный массив чисел. Подсчитайте, сколько раз в нем встречается число 15. Поменять местами 5-ый и 10-ый элементы. 
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random m = new Random();
            Console.WriteLine("Массив");
            int kol0 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = m.Next(10, 16);
                Console.Write(" {0}", a[i]);
                if (a[i] == 15)
                {
                    kol0++;
                }
            }
            int x;
            x = a[5];
            a[5] = a[10];
            a[10] = x;
            Console.WriteLine();
            Console.WriteLine("Количество 15 : " + kol0);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" {0}", a[i]);

            }
            // Дан одномерный массив. Удалить все отрицательные нечётные элементы. Если отрицательных нечётных элементов нет, то выдать соответствующее сообщение.
            Console.WriteLine();
            Console.WriteLine("Задание 2");
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
                if (a1[g] <0&& a1[g]%2!=0)
                {
                    for (int j = g; j < n1 - 1; j++)
                        a1[j] = a1[j + 1];
                    a1[n1 - 1] = 0;
                    n1 = n1 - 1;
                }
                else
                    g++;
            }
            if (g == 0)
            {
                Console.WriteLine("нет таких");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Массив ");
                for (int i = 0; i < n1; i++)
                {
                    Console.Write(" {0}", a1[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
