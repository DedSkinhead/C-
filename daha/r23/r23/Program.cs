using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            int[,] A = new int[m, n];
            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rand.Next(-1,6) ;
                    Console.Write("{0,3}", A[i, j]);
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < n; i++)
            {
                int temp;
                int indexFirst = -1;
                int indexLast = -1;
                for (int k = i; k < m; k++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (A[k,j]==0 && indexFirst == -1)
                        {
                            indexFirst = k;
                        }
                        if (A[k, j] == 0 && indexFirst != -1)
                        {
                            indexLast = k;
                           
                        }
                    }
                }
                if (indexFirst != -1 && indexLast != -1)
                {
                    Console.WriteLine("indexFirst: " + indexFirst + "indexLast: " + indexLast);
                    for (int j = 0; j < n; j++)
                    {
                        temp = A[indexFirst, j];
                        A[indexFirst, j] = A[indexLast, j];
                        A[indexLast, j] = temp;
                    }
                }
                Console.WriteLine("_______________________________");
                break;
            }
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
