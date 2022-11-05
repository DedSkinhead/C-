using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массив C размером 12 заполняется с клавиатуры. Найти сумму элементов, расположенных после последнего минимального элемента.
            int min;
            int res = 0;
            int count = 0;
            int[] a = new int[5];
            for (int i = 0; i <a.Length; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            min = a[0];
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    count = i;
                }
            }
            for (int i = count + 1; i < a.Length; i++)
            {
                res += a[i];
            }
            Console.WriteLine("Сумма элементов, расположенных после последнего минимального элемента: " + res);
            Console.ReadLine();
        }
    }
}
