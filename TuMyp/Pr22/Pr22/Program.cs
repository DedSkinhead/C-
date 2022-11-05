using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr22
{
    class Program
    {
        static void Main(string[] args)
        {//Дан двумерный массив из 2 строк и 22 столбцов. В его первой строке записано количество мячей, забитых футбольной командой в той или иной игре, во второй – количество пропущенных мячей в этой же игре. Определить, в скольких играх разность забитых и пропущенных мячей была большей или равной трем.
            int m9l4 = 2;
            int urpbl = 22;
            int[,] mas = new int[m9l4, urpbl];
            Random ran = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < m9l4; i++)
            {
                for (int j = 0; j < urpbl; j++)
                {
                    mas[i, j] = ran.Next(0, 6);
                    Console.Write("{0,3}", mas[i, j]);
                }
                Console.WriteLine();
            }
            int n = 0;
            for (int i = 0; i < urpbl; i++)
            {
                int raz = 0;
                for (int j = 0; j+1 < m9l4; j++)
                {
                    raz = mas[j, i] - mas[j + 1,i] ;
                   Console.WriteLine(raz);
                }
                if (raz >= 3){
                    n++;
                }
                
            }
           Console.WriteLine("Количество разностей больших или равных 3: "+n);
            Console.ReadKey();
        }
    }
}
