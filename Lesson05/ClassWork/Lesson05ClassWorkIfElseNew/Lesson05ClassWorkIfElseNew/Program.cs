using System;

namespace Lesson05ClassWorkIfElseNew
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 200;
            //string message2 = num < 100 //это как иф элс
            //    ? "Correct!" 
            //    : "Error";
            Console.Write("Введите число от 1 до 100: ");
            string value = Console.ReadLine();
            int valueInt = int.Parse(value);
            string message = valueInt >= 50
                ? "Число больше или равно 50" //если истинно
                : "Число меньше 50"; //если ложно.
            Console.WriteLine(message);
        }
    }
}
