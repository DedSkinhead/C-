using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_23
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    A[i, j] = rand.Next(0, 20);
                    Console.Write("{0,3}", A[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < m; i++)
            {
                A[i, k1] = A[i, k1] + A[i, k2];
            }
            for (int j = 0; j < m; j++)
            {
                int x = A[j, 1];
                A[j, 1] = A[j, n-2];
                A[j, n-2] = x;
            }
            Console.WriteLine();
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
