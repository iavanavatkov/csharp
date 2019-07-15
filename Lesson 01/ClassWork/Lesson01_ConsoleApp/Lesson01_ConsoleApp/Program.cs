using System;
using System.Threading;
using System.Text;

namespace Lesson01_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.ASCII;
            Console.OutputEncoding = Encoding.ASCII;
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Thread.Sleep(3000);
            Console.WriteLine($"Здравствуйте, {name}!");
            Console.ReadKey();
        }
    }
}
