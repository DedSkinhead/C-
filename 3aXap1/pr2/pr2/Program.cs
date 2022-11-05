using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            //n=15*p-3*a+g*5-8
            WriteLine("Введите p");
            int p = ToInt32(ReadLine());
            WriteLine("Введите a");
            int a = ToInt32(ReadLine());
            WriteLine("Введите g");
            int g = ToInt32(ReadLine());
            int n = 15 * p - 3 * a + g * 5 - 8;
            WriteLine("n= "+ n);
            ReadKey();

        }
    }
}
