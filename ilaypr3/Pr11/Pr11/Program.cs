using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] T = new int[70];
            Random m = new Random();
            Console.WriteLine("Массив");
            int kol = 0;
            for (int i = 0; i < T.Length; i++)
            {
                T[i] = m.Next(-20,20);
                Console.Write(" {0}", T[i]);
                if (T[i] < 0 && T[i] % 5 == 0)
                {
                    kol++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество отрицательных чисел: "+kol);
            Console.ReadLine();
        }
    }
}
