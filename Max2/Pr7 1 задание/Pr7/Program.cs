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
            if (x>20)
            {
                Console.WriteLine("y равно: "+4);
            }
            if (x < 20)
            {
               y = Math.Pow(x,2)+x-1 ;
                Console.WriteLine("y равно: " + y);
            }
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите z");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите t");
            int t = int.Parse(Console.ReadLine());
            int sum = z + t;
            if (z+t>z*t)
            { 
                Console.WriteLine("равно: " +sum);
            }
            else
            {
                if (z < t)
                {
                    z += 25;
                    Console.WriteLine("Z равно: " + z);
                }
                else
                {
                    t += 25;
                    Console.WriteLine("Z равно: " + t);
                }
                
            }
            Console.ReadKey();
        }
    }
}
