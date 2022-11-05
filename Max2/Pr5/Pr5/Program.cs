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
            //22.Периметр квадрата равен периметру треугольника со сторонами A см, B см и C см. Написать программу, которая вычисляет длина стороны квадрата?
            Console.WriteLine("A");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("B");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("C");
            int c = int.Parse(Console.ReadLine());
            int kva = (a + b + c) / 4;
            Console.WriteLine("Сторона квадрата: "+kva);
            Console.ReadLine();
        }
    }
}
