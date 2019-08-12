using System;

namespace Switch
{
    class Program
    {
        enum Color
        {
            Red,
            Green,
            Blue,
            Yellow
        }
        static void Main(string[] args)
        {
            Color c = (Color)(new Random()).Next(0, 5);
            switch (c) //проверяем, что хранит в себе с
            {
                case Color.Red: //если красный или желтый, то
                case Color.Yellow:
                    Console.WriteLine("The Color is Red or Yellow");
                    break;
                case Color.Green: //если зелёный, то
                    Console.WriteLine("The Color is Green");
                    break;
                case Color.Blue:
                    Console.WriteLine("The Color is Blue");
                    break;
                default: //во всех других случаях
                    Console.WriteLine("The color is unknown");
                    break;
            }
        }
    }
}
