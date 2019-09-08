using System;
using System.Collections.Generic;

namespace Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<int> Plates = new Stack<int>();
			//Plates.Push(0);
			int count = 0;


			while (true)
			{
				Console.WriteLine("Введите команду! Wash, Dry, Exit");
				string input = Console.ReadLine().ToUpper();

				if (input == "WASH")
				{
					Plates.Push(count);
					count++;
					Console.WriteLine($"Успешно помыто! В стопке {Plates.Peek()} тарелок");
					continue;
				}
				if (input == "DRY")
				{
					if (Plates.Count == 0)
					{
						Console.WriteLine($"Помойте тарелку!");
						continue;
					}

					Plates.Pop();
					count--;
					Console.WriteLine($"Успешно посушено! В стопке {Plates.Peek()} тарелок");
					continue;
				}
				
				if (input == "EXIT")
				{
					break;
				}
			}
		}
	}
}
