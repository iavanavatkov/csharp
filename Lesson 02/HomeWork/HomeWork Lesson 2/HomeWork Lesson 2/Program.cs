using System;
using System.Threading;
using System.Text; //Не забыть добавить юникод

namespace Lesson01_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = ("Калькулятор");
            Console.Write("Введите первое число: ");
            string firstNumber = Console.ReadLine();
            Console.Write("Введите второе число: ");
            string secondNumber = Console.ReadLine();
            Console.WriteLine("Пожалуйста, подождите...");
            Thread.Sleep(3000);
            firstNumber = firstNumber.Replace(".", ","); //Чтобы при парсинге на точки не ругался.
            secondNumber = secondNumber.Replace(".", ",");
            {
                if (secondNumber == "0")//либо можно поставить ноль в кавычки, чтобы не парсить никуда. И надо попробовать сделать цикл, чтобы назад к вводу возвращало.
                {
                    Console.WriteLine("Второе число не может быть нулём");

                }
                else
                { decimal firstNumberParsed = decimal.Parse(firstNumber);
                    decimal secondNumberParsed = decimal.Parse(secondNumber);
                    Console.WriteLine($"Деление: {firstNumber}/{secondNumber} = {firstNumberParsed / secondNumberParsed};");
                    Console.WriteLine($"Умножение: {firstNumber}*{secondNumber} = {firstNumberParsed * secondNumberParsed};");
                    Console.WriteLine($"Сложение: {firstNumber}+{secondNumber} = {firstNumberParsed + secondNumberParsed};");
                    Console.WriteLine($"Вычитание: {firstNumber}-{secondNumber} = {firstNumberParsed - secondNumberParsed}.");
                    Console.ReadKey();
                }
            }
        }
    }
}
