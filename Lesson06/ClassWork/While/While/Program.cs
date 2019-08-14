using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 чисел");

            int i = 1;
            int sum = 0;
            int[] numberOfString = new int[5];

            while (i<6)
            {
                Console.Write($"Введите число №{i} ");
                string input = Console.ReadLine();
                try
                {
                    int inputParsed = int.Parse(input);
                    sum = sum + inputParsed;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число!");
                    continue; //вернуться в начало цикла
                }
                i++;
            }
            Console.WriteLine(sum);

        }
    }
}
