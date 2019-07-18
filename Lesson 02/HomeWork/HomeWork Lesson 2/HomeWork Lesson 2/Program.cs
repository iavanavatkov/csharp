using System;
using System.Threading;
using System.Text; //Не забыть добавить юникод

namespace Lesson01_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
                //int secondNumberInt = int.Parse(secondNumber); 
                //bool checkZero = true;
                //while (checkZero) ухххххх циклы аыаааа, пока забуду про них
                if (secondNumber == "0")//либо можно поставить ноль в кавычки, чтобы не парсить никуда. И надо попробовать сделать цикл, чтобы назад к вводу возвращало.
                {
                    //checkZero = false;
                    Console.WriteLine("Второе число не может быть нулём");

                }
                else
                { //Пока что только так смог реализовать.
                  /* если число меньше диапазона децимала, то можно парсить в меньшее.
                  И нужно приравнять точку к запятой, а то иначе он не понимает, что при написании точки не целое число. Или заменить точку на запятую как-нибудь.
                  И если вводится текст, выдавать сообщение об ошибке, а не просто крашить. */
                    decimal firstNumberParsed = decimal.Parse(firstNumber);
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
