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
            //Дана матрица размера n x m. Найти минимальное значение в каждой строке. 
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, m];
            Random ran = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = ran.Next(-40, 50);
                    Console.Write("{0,3}", mas[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < mas.GetLength(0); ++i)
            {
                int min1 = int.MaxValue;
                for (int j = 0; j < mas.GetLength(1); ++j)
                {
                    if (mas[i, j] < min1)
                    {
                        min1 = mas[i, j];
                    }
                }

                Console.WriteLine("В строке номер {0} -> {1}", i, min1);
            }
            Console.ReadKey();
        }
    }
}
