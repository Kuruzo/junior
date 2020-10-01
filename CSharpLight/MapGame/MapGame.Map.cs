using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CSharpLight
{
    static partial class MapGame
    {
        public static class Map
        {
            // Create map
            private static char X => wall.symbol;
            private static char _ => space.symbol;
            private readonly static char[,] paintedMap =
            {
                    {_,_,_,_,_,_,_,_,_,_,_,_,_,_,_},
                    {_,X,X,X,X,X,X,X,X,X,X,X,X,X,_},
                    {_,X,_,_,_,_,_,_,_,_,X,_,_,X,_},
                    {_,X,_,_,_,_,_,_,_,_,X,_,_,X,_},
                    {_,X,_,_,_,_,X,_,_,_,X,_,_,X,_},
                    {_,X,_,_,_,_,X,_,_,_,_,_,_,X,_},
                    {_,X,_,_,_,_,X,_,_,_,_,_,_,X,_},
                    {_,X,_,_,_,_,X,_,_,_,_,_,_,X,_},
                    {_,X,X,X,X,X,X,X,X,X,X,X,X,X,_},
                    {_,_,_,_,_,_,_,_,_,_,_,_,_,_,_},
            };

            public static string[] mapLines; 

            public static Dictionary<char, Texture> keyTexture = new Dictionary<char, Texture>();

            // Setting textures ^-^ 
            static readonly Texture wall = new Texture('@', ConsoleColor.White, ConsoleColor.DarkYellow, true);
            static readonly Texture space = new Texture(' ', ConsoleColor.White, ConsoleColor.White);

            // Print on Console
            public static void Pain()
            {
                for (int i = 0; i <= paintedMap.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= paintedMap.GetUpperBound(1); j++)
                    {
                        Print(i, j);
                    }
                }
            }

            public static void Print(int x, int y)
            {
                if (paintedMap[x, y] == X) wall.Print(y, x);
                else if (paintedMap[x, y] == _) space.Print(y, x);
            }
        }
    }
}
