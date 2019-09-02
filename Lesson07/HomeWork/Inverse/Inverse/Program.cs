using System;

namespace Inverse
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("Введите слово для того, чтобы инвертировать его. " +
							  "Напишите \"Выход\", чтобы остановить работу программы:  ");
				string input = Console.ReadLine(); //Могу ли я сделать ToLower прямо здесь?
				input = input.ToLower();
				if (input == "выход")
				{
					break;
				}
				for (int inverse = input.Length; inverse > 0; inverse--)
				{
					Console.Write(input[inverse - 1]);
				}
				Console.WriteLine();
			}
		}
	}
}
