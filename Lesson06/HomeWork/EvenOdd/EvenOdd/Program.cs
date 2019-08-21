using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            bool crutch = false;
            long inputParsedLong = 0;
            int valueOfEven = 0;

            while (crutch == false) //начало цикла
            {
                Console.Write("Введите натуральное число: ");
                string input = Console.ReadLine();
                try
                {
                    inputParsedLong = long.Parse(input);
                }
                catch (OverflowException errorTooSmallOrBig)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы ввели слишком большое или слишком маленькое число! Ошибка {errorTooSmallOrBig.Message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                catch (FormatException errorWrongFormat)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Неверный формат! Ошибка {errorWrongFormat.Message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
				catch (Exception elseError)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"Ошибка {elseError.Message}");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
				}
                if (inputParsedLong <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Натуральное число не может быть меньше нуля!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                crutch = true;
            }
            //конец цикла
            Console.WriteLine($"Вы ввели {inputParsedLong}");

            while (inputParsedLong != 0)
            {
                if (inputParsedLong % 2 == 0)     //оказывается, в среде учёных ведутся холивары за то, считать нуль чётным или нет. 
                {
                    valueOfEven++;
                }
                inputParsedLong /= 10;
            }

            Console.WriteLine($"Количество четных цифр: {valueOfEven}");
        }
    }
}
