using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите число меньше 100");
            //string value = Console.ReadLine();
            //int valueInt = int.Parse(value);

            //if (valueInt >= 100)
            //{
            //    throw new Exception("Wrong value!");
            //}

            //Console.WriteLine($"Вы ввели корректное число, {valueInt}");
            Console.Write("Введите число от 1 до 100: ");
            string value = Console.ReadLine();
            int valueInt = 20;
            try
            {
                valueInt = int.Parse(value); //проверка на исключения будет.
            }
            catch (Exception e) //если упала при попытке парсить
            {
                Console.WriteLine($"Произошла ошибка типа {e.GetType()} \n'{e.Message}'\nпри попытке преобразовать значение {value}, " +
                                  $"в дальнейшем будет использовано значение по умолчанию {valueInt}");
            }
            finally //в любом случае будет происходить перед выходом из блока try catch
            {
                Console.WriteLine ("Мы в Finally");
            }
            if (valueInt <0 || valueInt>100)
            {
                throw new Exception("Wrong value!");
            }
            Console.WriteLine($"Вы ввели корректное число, {valueInt}");
        }
    }
}
