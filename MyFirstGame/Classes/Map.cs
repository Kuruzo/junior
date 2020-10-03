using System;
using System.Collections.Generic;

namespace MyFirstGame
{
    static class Map
    {
        private readonly static string[] inputMap = {
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            "X________X___________________X",
            "X________X___________________X",
            "X________X___________________XXXXXXXXXXXXXXXXXXXXXXXXX",
            "X____________________________________________________X",
            "X________XXXXXXXX____________XXXXXXXXXXXXXXXXXXXXXXXXX",
            "X________X_____________X_____X",
            "X________X_____________X_____X",
            "X________X_____________X_____X",
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"};

        private static Dictionary<char, Texture> convertedTexture = new Dictionary<char, Texture>();

        readonly static Texture wall = new Texture('#', ConsoleColor.Yellow, ConsoleColor.DarkYellow, true);
        readonly static Texture space = new Texture(' ', ConsoleColor.White, ConsoleColor.White);


        public static void InitMap()
        {
            convertedTexture.Add('X', wall);
            convertedTexture.Add('_', space);

            foreach (string line in inputMap)
            {
                foreach (char item in line)
                {
                    convertedTexture[item].Print();
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
