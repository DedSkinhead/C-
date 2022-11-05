using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            //m=a*g*3+a*a-75*w
            Console.WriteLine("Введите a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите g");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите w");
            int w = int.Parse(Console.ReadLine());
            int n = a*g*3+a*a-75*w;
            Console.WriteLine("n равно: "+n);
            Console.ReadKey();
        }
    }
}
