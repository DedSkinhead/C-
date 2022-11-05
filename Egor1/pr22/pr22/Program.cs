using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr22
{
    class Program
    {
        static void Main(string[] args)
        {
            //В двумерном массиве хранится информация о количестве учеников в каждом классе каждой параллели школы с первой по одиннадцатую (в первой строке – информация о классах первой параллели, во второй – второй параллели и т.д.) В каждой параллели школы имеются четыре класса. Определить общее чисто учеников в параллели 5-х классов.
            int par = 11, klac =4;
            int[,] F = new int[par, klac];
            Random rand = new Random();
            for (int i = 0; i < par; i++)
            {
                for (int j = 0; j < klac; j++)
                {
                    F[i, j] = rand.Next(10, 20);
                    Console.Write("{0,20}", F[i, j]);
                }
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < klac; i++)
                sum += F[4, i];
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
