using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pr25
{
    class Program
    {
        static void Main(string[] args)
        {
            //удаляет из строки последовательность символов, расположенных между круглыми скобками (считается, что в строке ровно одна пара круглых скобок).
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите строку");
              Console.WriteLine(Regex.Replace(Console.ReadLine(), @"(?<=\().+(?=\))", string.Empty));
            //По правилу расстановки знаков препинания перед каждым знаком препинания пробел отсутствует, а после него обязательно стоит пробел. Учитывая данное правило, проверьте текст на правильность расстановки знаков препинания и, если необходимо, внесите в текст изменения.
            Console.WriteLine("Задание 2");
            string TEXT = Console.ReadLine();
            StringBuilder total = new StringBuilder();
            for (int i = 1; i < TEXT.Length; i++)
            {
                char previousChar = TEXT[i - 1];
                char followingChar = TEXT[i];
                if (char.IsPunctuation(previousChar) && char.IsLetterOrDigit(followingChar))
                    total.Append(previousChar + " ");
                else
                    total.Append(previousChar);
            }
            total.Append(TEXT[TEXT.Length - 1]);
            string correctText = total.ToString();
            Console.WriteLine(correctText);
            Console.ReadKey();
           
        }
    }
}
