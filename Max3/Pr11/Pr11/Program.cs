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
            int[] T = new int[40];
            Random m = new Random();
            Console.WriteLine("Массив");
            int sum = 0;
            for (int i = 0; i < T.Length; i++)
            {
                T[i] = m.Next(0,64);
                Console.Write(" {0}", T[i]);
                if (T[i] % 7 == 0 && T[i] % 5 == 0)
                {
                    sum+=T[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма: "+sum);
            Console.ReadLine();
        }
    }
}
