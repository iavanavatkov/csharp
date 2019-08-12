using System;

namespace NewException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = RequestIntegerFromConsole("Введите сторону прямоугольника а");
                int b = RequestIntegerFromConsole("Введите сторону прямоугольника б");

                Console.WriteLine($"Площадь прямогульника = {(Int64)a * (Int64)b}");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Возникла ошибка '{e.Message}'");
                Console.ForegroundColor = ConsoleColor.Red;
                throw; //чтобы не съесть ошибку
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Программа завершилась успешно!");
            Console.ForegroundColor = ConsoleColor.White;
        }



        static int RequestIntegerFromConsole(string requestMessage) //создаем короч метод, это что-то типа бинда. Ну макрос. 
            //Пресет. Короче, что там внизу, то и будет делаться при введении RequestIntegerFromConsole там, наверху.
        {
            Console.WriteLine(requestMessage);
            return int.Parse(Console.ReadLine());
        }
    }
}
