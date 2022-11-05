using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rus13
{
    class Program
    {
        static void Main(string[] args)
        {
           // Дан одномерный целочисленный массив. Составьте программу определения индекса(-ов) минимального элемента массива, кратного 3.Поменять местами 2 - ой и 7 - ой элементы.
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random m = new Random();
            Console.WriteLine("Массив");
            for(int i = 0; i<a.Length;i++)
            {
                a[i] = m.Next(-10, 10);
                Console.Write(" {0}",a[i]);
            }
            int x;
            x = a[6];
            a[6] = a[1];
            a[1] = x;
            int k = 0;
            int min = a[0];
            Console.WriteLine();
            Console.WriteLine("Массив с поменянными местами 2 и 7 элементами:");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 3 == 0)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                        k = i;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" {0}", a[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Индекс минимального числа которое делится на 3: " +k);
            //Дан одномерный массив С. Удалить все элементы, кратные 7 и 5.
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите длину массива");
            int q = int.Parse(Console.ReadLine());
            int[] F = new int[q];
            Random ma = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < q; i++)
            {
                F[i] = ma.Next(30, 36);
                Console.Write(" {0}", F[i]);
            }
            int g = 0;
            while (g < q)
            {
                if (F[g] % 7 == 0 && F[g] % 5 == 0)
                {
                    for (int j = g; j < q-1; j++)
                        F[j] = F[j + 1];
                        F[q - 1] = 0;
                        q = q - 1;
                }
                else
                    g++;
            }
            Console.WriteLine();
            Console.WriteLine("Массив без чисел кратных 7 и 5");
            for (int i = 0; i < q; i++)
            {
                Console.Write(" {0}", F[i]);
            }
            Console.ReadLine();
        }
    }
}
