using System;

namespace BracketChecker
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstChecker = 0;
			int secondChecker = 0;
			int thirdChecker = 0;

			Console.WriteLine("Введите скобки.");
			string input = Console.ReadLine();

			foreach (char brackets in input)
			{
				if (brackets == '(')
					firstChecker++;
				
				if (brackets == ')')
					firstChecker--;
				
				if (brackets == '[')
					secondChecker++;
				
				if (brackets == ']')
					secondChecker--;
				
				if (brackets == '{')
					thirdChecker++;
				
				if (brackets == '}')
					thirdChecker--;
			}

			if ((firstChecker & secondChecker & thirdChecker) == 0)
				Console.WriteLine("Скобки расставлены верно");
			
			else
				Console.WriteLine("Скобки расставлены неверно");
		}
	}
}
