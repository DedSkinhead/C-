using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rus14
{
    class Program
    {
        static void Main(string[] args)
        {
           // Задать случайным образом N элементов числового массива – числа от 0 до 20.Вставить в него число «66» после Y-го элемента.
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер элемента, после которого надо ставть 66 ");
            int w = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            Random m = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < n; i++)
            {
                a[i] = m.Next(0,20);
                Console.Write(" {0}", a[i]);
            }
            Console.WriteLine();
            for (int i = n - 1; i >= w + 1; i--)
             
                a[i + 1] = a[i];
                a[w + 1] = 66;
            
            Console.WriteLine("Массив после изменений ");
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(" {0}", a[i]);
            }
           // Задать случайным образом N элементов числового массива.Вставить число 77 перед чётными элементами массива.
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите длину массива");
            int e = int.Parse(Console.ReadLine());
            int[] F = new int[e*2];
            Random ma = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < e; i++)
            {
                F[i] = ma.Next(0, 20);
                Console.Write(" {0}", F[i]);
            }
            int j = e - 1;
            while(j>=0)
            {
                if (F[j] % 2 == 0)
                {
                    for (int i = e - 1; i >= j; i--)
                        F[i + 1] = F[i];
                        F[j] = 77;
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
