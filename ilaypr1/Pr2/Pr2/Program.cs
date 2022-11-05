using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            //n=j*p*43-7*a+5*y
            Console.WriteLine("Введите j");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите p");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = int.Parse(Console.ReadLine());
            int n = j * p * 43 - 7 * a + 5 * y;
            Console.WriteLine("n равно: "+n);
            Console.ReadKey();
        }
    }
}
