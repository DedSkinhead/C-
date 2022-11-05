using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
        }
        static void Task1()
        {
            //В прямоугольной матрице, размерностью m*n, заполненной случайным образом числами из промежутка[-10, 30], найти сумму и количество элементов каждой строки с заданным условием(хранить эти значения в массивах):  элементы, кратные S.
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите s");
            int s = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, m];
            Random ran = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = ran.Next(-10, 30);
                }
            }
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                int g = 0;
                int y = 0;
                for (int i = 0; i < m; i++)
                {
                    Console.Write("{0}\t", mas[j, i]);
                    if (mas[j, i] % s == 0)
                    {
                        g = g + mas[j, i];
                        y++;
                    }
                }
                Console.WriteLine("Сумма {0} и количетво  {1} строка  {2}", g, y, j);
            }
            Console.ReadKey();
        }
        static void Task2()
        {
            //В прямоугольной матрице, размерностью m*n, заполненной случайным образом числами из промежутка [-15,25], найти произведение и количество элементов каждого столбца с заданным условием (хранить эти значения в массивах): элементы, попадающие в промежуток от k1 до k2.
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начало промежутка");
            int k1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец промежутка");
            int k2 = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, m];
            Random ran = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = ran.Next(-10, 25);
                    Console.Write("{0,3}", mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int j = 0; j < m; j++)
            {
                int g = 1;
                int y = 0;
                for (int i = 0; i < n; i++)
                {
                    
                    if (mas[i, j] > k1  && mas[i,j] < k2)
                    {
                        g = g * mas[i ,j];
                        y++;
                    }
                }
                Console.WriteLine("Произведение {0} и количетво  {1} столбца  {2}", g, y, j);
            }
            Console.ReadKey();
        }
        
    }
}
