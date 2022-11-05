using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр22
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int mes = 3;
            int mag = 3;
            int[,] mas = new int[mag, mes];
            Random ran = new Random();
            Console.WriteLine("Массив");
            int sred_znach = 0;
            for (int i = 0; i < mag; i++)
            {
                for (int j = 0; j < mes; j++)
                {
                    mas[i, j] = ran.Next(0, 10);
                    Console.Write("{0,3}", mas[i, j]);
                    
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < mag; i++)
            {
                for (int j = 0; j < mes; j++)
                {
                    sred_znach += mas[b, j];
                    
                }
                break;
            }
                    Console.Write(sred_znach/12);
            Console.ReadKey();
        }
    }
}
