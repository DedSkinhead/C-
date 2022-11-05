using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr22Avdeev
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 25, cols = 36;
            int[,] sale =new int[rows,cols];
            Random rand = new Random(); 
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    sale[i, j] = rand.Next() % 2;
            int n = 0;
            for (int j = 0; j < cols; j++)
                n += sale[12, j];
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
