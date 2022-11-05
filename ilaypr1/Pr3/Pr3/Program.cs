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
            //запрашивает с клавиатуры три целых числа, и выводит на экран результат деления первого числа на PI (с точностью 4 знака после запятой), сумму данных чисел и результат деления третьего числа на Е (с точностью 3 знака после запятой): 
            Console.Write("a = ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = int.Parse(Console.ReadLine());
            double PI =Math.Round(a/3.1416,4);
            int sum = Convert.ToInt32(a+b+c);
            double zad3 = Math.Round(c / 2.718, 3);
            Console.Write("a/PI="+a+"/3,1416="+PI+"   ");
            Console.Write("a+b+c="+a+"+"+b+"+"+c+"="+sum+"   ");
            Console.WriteLine("c/E="+c+"/2,718="+zad3+"   ");
            Console.Write("Для продолжения нажмите любую клавишу ...");
            Console.ReadKey();
        }
    }
}
