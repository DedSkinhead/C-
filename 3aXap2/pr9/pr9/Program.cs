using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 999; i++)
            {
                if (i%10==(int)(i/100))
                {
                    Console.Write(i + ",");
                }
            }
            Console.WriteLine();
            int n = 100;
            while (n<=999)
            {
                if (n % 10 == (int)(n / 100))
                {
                    Console.Write(n + ",");
                }
                n++;
            }
            Console.WriteLine();
            int m = 100;
            do
            {
                if (m % 10 == (int)(m / 100))
                {
                    Console.Write(m + ",");
                }
                m++;
            }
            while (m<=999);
            Console.ReadKey();
        }
    }
}

