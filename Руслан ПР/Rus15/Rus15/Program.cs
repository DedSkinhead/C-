using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rus15
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ввести массив a1,a2,...,a26.Упорядочить элементы массива, стоящие на нечетных местах, в возрастающем порядке, а на четных -в убывающем.Подсчитать количество перестановок.
            int u = 0;
            Console.Write("Введите длину массива ");
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
            
            for (int i = 0; i < F.Length - 1; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = i + 1; j < F.Length; j++)
                    {
                        if (F[i]  >F[j])
                        {
                            temp = F[i];
                            F[i] = F[j];
                            F[j] = temp;
                            u++;
                        }
                    }
                }
                else
                {
                    for (int j = i + 1; j < F.Length; j++)
                    {
                        if (F[i] < F[j])
                        {
                            temp = F[i];
                            F[i] = F[j];
                            F[j] = temp;
                            u++;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Вывод отсортированного массива отрицательных чисел: ");
            for (int i = 0; i < F.Length; i++)
            {
                Console.Write("{0} ", F[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Вывод количества перестановок " + u);
            Console.ReadLine();
        }
    }
}
