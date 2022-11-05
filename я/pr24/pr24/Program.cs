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
            //1Вставить после всех строк, в которых есть заданное число В, последнюю строку. Если такой строки нет, то вывести сообщение об этом.
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите заданное число");
            int р = int.Parse(Console.ReadLine());
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
                {

                    if (A[i, j] == р)
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    int[,] newA = new int[A.GetLength(0) + 1, m];
                    for (int k = 0; k <= index; k++)
                    {
                        for (int l = 0; l < A.GetLength(1); l++)
                        {
                            newA[k, l] = A[k, l];
                        }
                    }
                    for (int l = 0; l < A.GetLength(1); l++)
                    {
                        newA[index + 1, l] = A[m - 1, l];
                    }

                    for (int t = index + 1; t < A.GetLength(0); t++)
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
        //Удалить столбцы с номерами, кратными k. Если такого столбца нет, то вывести сообщение об этом.
         Console.Write("Введите элемент: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int i, j;
            // Генерируем двумерный массив
            int[,] a = new int[n, m];
            Console.WriteLine("\nЗадан массив:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0,3}", a[i, j] = rnd.Next(-10, 10));
                }
                Console.WriteLine();
            }
            int g = 0;
            int[,] aNew = new int[n, m];
                    for (int v = 0; v < m; v++)
                    {
                            int o = -1;
                            if (v % q==0)
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

            Console.WriteLine("\nИзмененный массив :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m - g; j++)
                {
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
            }
            if (q == 0)
            {
                Console.Write("6 нет");
            }
            Console.ReadKey();
        }

}
}
