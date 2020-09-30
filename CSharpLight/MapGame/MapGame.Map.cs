using System;

namespace CSharpLight
{
    static partial class MapGame
    {
        static class Map
        {
            // Setting textures ^-^ 
            static readonly Texture wall = new Texture('@', ConsoleColor.White, ConsoleColor.DarkYellow, false);
            static readonly Texture space = new Texture(' ', ConsoleColor.White, ConsoleColor.DarkRed);

            // Create map
            private static char X => wall.symbol;
            private static char _ => space.symbol;
            private readonly static char[,] paintedMap =
            { 
                    {X,X,X,X,X,X,X,X,X,X,X,X,X},
                    {X,_,_,_,_,_,_,_,_,X,_,_,X},
                    {X,_,_,_,_,_,_,_,_,X,_,_,X},
                    {X,_,_,_,_,X,_,_,_,X,_,_,X},
                    {X,_,_,_,_,X,_,_,_,_,_,_,X},
                    {X,_,_,_,_,X,_,_,_,_,_,_,X},
                    {X,_,_,_,_,X,_,_,_,_,_,_,X},
                    {X,X,X,X,X,X,X,X,X,X,X,X,X},
            };

            // Print on Console
            public static void Pain()
            {
                for (int i = 0; i <= paintedMap.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= paintedMap.GetUpperBound(1); j++)
                    {
                        if (paintedMap[i, j] == X) wall.PrintTexture();
                        else if (paintedMap[i, j] == _) space.PrintTexture();

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
