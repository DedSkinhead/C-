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
            //Ввести числовой код созвездия. Вывести количество звезд в нем
            Console.WriteLine("Введите код созвездия от 1 до 7");
            char v = char.Parse(Console.ReadLine());
            switch (v)
            {
                case '1': Console.WriteLine("код созвездия: 2");break;
                case '2': Console.WriteLine("код созвездия: 3");break;
                case '3': Console.WriteLine("код созвездия: 4");break;
                case '4': Console.WriteLine("код созвездия: 5");break;
                case '5': Console.WriteLine("код созвездия: 6 ");break;
                case '6': Console.WriteLine("код созвездия: 7");break;
                case '7': Console.WriteLine("код созвездия: 8");break;
            }
            Console.ReadLine();
        }
    }
}
