using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано четырехзначное число. Найти число, образуемое при перестановке первой и последней цифр
            int f = Int32.Parse(Console.ReadLine());
            int g = (f % 10)*1000;
            int r = (f - (f % 1000))/1000;
            f = (f-((f % 10) + (f-f % 1000))) + g + r;
            Console.WriteLine(f);
            Console.ReadKey();


        }
    }
}
