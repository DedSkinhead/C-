using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер маршрута такси");
            string it = Convert.ToString(Console.ReadLine());
            switch (it)
            {
                case "1": Console.WriteLine("Центральный-Шлюзовой");break;
                case "2": Console.WriteLine("Центральный-Комсомольский");break;
                case "3": Console.WriteLine("Центральынй-Автозаводской");break;
                case "4": Console.WriteLine("Комсомольский-Шлюзовой");break;
                    
            }
            Console.ReadKey();
        }
    }
}
