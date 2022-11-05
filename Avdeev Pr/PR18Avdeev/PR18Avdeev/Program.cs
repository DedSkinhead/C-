using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR18Avdeev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дана целочисленная матрица размера M x N. Найти элемент, являющийся максимальным в своей строке и минимальным в своем столбце. Если такой элемент отсутствует, то вывести 0. 
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            int[,] A = new int[n, m];
            Random ran = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = ran.Next(0, 11);
                    Console.Write("{0,3}", A[i, j]);
                }
                Console.WriteLine();
            }
            int q = 0;
            int w = 0;
            bool Good = true;

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (A[q, w] < A[i, k])
                    {
                        q = i;
                        w = k;
                        Good = true;
                    }
                }
                if (Good)
                {
                    for (int s = 0; s < 3; s++)
                    {
                        if (A[q, w] > A[s, w])
                        {
                            Good = false;
                        }
                    }
                    break;
                }
            }
            if (Good)
            {
                Console.WriteLine("Элемент, являющийся максимальный в своей строке и минимальным в своем столбце: " + A[q,w]);
            }
            else
            {
                Console.WriteLine("Элемент, являющийся максимальный в своей строке и минимальным в своем столбце не существует.");
            }
            Console.ReadKey();
        }
    }
    }

