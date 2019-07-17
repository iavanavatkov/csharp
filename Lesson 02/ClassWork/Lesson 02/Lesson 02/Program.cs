using System;

namespace Lesson_02 
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 10;
            var b = 10;
            var name = "Ivan";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(name);

            Console.WriteLine($"{ a} * { b} = { a* b}");

            byte maximum = 255;
            sbyte maximumSignedByte = sbyte.MaxValue;
            Console.WriteLine(maximum);
            int sun = 1_345_432;
            long universe = sun;
            sun = (int)universe;
            float f = sun;
            sun = (int)f;
            /* 
            Так как это оператор приведения, нужно писать желаемый тип переменной. 
            Так как Sun уже заявлена как int, пишем int перед названием переменной.
            */
            string valueOfSun = sun.ToString();
            Console.WriteLine(valueOfSun);
            Console.WriteLine(sun);
            Console.Write("Enter nuberic value: "); 
            string value = Console.ReadLine();
            int integerValue = int.Parse(value); //перевожу текстовую информацию в целочисленную (парсинг). 
            Console.WriteLine (value + value);
            Console.WriteLine (integerValue + integerValue);
            var s = 175;
            bool ss = 175 == 5;
        }
    }
}
