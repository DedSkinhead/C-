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
            //В прямоугольной матрице, размерностью n*m, заполненной случайным образом числами из промежутка [-5,25], найти произведение и количество элементов каждой строки с заданным условием (хранить эти значения в массивах):  нечётные элементы, меньшие 10.
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, m];
            Random ran = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = ran.Next(-5, 25);
                }
            }
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                int g = 1;
                int y = 0;
                for (int i = 0; i < m; i++)
                {
                    Console.Write("{0}\t", mas[j, i]);
                    if (mas[j, i] % 2 != 0 && mas[j, i] <10)
                    {
                        g = g * mas[j, i];
                        y++;
                    }
                }
                Console.WriteLine("Произведение {0} и количетво  {1} строка  {2}", g, y, j);
            }
            //В прямоугольной матрице, размерностью n*m, заполненной случайным образом числами из промежутка [1,10], найти сумму и количество элементов каждого столбца с заданным условием (хранить эти значения в массивах): элементы чётные, попадающие в промежуток от 3 до 9.
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите w");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите e");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите А");
            int[,] maa = new int[w, e];
            Random raa = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < e; j++)
                {
                    maa[i, j] = raa.Next(1, 10);
                }
            }
            Console.WriteLine();
            for (int j = 0; j < w; j++)
            {
                int g = 0;
                int y = 0;
                for (int i = 0; i < e; i++)
                {
                    Console.Write("{0}\t", maa[i, j]);
                    if (maa[j , i] %2==0 && maa[j, i]<9 && maa[j, i] > 3)
                    {
                        g = g + maa[j, i];
                        y++;
                    }
                }
                Console.WriteLine("сумма {0} и количетво  {1} столбец  {2}", g, y, j);
            }
            Console.ReadKey();
        }
    }
}
