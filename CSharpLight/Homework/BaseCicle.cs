using System;
using static System.Console;

namespace CSharpLight
{
    class BaseCicle
    {
        public static void Run()
        {
            Write("Write same string: ");
            string inputString = ReadLine();
            Write("Hom manu times repiet? - ");
            int repietValue = Convert.ToInt32(ReadLine());

            for (int i = 0; i < repietValue; i++)
            {
                WriteLine(inputString);
            }
        }
    }
}
