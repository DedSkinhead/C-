using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr23
{
    class Program
    {
        static void Main(string[] args)
        {
            //К элементам k1-го столбца двумерного массива прибавить элементы k2-го столбца. Поменять местами 2 и N-1 столбцы.
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k1");
            int k1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k2");
            int k2 = int.Parse(Console.ReadLine());
            int[,] A = new int[m, n];
            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rand.Next(0, 12);
                    Console.Write("{0,3}", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < A.GetLength(0); i++)
            {
                A[i, k1] += A[i, k2];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int q = A[j, 1];
                    A[j, 1] = A[j, n-2];
                    A[j, n-2] = q;
                }
                break;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
