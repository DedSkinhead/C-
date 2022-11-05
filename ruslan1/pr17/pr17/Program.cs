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
            //1.Дано число q (0 < q < m) и матрица размера n x m. Найти сумму и произведение элементов q-го столбца данной матрицы. 
            Console.WriteLine("Введите число q");
            int q = int.Parse(Console.ReadLine());
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
                    mas[i, j] = ran.Next(-40, 50);
                    Console.Write("{0,3}", mas[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                sum += mas[i, q];
                prod *= mas[i, q];
            }
            Console.WriteLine("Сумма: " + sum + " и произведение:" + prod);
            Console.WriteLine();
            //2.Дана матрица размера n x m. Найти минимальное значение в каждой строке. 
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
            //Дана матрица размера n x m. Преобразовать матрицу, поменяв местами минимальный и максимальный элемент в каждой строке. 
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
                p = mas[ i, maxi];     
                mas[i, maxi] = mas[ i, mini];
                mas[i,mini] = p;
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
