using System;

namespace Lesson04_ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //object это заебись и охуенно (или нет, потому что приходится переводить в говно всякое это)
            object name = "Andrey";
            object age = 36;
            object height = 1.73;

           // int length1 = name.Length; //не работает
            int length2 = ((string)name).Length;

            string Input = Console.ReadLine();
            Console.WriteLine("\"" + Input + "\"");

            Console.WriteLine(2019 - (int)age); //приведение обджекта к инту
            age = (int)age + 1;

            dynamic anotherName = "Alexander"; //даже пизже, чем обджект, но хуже других типов по тем же причинам. В отличие от obj может неявно приводиться к другим типам.
            int length = anotherName.Length;
            Console.WriteLine(length);
            // var в отличие от динамика и обджекта содержит уже определённые типы данных, тогда как в динамике и обджекте это происходит в процессе работы программы. Вар пизже, в общем. Однако злоупотребление приводит к меньшей читабельности.

        }
    }
}
