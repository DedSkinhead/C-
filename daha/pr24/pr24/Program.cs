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
              //  Task2();
            }
            public static void Task1()
            {
                //1Вставить нулевую строку перед строками, в которых встретился элемент, равный 7.Если такой строки нет, то вывести сообщение об этом.
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
                        A[k, j] = rand.Next(0, 10);
                        Console.Write("{0,3}", A[k, j]);
                    }
                    Console.WriteLine();
                }
                int i = 0;
                while (i < A.GetLength(0))
                {
                    int index = -1;
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        ;
                        if (A[i, j] == 7)
                        {
                            index = i;
                            break;
                        }
                    }
                    if (index != -1)
                    {
                        int[,] newA = new int[A.GetLength(0) + 1, m];
                        for (int k = 0; k < index; k++)
                        {
                            for (int l = 0; l < A.GetLength(1); l++)
                            {
                                newA[k, l] = A[k, l];
                            }
                        }
                        for (int l = 0; l < A.GetLength(1); l++)
                        {
                            newA[index, l] = A[0, l];
                        }

                        for (int t = index; t < A.GetLength(0); t++)
                        {
                            for (int p = 0; p < A.GetLength(1); p++)
                            {
                                newA[t + 1, p] = A[t, p];
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
            //Удалить все столбцы, содержащие 6. Если такого столбца нет, то вывести сообщение об этом.
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int i, j, t;
            // Генерируем двумерный массив
            int[,] a = new int[n, m];
            Console.WriteLine("\nЗадан массив:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0,3}", a[i, j] = rnd.Next(3, 7));
                }
                Console.WriteLine();
            }
            int g = 0;
            int[,] aNew = new int[n, m];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {

                    for (int v = 0; v < m; v++)
                    {

                        for (int l = 0; l < n; l++)
                        {
                            int o = -1;
                            if (a[l, v] == 6)
                            {
                                o = v;
                                for (int e = 0; e < n; e++)
                                {
                                    for (int u = o; u < m - 1; u++)
                                    {
                                        a[e, u] = a[e, u + 1];
                                    }
                                }
                                for (int h = 0; h < n; h++)
                                {
                                    a[h, m - 1] = 0;
                                }
                                g++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("\nИзмененный массив :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m - g; j++)
                {
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
            }
            if (g == 0)
            {
                Console.Write("6 нет");
            }
            Console.ReadKey();

        }
    }
    }

