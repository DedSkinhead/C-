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
            //Дана матрица размера n x m. Преобразовать матрицу, поменяв местами минимальный и максимальный элемент в каждой строке. 
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
            int max, min, p = 0, maxi = 0, maxj = 0, mini = 0, minj = 0;

            for (int i = 0; i < n; i++)
            {
                min = int.MaxValue; max = int.MinValue;
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                        maxi = j;
                        maxj = i;
                    }
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                        mini = j;
                        minj = i;
                    }
                }
                p = mas[i, maxi];
                mas[i, maxi] = mas[i, mini];
                mas[i, mini] = p;
            }
            Console.WriteLine("\n\nОбработанная матрица: ");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{0,3}", mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
