using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            double y;
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            if (-1 <= x && x <= 2)
            {
                y = Math.Sqrt(Math.Abs(x + 1));
                Console.WriteLine("y равно: "+y);
            }
            if (x == 10)
            {
               // y = Math.Tan(2) ;
               // Console.WriteLine("y равно: " + y);
            }
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите z");
            int z = int.Parse(Console.ReadLine());
            if (z % 2 == 0)
            {
                z = z / 4;
                Console.WriteLine("Z равно: " + z);
            }
            if (z % 2 == 1)
            {
                z = z *5;
                Console.WriteLine("Z равно: "+z);
            }
            Console.ReadKey();
        }
    }
}
