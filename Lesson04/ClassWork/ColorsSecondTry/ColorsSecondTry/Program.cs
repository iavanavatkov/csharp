using System;

namespace Favorite_colors
{
    class Program
    {
        [Flags]
        enum colors : ushort //получилось реализовать только таким образом
        {
            None = 0x0,
            Black = 0x1,
            White = 0x1 << 1,
            Cyan = 0x1 << 2,
            Blue = 0x1 << 3,
            Green = 0x1 << 4,
            Red = 0x1 << 5,
            Yellow = 0x1 << 6,
            Magenta = 0x1 << 7,
            Gray = 0x1 << 8,
            Brown = 0x1 << 9,
            Violet = 0x1 << 10,
            Crimson = 0x1 <<11
        }
        static void Main(string[] args)
        {
            var colorPallet =
                colors.Black |
                colors.White |
                colors.Cyan |
                colors.Blue |
                colors.Green |
                colors.Red |
                colors.Yellow |
                colors.Magenta |
                colors.Gray |
                colors.Brown |
                colors.Violet |
                colors.Crimson;
            var allColors = (colors[])Enum.GetValues(typeof(colors));
            Console.WriteLine($"Список доступных цветов:");

            for (var i = 1; i < allColors.Length; i++)
            {
                Console.WriteLine($"{i} - {allColors[i]}");
            }

            colors favouriteColors = colors.None;
            colors unfavouriteColors = colors.None;

            for (var i = 1; i <= 4; i++)
            {
                    Console.WriteLine($"\nВведите цвет номер {i}");
                    string input = Console.ReadLine();
                    colors inputParsed = (colors)Enum.Parse(typeof(colors), input);
                    favouriteColors |= inputParsed; //студия меня поправила, сделав вот это. Я в целом не против, но на мой взгляд это читается хуже.
            }

            unfavouriteColors = favouriteColors ^ colorPallet;
            Console.WriteLine($"Ваши любимы цвета: {favouriteColors}  ");
            Console.WriteLine($"Ваши нелюбимые цвета: {unfavouriteColors}  ");
        }
    }
}
