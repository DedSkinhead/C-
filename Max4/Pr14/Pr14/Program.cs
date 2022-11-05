using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер элемента, после которого будет стоять 55 ");
            int w = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            Random m = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < n; i++)
            {
                a[i] = m.Next(-5, 15);
                Console.Write(" {0}", a[i]);
            }
            for (int i = n - 1; i >= w + 1; i--)

                a[i + 1] = a[i];
               a[w + 1] = 55;
            Console.WriteLine();
            Console.WriteLine("Массив после изменений ");
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(" {0}", a[i]);
            }
            
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите длину массива");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число");
            int r = int.Parse(Console.ReadLine());
            int[] F = new int[e * 2];
            Random ma = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < e; i++)
            {
                F[i] = ma.Next(0, 20);
                Console.Write(" {0}", F[i]);
            }
            int j = e - 1;
            while (j >= 0)
            {
                if (F[j] % 7 == 0 && F[j] >= 0)
                {
                    for (int i = e - 1; i >= j; i--)
                        F[i + 1] = F[i];
                    F[j] = r;
                    e = e + 1;
                }
                j--;
            }
            Console.WriteLine();
            Console.WriteLine("Массив после изменений ");
            for (int i = 0; i < e; i++)
            {

                Console.Write(" {0}", F[i]);
            }

            Console.ReadLine();
        }
    }
}
