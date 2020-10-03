using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstGame
{
    public static class Map
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
        //readonly static Texture nothing = new Texture(' ');

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

        public static Texture TextureByPosition(Position position)
        {
            return convertedTexture[inputMap[position.X][position.Y]];
        }

        public static void PrintByPosition(Position position)
        {
            convertedTexture[inputMap[position.X][position.Y]].Print(position.X, position.Y);
        }
    }
}
