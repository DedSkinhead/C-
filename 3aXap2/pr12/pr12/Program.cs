using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    a[i] = 0;
                    break;
                }
            }
            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]<min && a[i] < 0)
                {
                    min = a[i];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
