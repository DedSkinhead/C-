using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            int min = int.MaxValue;
            int g = 0;
            int w = 0;
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                A[i] = rand.Next(3, 4);
                Console.Write(" {0}", A[i]);
            }
            Console.WriteLine();
            for (int i = 0; i <B.Length; i++)
            {
                B[i] = A[N-i-1];
                Console.Write(" {0}", B[i]);
            }
            for (int i = 0; i < N; i++)
            {
                if(B[i]==A[i])
                {
                    g++;
                }
                if (A[i]<min&&A[i]%2==0)
                {
                    min = A[i];
                    w++;
                }
            }
            Console.WriteLine();
            if (g == N)
            {
                Console.WriteLine("Перевертышь");
            }
            else
            {
                Console.WriteLine("Не перевортышь");
            }
            if (w == 0)
            {
                Console.WriteLine("Минимального числа нет");
            }
            else
            {
                Console.WriteLine("Минимально четное число - " + min);
            }
            Console.ReadLine();

        }
    }
}
