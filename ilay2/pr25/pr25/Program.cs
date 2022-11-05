using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr25
{
    class Program
    {
        static void Main(string[] args)
        {
            //меняет местами первую букву с последней, вторую с предпоследней и т.д.
            Console.WriteLine("Задание 1: ");
            Console.WriteLine("Введите строку: ");
            string line = Console.ReadLine();
            for (int i = line.Length - 1; i >= 0; i--)
            {
                Console.Write(line[i]);
            }
            Console.WriteLine();
            //Вывести только те слова, которые встречаются в тексте ровно два раза.
            Console.WriteLine("Задание 2: ");
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            string[] writes = str.Split(' ');

            for (int i = 0; i < writes.Length; i++)
            {
                string write = writes[i];
                int count = 0;
                foreach (string item in writes)
                {
                    if (item == write)
                        count++;
                }
                if (count == 2)
                    Console.WriteLine(writes[i]);
            }
            
            Console.ReadKey();
        }
    }
}
