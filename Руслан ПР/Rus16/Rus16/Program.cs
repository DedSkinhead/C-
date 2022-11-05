using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rus16
{
    class Program
    {
        static void Main(string[] args)
        {
           // В прямоугольной матрице, размерностью n*m, заполненной случайным образом числами из промежутка[-40, 30], найти сумму и количество элементов каждого столбца с заданным условием(хранить эти значения в массивах):  элементы, кратные k1 или k2.
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k1");
            int k1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k2");
            int k2 = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, m];
            Random ran = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = ran.Next(-40, 30);
                }
            }
            Console.WriteLine();
            for (int j = 0; j < m; j++)
            {
                int g = 0;
                int y = 0;
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0}\t", mas[i, j]);
                    if (mas[j, i] % k1 == 0 && mas[j, i] % k2 == 0)
                    {
                        g = g + mas[j, i];
                        y++;
                    }
                }
                Console.WriteLine("Сумма {0} и количетво  {1} столбца  {2}", g, y, j);
            }
           // В прямоугольной матрице, размерностью n*m, заполненной случайным образом числами из промежутка[-40, 30], найти сумму и количество элементов каждой строки с заданным условием(хранить эти значения в массивах): элементы, попадающие в промежуток от А до В.
           Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите w");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите e");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите А");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите В");
            int B = int.Parse(Console.ReadLine());
            int[,] maa = new int[w, e];
            Random raa = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < e; j++)
                {
                    maa[i, j] = raa.Next(-18, 25);
                }
            }
            Console.WriteLine();
            for (int j = 0; j < e; j++)
            {
                int g = 0;
                int y = 0;
                for (int i = 0; i < w; i++)
                {
                    Console.Write("{0}\t", mas[i, j]);
                    if (mas[i, j] >= A && mas[i, j] <= B)
                    {
                        g = g + mas[i, j];
                        y++;
                    }
                }
                Console.WriteLine("сумма {0} и количетво  {1} строки  {2}", g, y, j);
            }
            Console.ReadLine();
        }
    }
}
