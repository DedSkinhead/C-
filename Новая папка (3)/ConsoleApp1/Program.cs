using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    mas[i, j] = ran.Next(-15, 20);

                }
            }
            Console.WriteLine();
            for (int j = 0; j < m; j++)
            {
                int g = 1;
                int y = 0;

                for (int i = 0; i < n; i++)
                {

                    Console.Write("{0}\t", mas[i, j]);
                    if (mas[j, i] % 2 != 0 && mas[j, i] % 3 == 0)
                    {
                        g = g * mas[j, i];
                        y++;
                    }
                }
                Console.WriteLine("Произведение {0} и количетво  {1} столбца  {2}", g, y, j);
            }

            Console.WriteLine("Задание 2");




            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите w");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите e");
            int e = int.Parse(Console.ReadLine());
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
                    if (mas[i, j] >= 15 && mas[i, j] <= 25)
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
