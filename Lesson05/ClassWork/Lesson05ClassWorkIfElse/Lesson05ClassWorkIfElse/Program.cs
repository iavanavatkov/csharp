﻿using System;

namespace Lesson05ClassWorkIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Press any key to analuysis:");
            //char c = Console.ReadKey(true).KeyChar;

            //if (char.IsLetterOrDigit(c))
            //{
            //    Console.WriteLine("You entered letter or digit!");
            //}
            //else if (char.IsPunctuation(c))
            //{
            //    Console.WriteLine("You pressed a punctuation sign...");
            //}
            //else if (char.IsUpper(c)) ;
            //{
            //    Console.WriteLine("You pressed a ASDLKJASLKDJKL");
            //}
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();

            // ЗДЕСЬ НУЖНО СТАВИТЬ ДВЕ ВЕРТИКАЛЬНЫЕ ПАЛКИ, А ТО БУДЕТ НЕ ОЧ
            Console.WriteLine("Введите число от 1 до 100");
            int Age = Int32.Parse(Console.ReadLine());
            if (Age == 1 | Age == 21 | Age == 31 | Age == 41 | Age == 51 | Age == 61 | Age == 71 | Age == 81 | Age == 91)
            {
                Console.WriteLine($"{Age} год.");
            }
            else if (Age == 2 | Age == 3 | Age == 4 | Age == 22 | Age == 23 | Age == 24 | Age == 32 | Age == 33 | Age == 34 |
                Age == 42 | Age == 43 | Age == 44 | Age == 52 | Age == 53 | Age == 54 | Age == 63 | Age == 64 | Age == 72 | Age == 73 | Age == 74 | Age == 82 | Age == 83 | Age == 84 | Age == 92 | Age == 93 | Age == 94)
            {
                Console.WriteLine($"{Age} года");
            }
            else if (Age == 5 | Age == 6 | Age == 7 | Age == 8 | Age == 9 | Age == 10 | Age == 11 | Age == 12 | Age == 13 | Age == 14 | Age == 15
                | Age == 16 | Age == 17 | Age == 18 | Age == 19 | Age == 20 | Age == 25 | Age == 26 | Age == 27 | Age == 28 | Age == 29 | Age == 30 | Age == 35 | Age == 36 | Age == 37
                | Age == 38 | Age == 39 | Age == 40 | Age == 45 | Age == 46 | Age == 47 | Age == 48 | Age == 49 | Age == 50 | Age == 55 | Age == 56
                | Age == 57 | Age == 58 | Age == 59 | Age == 60 | Age == 65 | Age == 66 | Age == 67 | Age == 68 | Age == 69 | Age == 70 | Age == 75 | Age == 76 | Age == 77 | Age == 78
                | Age == 79 | Age == 80 | Age == 85 | Age == 86 | Age == 87 | Age == 88 | Age == 89 | Age == 90 | Age == 95 | Age == 96 | Age == 97 | Age == 98 | Age == 99 | Age == 100)
            {
                Console.WriteLine($"{Age} лет");
            }
            else
            {
                Console.WriteLine($"Мда.");
            }
            // на самом деле я протупил, можно было через диапазоны сделать.




        }
    }
}
