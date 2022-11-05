using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число r");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, m];
            Random ran = new Random();
            Console.WriteLine("Массив");
            var sum = 0d;
            var prod = 1d;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = ran.Next(-40, 30);
                    Console.Write("{0,3}", mas[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                sum += mas[f, i];
                prod *= mas[f, i];
            }
            Console.WriteLine("Сумма: " + sum + " и произведение:" + prod);
            Console.WriteLine();
            for (int i = 0; i < mas.GetLength(1); ++i)
            {
                int max1 = int.MinValue;
                for (int j = 0; j < mas.GetLength(0); ++j)
                {
                    if (mas[j, i] > max1)
                    {
                        max1 = mas[j, i];
                    }
                }

                Console.WriteLine("В столбце номер {0} -> {1}", i, max1);

            }
            int max, min, p = 0, maxi = 0, maxj = 0, mini = 0, minj = 0;

            for (int i = 0; i < m; i++)
            {
                min = int.MaxValue; max = int.MinValue;
                for (int j = 0; j < n; j++)
                {
                    if (mas[j, i] > max)
                    {
                        max = mas[j, i];
                        maxi = i;
                        maxj = j;
                    }
                    if (mas[j, i] < min)
                    {
                        min = mas[j, i];
                        mini = i;
                        minj = j;
                    }
                }
                p = mas[maxj, i];
                mas[maxj, i] = mas[minj, i];
                mas[minj, i] = p;
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
