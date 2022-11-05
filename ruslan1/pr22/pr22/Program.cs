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
            //В зрительном зале 23 ряда, в каждом из которых 40 мест (кресел). Информация о проданных билетах хранится в двумерном массиве, номера строк которого соответствуют номерам рядов, а номера столбцов – номерам мест. Если билет на то или иное место продан, то соответствующий элемент массива имеет значение 1, в противном случае – 0. Определить общее число свободных мест в зрительном зале.
            int rows = 23, cols = 40;
            int[,] sale = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sale[i, j] = rand.Next(0, 2);
                    Console.Write("{0,3}", sale[i, j]);
                }
            }
            int n = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    n += sale[i, j];
                }
            }
            int b = rows * cols - n;
            Console.WriteLine();
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
