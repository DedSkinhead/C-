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
            //Ввести массив a1,a2,...,a15. Расположить ненулевые элементы по возрастанию. Подсчитать количество перестановок.
            int u = 0;
            Console.Write("Введите длину массива ");
            int k = 15;
            int[] F = new int[k];
            Random rand = new Random();
            Console.Write("Массив перед сортировкой: ");
            for (int i = 0; i < k; i++)
            {
                F[i] = rand.Next(-5, 3);
                Console.Write("{0} ", F[i]);
            }
            int temp;
            int[] g = Array.FindAll(F, (val) => val != 0);
            for (int i = 0; i < g.Length - 1; i++)
            {
                if (g[i] != 0)
                {
                    for (int j = i + 1; j < g.Length; j++)
                    {
                        if (g[i] > g[j])
                        {
                            temp = g[i];
                            g[i] = g[j];
                            g[j] = temp;
                            u++;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Вывод отсортированного массива отрицательных чисел: ");
            for (int i = 0; i < g.Length; i++)
            {
                Console.Write("{0} ", g[i]);
            }
            Console.ReadKey();
        }
        }
}
