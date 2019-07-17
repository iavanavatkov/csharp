using System;
using Encoding;

namespace HomeWork_Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введите число: ");
            string first = Console.ReadLine();
            Console.Write("А теперь второе число: ");
            string second = Console.ReadLine();
            
        }
    }
}
