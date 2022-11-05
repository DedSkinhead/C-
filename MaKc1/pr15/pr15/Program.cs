using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести массив x1,x2,...,x12. Требуется расположить положительные элементы, кратные 5,  в порядке убывания. Подсчитать количество перестановок.
            int u = 0;
            int[] F = new int[12];
            Random rand = new Random();
            Console.Write("Массив перед сортировкой: ");
            for (int i = 0; i < 12; i++)
            {
                F[i] = rand.Next(-15, 15);
                Console.Write("{0} ", F[i]);
            }
            int temp;
            int[] g = Array.FindAll(F, (val) => val % 5 == 0);
            for (int i = 0; i < g.Length - 1; i++)
            {
                    for (int j = i + 1; j < g.Length; j++)
                    {
                        if (g[i] < g[j])
                        {
                            temp = g[i];
                            g[i] = g[j];
                            g[j] = temp;
                            u++;
                        }
                    }
            }
            Console.WriteLine();
            Console.Write("Вывод отсортированного массива: ");
            for (int i = 0; i <g.Length; i++)
            {
                Console.Write("{0} ", g[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Вывод количества перестановок " + u);
            Console.ReadLine();
        }
    }
}
