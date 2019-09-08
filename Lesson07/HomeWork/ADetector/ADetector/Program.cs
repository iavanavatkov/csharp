using System;

namespace ADetector
{
	class Program
	{
		static void Main(string[] args)
		{
			int WordsValue = 0;

			Console.WriteLine("Введите слова через пробел для определения начинающихся с буквы \"А\"");
			string input = Console.ReadLine().ToLower();
			string[] inputArray = input.Split(' ');

			foreach (string wordsCheck in inputArray)
			{
				bool checkLiteraA = wordsCheck.StartsWith("а");
				if (checkLiteraA)
				{
					WordsValue++; 
				}
			}

			Console.WriteLine($"В тексте содержится {WordsValue} слов на букву \"А\"");
		}
	}
}
