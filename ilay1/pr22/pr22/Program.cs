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
            //Три группы студентов, в каждой из которых 20 человек, в сессию сдавали по 3 экзамена. Сведения об оценках каждой группы хранятся в двумерных массивах. Определить лучшую по средней оценке группу.
            int[,] mas = new int[3, 20];
            int[,] mas2 = new int[3, 20];
            int[,] mas3 = new int[3,20];
            Random ran = new Random();
            double o =0;
            double w =0;
            double e =0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    mas[i, j] = ran.Next(1, 6);
                    Console.Write("{0,3}", mas[i, j]);
                    o += mas[i, j];
                }
                Console.WriteLine();
            }
            o = o / 60;
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    mas2[i, j] = ran.Next(1, 6);
                    Console.Write("{0,3}", mas2[i, j]);
                   e += mas2[i, j];
                }
                Console.WriteLine();
            }
            e = e / 60;
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    mas3[i, j] = ran.Next(1, 6);
                    Console.Write("{0,3}", mas3[i, j]);
                    w += mas3[i, j];
                }
                Console.WriteLine();
            }
            w = w / 60;
            Console.WriteLine();
            Console.WriteLine(o);
            Console.WriteLine(e);
            Console.WriteLine(w);
           
            if (o > w && o > e)
            {
                Console.WriteLine("Первая группа");
            }
            if(e>o && e > w)
            {
                Console.WriteLine("Вторая группа");
            }
             if (w > o && w > e)
            {
                Console.WriteLine("Третья группа");
            }
            Console.ReadKey();

        }
    }
}
