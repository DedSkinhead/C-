using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace pr5
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Для института диетологии необходимо написать программу расчета нормальной массы тела по следующим формулам: М1=50+(рост-150)*0,75+(возраст-21):4;  М2 = (рост *объем груди):240;  Мнорма = (М1 + М2):2.
            WriteLine("Введите рост");
            double rost = ToDouble(ReadLine());
            WriteLine("Введите возраст");
            double voz = ToDouble(ReadLine());
            WriteLine("Введите объем груди");
            double grud = ToDouble(ReadLine());
            double m1=50+(rost-150)* 0.75 + (voz - 21) / 4;
            double m2 = (rost * grud) / 240;
            double mnorm = (m1 + m2) / 2;
            WriteLine("Норма веса "+mnorm);
            ReadKey();





        }
    }
}
