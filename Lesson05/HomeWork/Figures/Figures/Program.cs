using System;

namespace Figures
{
	class Program
	{
        [Flags]
		enum Figures
		{
			Quadrangle = 0x1,
			Triangle = 0x1 <<1,
			Circle = 0x1 <<2
		}
		static void Main(string[] args)
		{
			//var figureArray = (Figures[])Enum.GetValues(typeof(Figures));
			Console.WriteLine($"Пожалуйста, введите порядковый номер фигуры: ");            
			//for (var i = 0; i < figureArray.Length; i++)
			//{
			//	Console.WriteLine ($"{figureArray[i]}, ");
			//}

            var allFigures = Figures.Quadrangle | Figures.Triangle | Figures.Circle;
            Console.WriteLine(allFigures); //в этот раз получилось реализовать перечисление по совету, ура. 

			try
			{
				var input = Console.ReadLine();
                var inputParsedToInt = int.Parse(input);
				var inputParsedToFigures = (Figures)Enum.Parse(typeof(Figures), input); //теперь понял, как парсить такие вещи.

				switch (inputParsedToInt)
				{
					case 1:
						Console.WriteLine("Пожалуйста, введите высоту прямоугольника: ");
						double quadrangleHeight = double.Parse(Console.ReadLine());
						Console.WriteLine("Пожалуйста, введите ширину прямоугольника: ");
						double quadrangleWidth = double.Parse(Console.ReadLine());
						Console.WriteLine($"Площадь прямоугольника = {quadrangleHeight * quadrangleWidth}");
						Console.WriteLine($"Периметр прямоугольника = {2 * (quadrangleHeight + quadrangleWidth)}");
						break;

					case 2:
						Console.WriteLine("Пожалуйста, введите сторону равностороннего треугольника: ");
						double triangleSide = double.Parse(Console.ReadLine());
						double triangleArea = Math.Round((Math.Sqrt(3) / 4) * (triangleSide * triangleSide), 2);
						Console.WriteLine($"Площадь треугольника = {triangleArea}");
						Console.WriteLine($"Периметр треугольника = {triangleSide * 3}");
						break;

					case 3:
						Console.WriteLine("Пожалуйста, введите диаметр круга ");
						double diameter = double.Parse(Console.ReadLine());
                        double circleArea = (Math.Round(Math.PI, 2) / 4) * (Math.Pow(diameter, 2));
						Console.WriteLine($"Площадь круга = {circleArea}");
						Console.WriteLine($"Периметр круга = {Math.Round(Math.PI, 2) * diameter}");
						break;

					default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Фигуры под таким номером не существует!");
                        Console.ForegroundColor = ConsoleColor.White;
                        throw new Exception("Введённый номер не соответствует ни одной фигуре!");
				}

			}
            catch (FormatException errorFormat)
			{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Вы используете неверный формат данных! Ошибка {errorFormat.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (OverflowException errorTooBigOrTooSmall)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Вы ввели слишком большое или маленькое число! Ошибка {errorTooBigOrTooSmall.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception errorElse)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Вы ввели неверные значения! Ошибка {errorElse.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        
	}
}