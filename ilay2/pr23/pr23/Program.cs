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
            //Дан двумерный массив.Переставить последнюю строку и строку, в которой находится первый элемент, кратный 4.
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
                    A[i, j] = rand.Next(1, 5);
                    Console.Write("{0,3}", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int p=-1;
            for (int i = 0; i < m; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] % 4 == 0)
                    {
                        p = i;
                        break;
                    }
                }
                if (p != -1)
                {
                    break;
                }
            }
            Console.WriteLine(p);
            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                        int temp;
                        temp = A[p, j];
                        A[p, j] = A[m-1, j];
                        A[m-1, j] = temp;
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
