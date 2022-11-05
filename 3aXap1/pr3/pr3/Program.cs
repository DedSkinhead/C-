using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.запрашивает с клавиатуры три целых числа, и выводит на экран сумму данных чисел в прямом и обратном порядке: 
            WriteLine("Введите первое число");
            int a = ToInt32(ReadLine());
            WriteLine("Введите второе число");
            int b = ToInt32(ReadLine());
            WriteLine(a + "+" + b + "=" + b + "+" + a);
            ReadKey();
        }
    }
}
