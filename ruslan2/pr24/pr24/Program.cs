using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr24
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        public static void Task1()
        {
            //1Вставить нулевой столбец перед столбцами, в которых встретился минимальный элемент. 
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            int[,] A = new int[n, m];
            Random rand = new Random();
            int w = int.MaxValue;
            for (int k = 0; k < A.GetLength(0); k++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[k, j] = rand.Next(-1, 5);
                    Console.Write("{0,3}", A[k, j]);
                    if (A[k, j] < w)
                    {
                        w = A[k, j];
                    }
                }
                Console.WriteLine();
            }
            int i = 0;
            while (i < A.GetLength(1))
            {
                int index = -1;
                for (int j = 0; j < A.GetLength(0); j++)
                {

                    if (A[j, i] == w)
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    int[,] newA = new int[n, A.GetLength(1) + 1];
                    for (int k = 0; k < index; k++)
                    {
                        for (int l = 0; l < A.GetLength(0); l++)
                        {
                            newA[l, k] = A[l, k];
                        }
                    }
                    for (int l = 0; l < A.GetLength(0); l++)
                    {
                        newA[l, index] = A[l, 0];
                    }

                    for (int t = index; t < A.GetLength(1); t++)
                    {
                        for (int p = 0; p < A.GetLength(0); p++)
                        {
                            newA[p, t + 1] = A[p, t];
                        }
                    }
                    A = newA;
                    i++;
                }
                i++;
            }
            Console.WriteLine();
            for (int q = 0; q < A.GetLength(0); q++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("{0,3}", A[q, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        public static void Task2()
        {
            //Удалите строки, содержащие число 4. Если такой строки нет, то вывести сообщение об этом.
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int i, j;
            int[,] a = new int[n, m];
            Console.WriteLine("\nЗадан массив:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0,3}", a[i, j] = rnd.Next(3, 9));
                }
                Console.WriteLine();
            }
            int g = 0;
            int[,] aNew = new int[n, m];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {

                    for (int v = 0; v < n; v++)
                    {

                        for (int l = 0; l < m; l++)
                        {
                            int o = -1;
                            if (a[v, l] == 4)
                            {
                                o = v;
                                for (int e = 0; e < m; e++)
                                {
                                    for (int u = o; u < n - 1; u++)
                                    {
                                        a[u, e] = a[u + 1, e];
                                    }
                                }
                                for (int h = 0; h < m; h++)
                                {
                                    a[n - 1, h] = 0;
                                }
                                g++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("\nИзмененный массив :");
            for (i = 0; i < n - g; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
            }
            if (g == 0)
            {
                Console.Write("4 нет");
            }
            Console.ReadKey();

        }
    }
}

