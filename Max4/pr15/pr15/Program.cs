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
            int u = 0;
            int k = int.Parse(Console.ReadLine());
            int[] F = new int[k];
            Random rand = new Random();
            Console.Write("Массив перед сортировкой: ");
            for (int i = 0; i < k; i++)
            {
                F[i] = rand.Next(-15, 15);
                Console.Write("{0} ", F[i]);
            }
            int temp;
            int[] g = Array.FindAll(F, (val) => val %2== 0);
            for (int i = 0; i < g.Length - 1; i++)
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
            Console.WriteLine();
            Console.Write("Вывод отсортированного массива четных чисел: ");
            for (int i = 0; i < g.Length; i++)
            {
                Console.Write("{0} ", g[i]);
            }
            for (int i = 0; i < F.Length - 1; i++)
            {
                F = Array.FindAll(F, (val) => val % 2 != 0);

                for (int j = i + 1; j < F.Length; j++)
                {
                    if (F[i] > F[j])
                    {
                        temp = F[i];
                        F[i] = F[j];
                        F[j] = temp;
                        u++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Вывод количества перестановок " + u);
            Console.Write("Вывод отсортированного массива нечетных чисел: ");
            for (int i = 0; i < F.Length; i++)
            {
                Console.Write("{0} ", F[i]);
            }
            Console.ReadLine();
        }
    }
}
