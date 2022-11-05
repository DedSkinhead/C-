using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            //запрашивает с клавиатуры два вещественных числа, и выводит на экран результат их умножения друг на друга в два столбика: первый столбик – вывод результата с точностью 3 знака после запятой, второй столбик – с точностью 5 знаков после запятой:
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("a*b = "+a+"*"+b+"="+Math.Round(a*b,3)+"\t"+ "a*b = " + a + "*" + b + "=" + Math.Round(a * b, 5));
            Console.Write("Для продолжения нажмите любую клавишу ...");
            Console.ReadKey();
        }
    }
}
