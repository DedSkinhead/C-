using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pahf_Pr24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
        }
            public static void Task1() {
                //Вставить перед всеми строками, в которых есть 0, первую строку.
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
                        A[k, j] = rand.Next(-1, 5);
                        Console.Write("{0,3}", A[k, j]);
                    }
                    Console.WriteLine();
                }
                int i = 0;
                while (i < A.GetLength(0))
                {
                    int index = -1;
                    for (int j = 0; j < A.GetLength(1); j++)
                    {;
                        if (A[i, j] == 0)
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
            //Удалите столбцы, в которых находится максимальный элемент. 
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int i, j, t;   // Счетчики циклов

            // Генерируем двумерный массив
            int[,] a = new int[n, m];
            Console.WriteLine("\nЗадан массив:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0,3}", a[i, j] = rnd.Next(1, 100));
                }
                Console.WriteLine();
            }

            // Поиск столбца, содержащего максимальный элемент
            int max = a[0, 0];
            int indexJ = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        indexJ = j;
                    }
                }
            }
           
            int[,] aNew = new int[n, m - 1];
            for (i = 0; i < n; i++)
            {
                for (j = t = 0; j < m; j++, t++)
                {
                    if (j < indexJ)
                        aNew[i, t] = a[i, j];
                    else if (j == indexJ)
                        j++;
                    aNew[i, t] = a[i, j];
                }
            }
            Console.WriteLine("\nИзмененный массив :", indexJ + 1);
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m - 1; j++)
                {
                    Console.Write("{0,3}", aNew[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


    }
}


