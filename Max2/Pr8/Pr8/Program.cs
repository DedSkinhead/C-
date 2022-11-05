using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести номер квартиры в доме. Вывести количество жителей этой квартиры
            Console.WriteLine("Введите номер квартиры от 1 до 7");
            char v = char.Parse(Console.ReadLine());
            switch (v)
            {
                case '1': Console.WriteLine("4");break;
                case '2': Console.WriteLine("15");break;
                case '3': Console.WriteLine("2");break;
                case '4': Console.WriteLine("3");break;
                case '5': Console.WriteLine("1 ");break;
                case '6': Console.WriteLine("1");break;
                case '7': Console.WriteLine("1");break;
            }
            Console.ReadLine();
        }
    }
}
