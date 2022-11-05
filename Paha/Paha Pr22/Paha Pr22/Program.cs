using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paha_Pr22
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 12;
            int chel = 2;
            int[,] mas = new int[chel, mes];
            Random ran = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < chel; i++)
            {
                for (int j = 0; j < mes; j++)
                {
                    mas[i, j] = ran.Next(0, 10);
                    Console.Write("{0,3}", mas[i, j]);
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < chel; i++)
            {
                sum += mas[i, 5];
            }
            Console.WriteLine("Сумма: "+sum);
            Console.ReadKey();
        }
    }
}
