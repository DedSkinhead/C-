using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr9
{
    class Program
    {
        static void Main(string[] args)
        {
            //все двухзначные числа, в записи которых все цифры разные.
            Console.WriteLine("Цикл for");
            for (int i = 100; i <999; i++)
            {
                if (i%3==0&& i % 7 == 0)
                    Console.Write( i+";");
            }
            Console.WriteLine();
            Console.WriteLine("Цикл while");
            int a = 100;
            Console.WriteLine();
            while (a < 999)
            {
                if (a % 3 == 0 && a % 7 == 0)
                    Console.Write(  a+ ";");
                a++;
            }
            Console.WriteLine();
            Console.WriteLine("Цикл do");
            a = 100;
            Console.WriteLine();
            do
            {
                if (a % 3 == 0 && a % 7 == 0)
                    Console.Write( a+ ";");
                a++;
            }
            while (a < 999);
            Console.ReadLine();
        }
    }
}
