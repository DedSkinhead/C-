using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace pr7
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Задание 1");
            WriteLine("ВВедите x");
            int x = Convert.ToInt32(ReadLine());
            double y = 0;
            if (-2 <= x && x <= 2)
            {
                y = 3 / 2 * Math.Pow(x, 2) - Math.Tan(x);
            }
            if (x > 2)
            {
                y = Math.Pow(Math.E, x + 1) + Math.Sqrt(Math.Pow(x, 3));
            }
            if (x < -2)
            {
                y = 2 / 3 * Math.Sin(Math.Pow(x, 2)) + Math.Log(Math.Abs(x));
            }
            WriteLine(y);
            WriteLine("Задание 1");
            WriteLine("Введите пятизначное число");
            int n = Convert.ToInt32(ReadLine());
            WriteLine("Введите нужную цифру");
            int b = Convert.ToInt32(ReadLine());
            if (n < 10000 || n > 99999)
            {
                WriteLine("Вы ввели не правильно число");
            }
            else
            {
                int h = 0;
                int i = 0;
                int f = 1;
                while (i < 5)
                {
                    if (n % 10 == b)
                    {
                        WriteLine(f);
                        h++;
                        break;
                    }
                    else
                    {
                        n=n/ 10;
                        f++;
                        i++;
                    }
                }
                if (h == 0)
                {
                    WriteLine(0);
                }
            }
            ReadKey();
        }
    }
}
