using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дана матрица размера n x m. Найти минимальное значение в каждом столбце.
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, m];
            Random ran = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = ran.Next(-4, 30);
                    Console.Write("{0,3}", mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < m; ++i)
            {
                int min = int.MaxValue;
                for (int j = 0; j < n; ++j)
                {
                    if (mas[j, i] < min)
                    {
                        min = mas[j, i];
                    }
                }
                Console.WriteLine("Минимальное число в столбце номер {0} -> {1}", i, min);
            }
            Console.ReadKey();
        }
    }
}
