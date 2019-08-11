using System;

namespace Lesson03HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersFirst = new int[10];

            numbersFirst[0] = 1;
            numbersFirst[1] = 2;
            numbersFirst[2] = 3;
            numbersFirst[3] = 4;
            numbersFirst[4] = 5;
            numbersFirst[5] = 6;
            numbersFirst[6] = 7;
            numbersFirst[7] = 8;
            numbersFirst[8] = 9;
            numbersFirst[9] = 10;

            int[] numbersSecond = new int[10];

            numbersSecond[0] = 1;
            numbersSecond[1] = 2;
            numbersSecond[2] = 3;
            numbersSecond[3] = 4;
            numbersSecond[4] = 5;
            numbersSecond[5] = 6;
            numbersSecond[6] = 7;
            numbersSecond[7] = 8;
            numbersSecond[8] = 9;
            numbersSecond[9] = 10;

            Console.WriteLine("Введите номер желаемой операции:\n\t1 для отображения таблицы умножения;\n\t2 для завершения программы.");
            int number = Int32.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.Clear();
                for (int i = 0; i < numbersFirst.Length; i++)
                {
                    for (int o = 0; o < numbersSecond.Length; o++)
                    Console.Write(numbersFirst[i] * numbersSecond[o] + "\t");
                    Console.WriteLine();
                }
            }
            if (number == 2)
            {
                Console.Write("Ну ладно.");
                Console.ReadLine(); //изначально не совсем верно понял тз, поэтому поставил здесь бесполезный иф, который планировал использовать для возможности введения пользовательских множителей. 
            }
        }
    }
}