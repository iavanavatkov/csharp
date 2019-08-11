using System;

namespace Lesson04ClassWork
{
    class Program
    {
        enum Day
        {
            Sunday = 10,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };
        enum Month : byte
        {
            Jan,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        };        enum WindDirection
        {
            North,
            East,
            South,
            West
        }
        static void Main(string[] args)
        {
            WindDirection wd = WindDirection.East | WindDirection.North;

            //Day today = Day.Monday;
            //int dayNumber = (int)today;
            //Console.WriteLine("{0} is day #{1}.", today, dayNumber); // {0} и {1} - это плейсхолдер для today и daynumber (видимо) соответственно.
            //Month thisMonth = Month.Dec;
            //byte monthNumber = (byte)thisMonth;
            //Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);
            //int a = 10;
            //int b = 0;

            //b = a++;

            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);
            //Console.WriteLine(a > b);
            //Console.WriteLine(a < b);
            //Console.WriteLine(a <= b);
            //Console.WriteLine(a >= b);
            //Console.WriteLine("Введите значение а");
            //var a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите значение h");
            //var h = Convert.ToInt32(Console.ReadLine());

            //var sBok = (3 * a * h);
            //var sFull = (1,5 * a * (a * Math.Sqrt(3) + 2 * h));
            //Console.WriteLine($"S боковая = {3}*a*h = {sBok}");
            //Console.WriteLine($"S полная = {sFull}");


            //int a = 3; //0x0011
            //int b = 5; //0x0101
            //int c = a | b;
            //Console.WriteLine(a.ToString("X"));
            //Console.WriteLine (Convert.ToString(a, 2));
            //Console.WriteLine(a & b);
            //static string toBynarySting(int a);


            //int shiftSample = 7;

        }
    }
}
