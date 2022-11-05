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
            //В двумерном массиве переставить строки следующим образом: первую с последней, вторую с предпоследней и так далее. Если строк нечетное количество, то средняя останется неизменной, иначе средние строки тоже меняем местами.
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
            for (int i = 0; i < n/2; i++)
            {
                int temp;
                for (int j = 0; j < m; j++)
                {
                    temp = A[j, i];
                    A[j, i] = A[n - 1 - j,i];
                    A[n - 1 - j, i] = temp;
                }
            }
            Console.WriteLine()
;            for (int i = 0; i <m; i++)
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
