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
            //В двумерном массиве хранится информация об оценках каждого из 20 учеников класса по тому или иному предмету (в первой строке – информация об оценках первого ученика, во второй – второго). Общее число предметов равно 10. Определить среднюю оценку десятого ученика.
            int oLLeHKu = 10;
            int y4eHuK= 20;
            int[,] mas = new int[y4eHuK, oLLeHKu];
            Random ran = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < y4eHuK; i++)
            {
                for (int j = 0; j < oLLeHKu; j++)
                {
                    mas[i, j] = ran.Next(0, 10);
                    Console.Write("{0,3}", mas[i, j]);
                }
                Console.WriteLine();
            }
            double sum = 0;
            for (int i = 0; i < y4eHuK; i++)
            {
                for (int j = 0; j < oLLeHKu; j++)
                {
                    sum += mas[10,j];
                }
                break;
            }
            double Cp3Ha4 = sum / 10;
            Console.WriteLine("Средняя оценка: " + Cp3Ha4);
            Console.ReadKey();
        }
    }
}
