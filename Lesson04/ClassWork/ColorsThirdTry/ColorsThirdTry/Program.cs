using System;

class Program
{
    [Flags]
    enum colors
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
        Crimson = 0x1 << 11
    }

    static void Main(string[] args)
    {
        // рассчитываем переменную со всеми возможными цветами
        colors allColors = 0;
        foreach (colors singleColor in Enum.GetValues(typeof(colors)))
        {
            allColors = allColors | singleColor;
        }

        // выводим возможные цвета за исключением "нулевого"
        Console.WriteLine("Список возможных цветов:");
        Console.WriteLine(allColors);

        // здесь будем хранить любимые цвета
        colors favoriteColors = 0;

        // прочитаем их
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Введите любимый цвет {i + 1}: ");

            object color = Enum.Parse(typeof(colors), Console.ReadLine());
            favoriteColors |= (colors)color;
        }

        // выводим любимые цвета
        Console.WriteLine("Любимые цвета:");
        Console.WriteLine(favoriteColors);
        Console.WriteLine();

        // рассчитываем нелюбимые цвета черех allColors XOR favoriteColors.
        colors notFavoriteColors = allColors ^ favoriteColors;

        // можно также инвертировать favoriteColors,
        // а потом "просеять" через AND с allColors.
        //colors notFavoriteColors = ~favoriteColors;
        //notFavoriteColors = (colors)(((int)notFavoriteColors << 23) >> 23 );

        Console.WriteLine("Нелюбимые цвета:");
        Console.WriteLine(notFavoriteColors);
        Console.WriteLine();

        Console.WriteLine("\nОтладочная информация:");
        WriteInt32ValueWithBits(allColors, nameof(allColors));
        WriteInt32ValueWithBits(favoriteColors, nameof(favoriteColors));
        WriteInt32ValueWithBits(notFavoriteColors, nameof(notFavoriteColors));
    }

    static void WriteInt32ValueWithBits(object value, string description)
    {
        Console.WriteLine(
            "Flags: {0} : {1}",
            Convert.ToString((int)value, 2).PadLeft(32, '0'),
            description);
    }
}
