using System;

namespace ForMassives
{
    class Program
    {
        static void Main(string[] args)
        {
            var marks = new[]
            {
                new [] {2, 3, 3, 2, 3}, //массивы в массиве, вау
                new [] {2, 4, 5, 3 },
                null,
                new [] {5, 5, 5, 5},
                new [] {4}
            };

            int dayNumber = 0;
            int markNumber = 0;
            int sumOfDay = 0;

            for (dayNumber = 0; dayNumber <= marks.Length; dayNumber++)
            {
                //try здесь поставить

                for (markNumber = 0; markNumber <= marks[dayNumber].Length; markNumber++)
                {
                    try
                    {
                        //int sum = marks.Sum(dayNumber);
                        //int sum = marks(dayNumber).Sum;
                        //int currentMark = marks[markNumber];
                        //sumOfDay = sumOfDay + marks[dayNumber[markNumber]];
                        //marks[dayNumber[markNumber]]
                        //foreach (int )
                        Console.WriteLine(marks[dayNumber]);
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine($"Оценки не были получены");
                        continue;
                    }
                }
                //sumOfDay
            }
        }
    }
}
// короче я обосрался, вторая половина урока шестого, если что.
//с синтаксисом, там вместо marks[dayNumber[markNumber]] нужно marks[dayNumber][markNumber]