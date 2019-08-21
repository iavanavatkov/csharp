using System;
using System.Collections.Generic;

namespace ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> intList = new List<int>();
			intList.Add(10);
			intList.Add(20);
			intList.Add(30);
			intList.Add(40);

			Console.WriteLine(string.Join(", ", intList));

			List<int> intList2 = new List<int>
			{
				10,
				20,
				30,
				40
			};

			Console.WriteLine(string.Join("\n", intList2));


			bool crutch = false;
			string input;
			int listCount = 0;
			List<double> doubleList = new List<double>();

			while (crutch == false)
			{
				Console.WriteLine("Введите значение типа Double. Если хотите выйти из приложения, введите \"стоп\".");
				input = Console.ReadLine().Replace(".", ",").ToUpper();

				if (input == "СТОП")
				{
					Console.WriteLine("Ввод окончен");
					break;
				}

				try
				{
					double inputParsed = double.Parse(input);
					listCount++;
					doubleList.Add(inputParsed);
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
			}

			Console.WriteLine(string.Join("\n", doubleList));

			double sumValue = 0;
			double averageValue = 0;

			foreach(double value in doubleList) //Перебирает все значения doubleList, последовательно присваивая их переменной value
			{
				sumValue += value;
			}

			averageValue = sumValue / doubleList.Count;

			Console.WriteLine($"Сумма всего равна {sumValue}, среднее арифметические {averageValue}");
		}
	}
}
