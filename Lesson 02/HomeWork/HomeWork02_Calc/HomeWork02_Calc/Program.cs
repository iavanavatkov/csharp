using System;
//using System.Threading;
using System.Text; //Не забыть добавить юникод
namespace HomeWork02_Calc
{
	class Program
	{		static void Main(string[] args)
		{
			Console.Title = ("Калькулятор");
			Console.Write("Введите первое число: ");
			string firstNumber = Console.ReadLine();
			Console.Write("Введите второе число: ");
			string secondNumber = Console.ReadLine();
			firstNumber = firstNumber.Replace(".", ","); 
			secondNumber = secondNumber.Replace(".", ",");
			decimal firstNumberParsed = decimal.Parse(firstNumber);
			decimal secondNumberParsed = decimal.Parse(secondNumber);
            Console.Write("Введите желаемую операцию: ");
			string mathOperation = Console.ReadLine();
            mathOperation = mathOperation.ToUpper();
		  //mathOperation = mathOperation.Replace("д", "Д").Replace("у", "У").Replace("с", "С").Replace("в", "В"); //Чтобы регистр первой буквы не был критичен. Скорее всего, это можно как-то проще сделать.
            if (mathOperation == "УМНОЖЕНИЕ")
            {
                Console.WriteLine($"Умножение: {firstNumber}*{secondNumber} = {firstNumberParsed * secondNumberParsed}.");
                Console.ReadKey();
            }
            if (mathOperation == "ДЕЛЕНИЕ")
            {
                if (secondNumber == "0")
                {
                    Console.WriteLine("Деление не получится.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Деление: {firstNumber}/{secondNumber} = {firstNumberParsed / secondNumberParsed}.");
                    Console.ReadKey();
                }
            }
            if (mathOperation == "СЛОЖЕНИЕ")
            {
                Console.WriteLine($"Сложение: {firstNumber}+{secondNumber} = {firstNumberParsed + secondNumberParsed}.");
                Console.ReadKey();
            }
            if (mathOperation == "ВЫЧИТАНИЕ")
            {
                Console.WriteLine($"Вычитание: {firstNumber}-{secondNumber} = {firstNumberParsed - secondNumberParsed}.");
                Console.ReadKey();
            }
            if (mathOperation == "ВОЗВЕДЕНИЕ В СТЕПЕНЬ") //А вот здесь мой метод с реплейсами и вызвал проблемы из-за обилия букв "в". 
            {
                Console.WriteLine("В какую степень нужно возвести?");
                string exponent = Console.ReadLine();
                double exponentParsed = double.Parse(exponent);
                double firstNumberForExponent = double.Parse(firstNumber); //Мог сразу парсить в дабл, если бы знал заранее, что остальные в степень не возводятся. Но пусть уж будет так.
                double secondNumberForExponent = double.Parse(secondNumber);
                double firstNumberExponentResult = Math.Pow(firstNumberForExponent, exponentParsed);
                double secondNumberExponentResult = Math.Pow(secondNumberForExponent, exponentParsed);
                Console.WriteLine($"{firstNumber} в степени {exponent} будет равен {firstNumberExponentResult}"); //Совершенно не понимаю, почему возводит в степень только с даблом. И почему Math.pow не хочет рассчитываться прямо в writeLine
                Console.WriteLine($"{secondNumber} в степени {exponent} будет равен {secondNumberExponentResult}"); 
                Console.ReadKey();
            }
            if (mathOperation == "ОСТАТОК ОТ ДЕЛЕНИЯ")
            {
                if (secondNumber == "0")
                {
                    Console.WriteLine("Деление не получится, остаток тоже.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Остаток от деления: {firstNumber}%{secondNumber} = {firstNumberParsed % secondNumberParsed}."); //Вообще лучше бы я все результаты вводил в переменные, если в дальнейшем понадобится с ними как-то взаимодействовать.
                    Console.ReadKey();
                }
            }
			
		}
	}
}
