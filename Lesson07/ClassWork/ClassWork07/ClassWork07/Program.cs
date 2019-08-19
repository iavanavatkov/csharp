using System;
using System.Threading;

namespace ClassWork07
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Console.WriteLine(@"a\tb\nc
			//а ето вторая строка"); //Это делает буквальным вот это всё, кайф.
			//			Console.WriteLine("a\tb\nc" +
			//				"а ето вторая строка");

			//while (true)
			//{
			//	Console.WriteLine(DateTime.Now);
			//	Thread.Sleep(1000);
			//	Console.Clear();
			//}

			DateTime now = DateTime.Now;
			string result2 = string.Format("Now is {0:dd MMMM yyyy HH:mm:ss}", now); //форматирование не имеет значения, главное написать мммм оаыовлаололо, на точки похуй.
			Console.WriteLine(result2);

			TimeSpan magicTime = DateTime.Now - DateTime.Parse("17.02.1995"); //Сколько дней я живу, кайф
			Console.WriteLine(magicTime.TotalDays);

			Console.Write ("Введите первое число: ");
			string inputFirst = Console.ReadLine().Replace(".", ",");

			Console.Write("Введите второе число: ");
			string inputSecond = Console.ReadLine().Replace(".", ",");

			decimal inputFirstParsed = decimal.Parse(inputFirst);
			decimal inputSecondParsed = decimal.Parse(inputSecond);

			Console.WriteLine(
				"Умножение этих чисел будет равно " +
				inputFirstParsed + "*" + inputSecondParsed + 
				"=" + inputSecondParsed * inputFirstParsed);
			Console.WriteLine("Сложение этих чисел будет равно {0}+{1}={2}", 
						    	inputFirstParsed, inputSecondParsed, inputFirstParsed + inputSecondParsed);
			Console.WriteLine($"Вычитание этих двух чисел будет равно {inputFirstParsed}-{inputSecondParsed}={inputFirstParsed - inputSecondParsed}");
		}
	}
}