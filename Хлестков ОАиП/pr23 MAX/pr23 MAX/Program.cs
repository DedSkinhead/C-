using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr23_MAX
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дан двумерный массив из четного числа столбцов.Столбцы левой половины массива поменять местами со столбцами правой половины.
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            if (m % 2 != 0 || n % 2 != 0)
            {
                Console.WriteLine("Числа должны быть четными");
            }
            else
            {
                int[,] A = new int[m, n];
                Random rand = new Random();

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        A[i, j] = rand.Next() % 10;
                        Console.Write("{0,3}", A[i, j]);
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < n / 2; i++)
                {
                    int temp;
                    for (int j = 0; j < m; j++)
                    {
                        temp = A[j, n / 2 + i];
                        A[j, n / 2 + i] = A[j, i];
                        A[j,  i] = temp;
                    }
                }
                Console.WriteLine()
    ; for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0,3}", A[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
