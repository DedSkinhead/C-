using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paha_Pr23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дан двумерный массив. Переставить последнюю строку и первую строку, сумма элементов которой больше 50.
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
                    A[i, j] = rand.Next(9,12) ;
                    Console.Write("{0,3}", A[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < m; i++)
            {
                int sum3 = 0;
                for (int j = 0; j < n; j++)
                {
                    sum3 += A[i, j];
                    
                }
                Console.WriteLine("Сумма: " + sum3);
            }
            for (int i = 0; i < n; i++)
            {
                int temp;
                int indexFirst = -1;
                int indexLast = -1;
                int sum = 0;
                int sum1 = 0;
                for (int k = i; k < m; k++)
                {
                    sum = 0;
                    sum1 = 0;
                    for (int j = 0; j < n; j++)
                    {
                        sum += A[k, j];
                        if (sum > 50 && indexFirst == -1)
                        {
                            indexFirst = k;
                        }
                        sum1 += A[k, j];
                        if (sum1 > 50 && indexFirst != -1)
                        {
                            indexLast = k;
                           
                        }
                    }
                }
                if (indexFirst != -1 && indexLast != -1)
                {
                    Console.WriteLine("indexFirst: " + indexFirst + "indexLast: " + indexLast);
                    for (int j = 0; j < n; j++)
                    {
                        temp = A[indexFirst, j];
                        A[indexFirst, j] = A[indexLast, j];
                        A[indexLast, j] = temp;
                    }
                }
                Console.WriteLine("_______________________________");
                break;
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
