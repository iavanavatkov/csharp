using System;
using NameAndAge;

namespace NameAndAge
{
	class Program
	{
		static void Main(string[] args)
		{
			int id = 0;
			string[] namesArray = new string[4];
			string[] agesArray = new string[4];

			while (id < 3)
			{
				Console.Write($"Введите имя {id + 1} человека: ");
				namesArray[id] = Console.ReadLine();
				Console.Write($"Введите возраст {id + 1} человека: ");
				agesArray[id] = Console.ReadLine();
				id++;
			}

			DataBasePreset firstPerson = new DataBasePreset($"{namesArray[0]}", $"{agesArray[0]}");
			DataBasePreset secondPerson = new DataBasePreset($"{namesArray[1]}", $"{agesArray[1]}");
			DataBasePreset thirdPerson = new DataBasePreset($"{namesArray[2]}", $"{agesArray[2]}");

			firstPerson.WriteToConsole();
			secondPerson.WriteToConsole();
			thirdPerson.WriteToConsole();
		}
	}
}
