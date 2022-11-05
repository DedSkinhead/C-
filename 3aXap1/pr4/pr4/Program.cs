using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace pr4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано четырёхзначное число. Найти произведение числа единиц и сотен в нем.
            WriteLine("Введите четырехзначное число");
            int a = ToInt32(ReadLine());
            int ed = a ;
            int sot = a /100;
            if (a <= 1000 || a >= 9999)
            {
                WriteLine("Не правильное число");
            }
            else
            {
                int proiz = ed * sot;
                WriteLine(proiz);
            }
            ReadKey();

        }
    }
}
