using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            double x, a, b, y;
            Console.WriteLine("Введите х");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите а");
             a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите b");
             b = Convert.ToInt32(Console.ReadLine());
             y=Math.Pow(Math.Cos((x+78*a/2*Math.Sqrt(a))),2)+Math.Cos(x/(a/b));
            Console.WriteLine(y);
            Console.WriteLine("Задание 1");
            double x1, y1, z1,a1 ,b1;
            Console.WriteLine("Введите х");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите z");
            z1 = Convert.ToInt32(Console.ReadLine());
            a1 = ((2*Math.Cos(x1-Math.PI/6))/(1/2+Math.Pow(Math.Sin(y1),2)));
            b1 = 1+((Math.Pow(z1,2))/(3+Math.Pow(z1,2)/5));
            Console.WriteLine(b1);
            Console.WriteLine(a1);
            Console.ReadLine();
        }
    }
}
