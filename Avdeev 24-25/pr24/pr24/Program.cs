﻿using System;
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
        static void Task1()
        {
            //1Вставить второй столбец после столбцов, в которых все элементы больше 3. Если такого столбца нет, то вывести сообщение об этом.
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            int[,] A = new int[n, m];
            Random rand = new Random();
            for (int k = 0; k < A.GetLength(0); k++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[k, j] = rand.Next(3, 10);
                    Console.Write("{0,3}", A[k, j]);
                    
                }
                Console.WriteLine();
            }
            int w = 0;
            int i = 0;
            while (i < A.GetLength(1))
            {
                w = 0;
                int index = -1;
                for (int j = 0; j < A.GetLength(0); j++)
                {
                    if (A[j, i] >= 3)
                    {
                        w++;
                    }
                    
                }
                    if (w==m)
                    {
                        index = i;
                    }
                if (index != -1)
                {
                    int[,] newA = new int[n, A.GetLength(1) + 1];
                    for (int k = 0; k < index+1; k++)
                    {
                        for (int l = 0; l < A.GetLength(0); l++)
                        {
                            newA[l, k] = A[l, k];
                        }
                    }
                    for (int l = 0; l < A.GetLength(0); l++)
                    {
                        newA[l, index+1] = A[l,3];
                    }

                    for (int t = index+1; t < A.GetLength(1); t++)
                    {
                        for (int p = 0; p < A.GetLength(0); p++)
                        {
                            newA[p, t +1] = A[p, t];
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
        static void Task2()
        {
            //Удалите строки, содержащие минимальный элемент.
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int i, j;
            int[,] a = new int[n, m];
            Console.WriteLine("\nЗадан массив:");
            int min = int.MaxValue;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0,3}", a[i, j] = rnd.Next(3, 7));
                }
                Console.WriteLine();
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
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
                            if (a[v, l] == min)
                            {
                                o = v;
                                for (int u = o; u < n - 1; u++)
                                {
                                    for (int e = 0; e < m; e++)
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
            Console.ReadKey();
        }
    
        
    }
}
