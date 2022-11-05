using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5
{
    class Program
    {
        static void Main(string[] args)
        {
            //На фабрике должны сшить по плану K пальто за R дней. Ежедневно шили на N пальто больше нормы. Написать программу, которая вычисляет cколько пальто было сшито? 
            Console.WriteLine("Количество пальто нужно");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество дней");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("НА больше в день");
            int n = int.Parse(Console.ReadLine());
            int kol = k  + r * n;
            Console.WriteLine("Количество польто сшито: "+kol);
            Console.ReadLine();
        }
    }
}
