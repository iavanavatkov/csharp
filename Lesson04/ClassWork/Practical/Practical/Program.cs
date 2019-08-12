using System;

namespace Practical
{
    class Program

    {
        [Flags]
        enum color
        {
            Black = 1,
            White,
            Cyan,
            Blue,
            Green,
            Red,
            Yellow,
            Magenta,
            Gray,
            Brown,
            Violet,
            Crimson
        }

        static void Main(string[] args)
        {
            color currentColor = color.Black;
            int numberOfColor = (int)currentColor;
            int[] bestColorsUser = new int[4];
            int i = 0;

            Console.WriteLine("Доступные цвета:");

            for (currentColor = color.Black; currentColor <= color.Crimson; numberOfColor++, currentColor++)
            {
                Console.WriteLine("{0} - цвет номер {1}.", currentColor, numberOfColor);
            }

            Console.WriteLine("\nВведите порядковые номера четырёх ваших любимых цветов.");

            for (int bestColors = 0; bestColors < 4; bestColors++, i++)
            {
                if (bestColors != 3)
                {
                    Console.WriteLine($"\nОсталось {4 - bestColors} цвета");
                    bestColorsUser[i] = Int32.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"\nОстался {4 - bestColors} цвет");
                    bestColorsUser[i] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"Выбранные номера: {bestColorsUser[0]} {bestColorsUser[1]} {bestColorsUser[2]} {bestColorsUser[3]}");
            /* 
             * Вот тут я конкретно затупил, поэтому в самом низу будет закомментирован костыль на миллиард строк. 
             * Не мог понять, каким образом мне проассоциировать номера цветов с полученными в массив данными.
             * В случае работы с циклами у меня возникала проблема видимости переменных, которая достаточно сильно деморализует и кажется мне нерешаемой.
             * В итоге я догадался, как это более-менее по-человечески сделать, но душа болит за неудавшийся костыль.
             */

            color firstColor = (color)bestColorsUser[0];
            color secondColor = (color)bestColorsUser[1];
            color thirdColor = (color)bestColorsUser[2];
            color fourthColor = (color)bestColorsUser[3];
            color favouriteColors = (color)bestColorsUser[0] | (color)bestColorsUser[1] | (color)bestColorsUser[2] | (color)bestColorsUser[3]; //при попытке ввести сюда firstColor и прочие недавно объявленные переменные программа по каким-то причинам работала некорректно.
            bool[] checkFavourite = new bool[13];
            color[] unfavouriteColors = new color[9];
            i = 0; //на всякий случай. 

            //неудавшийся цикл:
            //for (currentColor = color.Black; currentColor <= color.Crimson; i++, currentColor++)
            //{
            //    checkFavourite[i] = (favouriteColors & currentColor) == currentColor;
            //    if (checkFavourite[i] == false)
            //    {
            //        unfavouriteColors[i] = currentColor;
            //        Console.WriteLine($"{currentColor} - нелюбимый цвет"); 
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            bool checkBlack = (favouriteColors & color.Black) == color.Black;
            if (checkBlack == false)
            {
                unfavouriteColors[0] = color.Black;
            }
            //else
            //{
            //    unfavouriteColors[0] = color.White; //к примеру, в качестве проверки выполнения условия.
            //}

            Console.WriteLine($"Выбранные цвета: {firstColor}, {secondColor}, {thirdColor}, {fourthColor}");
            Console.WriteLine($"Невыбранные цвета: {unfavouriteColors[0]}"); //здесь я сдался, поскольку условие по каким-то причинам не выполняется в любом случае. Продолжу позже, на свежую голову.


            //старый костыль:
            //currentColor = color.Black;
            //i = 0;

            //for (bool check = false; check = true; numberOfColor++, i++, currentColor++) 
            //{
            //    if (bestColorsUser[0] == i)
            //    {
            //        color firstColor = currentColor;
            //        check = true;
            //    }

            //    else
            //    {
            //        break;
            //    }
            //}

            //currentColor = color.Black;
            //i = 0;

            //for (bool check = false; check = true; numberOfColor++, i++, currentColor++)
            //{
            //    if (bestColorsUser[1] == i)
            //    {
            //        color secondColor = currentColor;
            //        check = true;
            //    }

            //    else
            //    {
            //        break;
            //    }
            //}

            //currentColor = color.Black;
            //i = 0;

            //for (bool check = false; check = true; numberOfColor++, i++, currentColor++)
            //{
            //    if (bestColorsUser[2] == i)
            //    {
            //        color thirdColor = currentColor;
            //        check = true;
            //    }

            //    else
            //    {
            //        break;
            //    }
            //}

            //currentColor = color.Black;
            //i = 0;

            //for (bool check = false; check = true; numberOfColor++, i++, currentColor++)
            //{
            //    if (bestColorsUser[3] == i)
            //    {
            //        color fourthColor = currentColor;
            //        check = true;
            //    }

            //    else
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine($"{firstColor}"); //здесь я столкнулся с проблемой видимости переменных и иерархической структурой.
        }

    }
}
