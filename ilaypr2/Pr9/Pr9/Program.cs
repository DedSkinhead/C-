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
            for (int i = 10; i <100; i++)
            {
                if (i % 11 != 0)
                    Console.Write( i+";");
            }
            Console.WriteLine();
            Console.WriteLine("Цикл while");
            int a = 10;
            Console.WriteLine();
            while (a < 100)
            {
                if (a % 11 != 0)
                    Console.Write(  a+ ";");
                a++;
            }
            Console.WriteLine();
            Console.WriteLine("Цикл do");
            a = 10;
            Console.WriteLine();
            do
            {
                if (a % 11 != 0)
                    Console.Write( a+ ";");
                a++;
            }
            while (a < 100);
            Console.ReadLine();
        }
    }
}
