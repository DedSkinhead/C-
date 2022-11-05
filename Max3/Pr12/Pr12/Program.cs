using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] T = new int[8];
            Random m = new Random();
            Console.WriteLine("Массив");
            int sum = 0;
            int min = int.MaxValue;
            for (int i = 0; i < T.Length; i++)
            {
                T[i] = m.Next(0, 100);
                Console.Write(" {0}", T[i]);
                if (T[i] % 2 == 0)
                {
                    sum += T[i];
                }
                if (T[i] >= 0 && T[i] % 2 == 0 && T[i] < min)
                {
                    min = T[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Минимальный элемент: " + min);
            Console.ReadLine();
        }
    }
}
