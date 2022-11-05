using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace pr6
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        static void Task1() {
            WriteLine("задание 1");
            WriteLine("Введите x");
            int x = ToInt32(ReadLine());
            WriteLine("Введите a");
            int a = ToInt32(ReadLine());
            WriteLine("Введите b");
            int b = ToInt32(ReadLine());
            double y = 3 * Math.Sqrt(((5 * x - 9) / (7.5 * a * b)) + 18) + Math.Pow(Math.E, 2 * x + (0.5 / a));
            WriteLine(y);
            ReadKey();
        }
        static void Task2()
        {
            WriteLine("задание 2");
            WriteLine("Введите x");
            int x = ToInt32(ReadLine());
            WriteLine("Введите y");
            int y = ToInt32(ReadLine());
            WriteLine("Введите z");
            int z = ToInt32(ReadLine());
            double a = (3 + Math.Pow(Math.E, y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(z)));
            double b = 1 + Math.Abs(y - x) + Math.Pow((y - x), 2) / 2 + Math.Pow(Math.Abs(y - x), 3) / 3;
            WriteLine(a);
            WriteLine(b);
            ReadKey();
        }

        
    }
}
