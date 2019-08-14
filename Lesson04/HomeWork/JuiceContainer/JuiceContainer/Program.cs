using System;

namespace JuiceContainer
{
	class Program
	{
        enum Container
		{
			None = 0,
            SmallContainer = 1,
            MiddleContainer = 5,
            BigContainer = 20
		}


		static void Main(string[] args)

		{
			try
			{
				Console.Write("Введите количество литров сока: ");
                string input = Console.ReadLine();
                double inputParsed = double.Parse(input);

                double bigContainerDouble = Math.Ceiling(Convert.ToDouble(Container.BigContainer)); //парсить через double.Parse(Container.BigContainer) почему-то не получилось.
				double bigContainerOstatok = inputParsed % (double)Container.BigContainer;

				double middleContainerDouble = Math.Ceiling(Convert.ToDouble(Container.MiddleContainer));
				double middleContainerOstatok = bigContainerOstatok % (double)Container.MiddleContainer;

				double smallContainerDouble = Math.Ceiling(Convert.ToDouble(Container.SmallContainer)); //остаток от него вычислять смысла не имеет.


				if (inputParsed >= bigContainerDouble)
				{
					Console.WriteLine($"Вам необходимо {Math.Floor(inputParsed / bigContainerDouble)} двадцатилитровых контейнера");
				}

				if (bigContainerOstatok >= middleContainerDouble)
				{
					Console.WriteLine($"Вам необходимо {Math.Floor(bigContainerOstatok / middleContainerDouble)} пятилитровых контейнера");
				}

				if (middleContainerOstatok >= smallContainerDouble)
				{
					Console.WriteLine($"Вам небходимо {Math.Ceiling(middleContainerOstatok / smallContainerDouble)} литровых контейнера");
				}
			}

			catch (Exception e)
			{
				Console.WriteLine($"Произошла ошибка '{e.Message}'");
			}
		}
	}
}