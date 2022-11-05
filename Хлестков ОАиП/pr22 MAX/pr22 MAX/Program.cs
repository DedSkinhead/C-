using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr22_MAX
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дан двумерный массив из 2 строк и 22 столбцов. В его первой строке записано количество мячей, забитых футбольной командой в той или иной игре, во второй – количество пропущенных мячей в этой же игре. Определить общее число очков, набранных командой (за выигрыш дается 3 очка, за ничью — 1, за проигрыш — 0).
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
            int v = 0;
            for (int j = 0; j < urpbl; j++)
            {
                for (int i = 0; i < m9l4; i++)
                {
                    if(mas[i,j]> mas[i+1, j ]){
                        v += 3;
                    }
                    else if (mas[i, j] == mas[i+1, j ]){
                        v += 1;
                    }
                    else if (mas[i, j] < mas[i+1, j]){
                        v += 0;
                    }
                    break;
                }
            }
            Console.WriteLine("Количество очков "+v);
            Console.ReadKey();
        }
    }
}
