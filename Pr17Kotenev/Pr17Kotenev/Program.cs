using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr17Kotenev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано число g (0 < g < n) и матрица размера n x m. Найти сумму и произведение элементов g-ой строки данной матрицы. 
            Console.WriteLine("Введите число g");
            int g = int.Parse(Console.ReadLine());
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
             for (int i = 0; i < mas.GetLength(0); i++)
            {
             sum += mas[i, g];
            prod *= mas[i, g];
             }
            Console.WriteLine("Сумма: "+sum+" и произведение:"+prod);
            Console.WriteLine();
            //Дана матрица размера n x m. Найти максимальное значение в каждом столбце. 
            for (int i = 0; i < mas.GetLength(1); ++i)
            {
                int min1 = mas[i,0];
                for (int j = 0; j < mas.GetLength(0); ++j)
                {
                    if (mas[j, i] < min1)
                    {
                        min1= mas[j, i];
                    }
                }

                Console.WriteLine("В столбце номер {0} -> {1}", i, min1);

            }
            //Дана матрица размера n x m. Преобразовать матрицу, поменяв местами минимальный и максимальный элемент в каждом столбце. 
            int maxj = 0, minj = 0;
            int x = 0;
            int min = int.MaxValue; int max = int.MinValue;
            min = int.MaxValue; max = int.MinValue;
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                        maxj = j;
                    }
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                        minj = j;
                    }
                }
                x = mas[i, maxj];     
                mas[i, maxj] = mas[i, minj];
                mas[i, minj] = x;
                min = int.MaxValue; max = int.MinValue;
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
