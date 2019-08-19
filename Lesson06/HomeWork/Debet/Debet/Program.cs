using System;

namespace Debet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool crutch = false;
            decimal inputPaymentParsed = 0; //сделать с плавающей точкой, math round до двух знаков после запятой при парсе
            decimal inputPercentParsed = 0;
            decimal inputIHaveADreamParsed = 0;

            while (crutch == false)
            {
                Console.Write("Введите сумму взноса: ");
                string inputPayment = Console.ReadLine().Replace(".", ",");

                try
                {
                    inputPaymentParsed = decimal.Parse(inputPayment);
                    inputPaymentParsed = Math.Round(inputPaymentParsed, 2);
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
                if (inputPaymentParsed <= 0) //не стал делать отстрочку, так как по алгоритму это тот же трай/кэтч.
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Сумма взноса не может быть меньше нуля!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                crutch = true;
            }

            Console.WriteLine($"На вашем счету {inputPaymentParsed} рублей");

            while (crutch == true)
            {
                Console.Write("Введите ежедневный процент дохода в виде десятичной дроби (1% = 0,01): ");
                string inputPercent = Console.ReadLine().Replace(".", ",");

                try
                {
                    inputPercentParsed = decimal.Parse(inputPercent);
                }
                catch (OverflowException errorTooSmallOrBig)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы переоцениваете (или недооцениваете) прибыльность банковских вкладов! Ошибка {errorTooSmallOrBig.Message}");
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
                if (inputPercentParsed <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Речь идёт не о кредите!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                crutch = false;
            }

            while (crutch == false)
            {
                Console.Write("Желаемая сумма накопления: "); //не может быть меньше первоначальной суммы.
                string inputIHaveADream = Console.ReadLine();
                try
                {
                    inputIHaveADreamParsed = decimal.Parse(inputIHaveADream);
                    inputIHaveADreamParsed = Math.Round(inputIHaveADreamParsed, 2);
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
                if (inputPaymentParsed <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Сумма взноса не может быть меньше нуля!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (inputIHaveADreamParsed <= inputPaymentParsed)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Желаемая сумма накопления не может быть меньше первоначального взноса!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                crutch = true;
            }

            decimal currentCash = inputPaymentParsed;
            int day = 0; //думаю, инта будет достаточно.

            while (currentCash <= inputIHaveADreamParsed)
            {
                currentCash += (currentCash * inputPercentParsed);
                day++;
            }

            currentCash = Math.Round(currentCash, 2);
            Console.WriteLine($"Для накопления {inputIHaveADreamParsed} рублей потребуется {day} дней, итоговая сумма будет составлять {currentCash} рублей.");
        }
    }
}
