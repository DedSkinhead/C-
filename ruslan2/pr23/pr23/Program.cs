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
            //Дан двумерный массив. Поменять местами каждые две строки массива.
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
                    A[i, j] = rand.Next() % 10;
                    Console.Write("{0,3}", A[i, j]);
                }
                Console.WriteLine();
            }

           
            for (int i = 0; i < m-1 ; i++)
            {
                int temp;
                for (int j = 0; j < n; j++)
                {
                    temp = A[i+1, j];
                    A[i+1, j] = A[i , j];
                    A[i, j] = temp;
                }
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
