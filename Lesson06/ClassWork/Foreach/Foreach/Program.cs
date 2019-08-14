using System;

namespace Foreach
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

            foreach (int mark in marks[dayNumber])
            {

            }
        }
    }
}
//смотреть в архиве, там всё круто
