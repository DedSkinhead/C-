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
            //В двумерном массиве переставить строки следующим образом: первую с последней, вторую с предпоследней.
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
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
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int x = A[0, j];
                    int q = A[1, j];
                    A[0, j] = A[m-1, j];
                    A[1,j]= A[m - 2, j];
                    A[m - 1, j] = x;
                    A[m - 2, j] =q;
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
