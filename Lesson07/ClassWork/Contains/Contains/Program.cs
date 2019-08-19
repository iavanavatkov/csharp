using System;

namespace Contains
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string checkString = Console.ReadLine();

			int stringLength = input.Length;
			int checkIt = 1;

			while (checkIt-1 < stringLength)
			{
				Console.WriteLine(input.IndexOf($"{checkString}", checkIt));
				checkIt++; 
			}
		}
	}
}
