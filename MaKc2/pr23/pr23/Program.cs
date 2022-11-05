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
            //Дан двумерный массив. Составить программу, которая переставляет две любые строки массива (Номера переставляемых строк задаются с клавиатуры).
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите q");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите w");
            int w = int.Parse(Console.ReadLine());
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
            for (int j = 0; j < n; j++)
            {
                int x = A[q, j];
                A[q, j] = A[w, j];
                A[w, j] = x;
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
