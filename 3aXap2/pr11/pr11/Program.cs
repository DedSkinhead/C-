using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] f = new int[4];
            Random m = new Random();
            Console.WriteLine("Массив");
            int sum = 0;
            for (int i = 0; i < f.Length; i++)
            {
                f[i] = m.Next(-20,0);
                Console.Write(" {0}", f[i]);
                if (f[i]%2!=0)
                {
                    sum+=f[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
