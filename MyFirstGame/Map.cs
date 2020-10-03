using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstGame
{
    public static class Map
    {
        private readonly static string[] inputMap = {
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            "X________X___________________X                       XXXXXXXXXXXXXXXXXX",
            "X________X___________________X                       X________________X",
            "X________X___________________XXXXXXXXXXXXXXXXXXXXXXXXX________________X",
            "X_____________________________________________________________________X",
            "X________XXXXXXXX____________XXXXXXXXXXXXXXXXXXXXXXXXX________________X",
            "X________X_____________X_____X                       X________________X",
            "X________X_____________X_____X                       XXXXXXXXXXXXXXXXXX",
            "X________X_____________X_____X",
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"};

        private static Dictionary<char, Texture> convertedTexture = new Dictionary<char, Texture>();

        readonly static Texture wall = new Texture('#', ConsoleColor.DarkYellow, ConsoleColor.Yellow, true);
        readonly static Texture space = new Texture(' ', ConsoleColor.White);
        readonly static Texture nothing = new Texture(' ', ConsoleColor.Black);

        public static void InitMap()
        {
            convertedTexture.Add('X', wall);
            convertedTexture.Add('_', space);
            convertedTexture.Add(' ', nothing);

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
