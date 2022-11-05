using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сколько значений в p нужно ввести 1 задание \n");
            int ti = Convert.ToInt16(Console.ReadLine());
            int srz = 0;
            int srz2 = 0;
            int n = 0;
            int c = 0;
            int o = 0;
            int z = 1;
            int a = 0;
            int tt = 0;
            int s = 0;
            int w = 1;
            int q = 0;
            int tt2 = 0;
            int tt3 = 0;
            while (n < ti)
            {
                Console.Write("Введите значение \n");
                tt = Convert.ToInt32(Console.ReadLine());
                n = n + 1;
                if ((tt % 2) == 0 && tt > 0)
                {
                    srz++;
                    c = c + tt;
                    srz2 = c / srz;
                }
                if (tt < 0)
                {
                    a++; ;
                }
                tt = 0;
            }

            n = 0;
            Console.Write("Введите сколько чисел будет в числе 2 задание \n");
            int ti2 = Convert.ToInt32(Console.ReadLine());
            while (n < ti2)
            {
                Console.Write("Введите значение ");
                tt2 = Convert.ToInt32(Console.ReadLine());
                n = n + 1;
                if ((tt2 % 3) == 0)
                {
                    o = o + tt2;
                }
                if (w == 1)
                {
                    q = q + tt2;
                    w = w + 2;
                }
                if (n == ti2)
                {
                    s = s = tt2;
                }
                tt2 = 0;
            }

            n = 0;
            Console.Write("Введите значения 3 задание \n");
            while (n < 1)
            {
                Console.Write("Введите значение ");
                tt3 = Convert.ToInt32(Console.ReadLine());
                if (((tt3 % 2) == 0) && ((tt3 % 5) == 0) && (tt3 != 0))
                {
                    z = z * tt3;
                }
                if (tt3 == 0)
                {
                    n = 3;
                }

                tt3 = 0;
            }
            Console.Write(" ");
            Console.Write("Задание 1 " + "\n");
            Console.Write("Среднее арифметическое: " + srz2 + "\n");
            Console.Write("Количество отрицательных чисел: " + a + "\n");
            Console.Write("Задание 2 " + "\n");
            Console.Write("Сумма цифр кратных 3: " + o + "\n");
            Console.Write("Первое число: " + q + " и последнее число: " + s + "\n");
            Console.Write("Задание 3 " + "\n");
            Console.Write("Произведение чисел кратных 2 и 5: " + z + "\n");
            Console.Write("Для завершения нажмите Enter");
            Console.Read();
        }
    }
}
