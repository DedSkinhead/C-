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
             y=Math.Sqrt(((Math.Log(x/a))+(b/(2*x)))/(a-(3*b)*(Math.Sqrt(x+5))))-16;
            Console.WriteLine(y);
            Console.WriteLine("Задание 1");
            double x1, y1, z1,a1 ,b1;
            Console.WriteLine("Введите х");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите z");
            z1 = Convert.ToInt32(Console.ReadLine());
            a1 = (1 + Math.Pow((Math.Sin(x1 + y1)), 2)) / (2 + Math.Abs(x1 - (2 * x1) / (1 + Math.Pow(x1, 2) * +Math.Pow(y1, 2))));
            b1 = Math.Pow((Math.Cos(Math.Atan(1 / z1))), 2);
            Console.WriteLine(b1);
            Console.WriteLine(a1);
            Console.ReadLine();
        }
    }
}
