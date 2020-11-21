using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstGame
{
    

    // Some base class that contains everything in game.
    public class Game
    {
        List<GameObject> enemies;
    }

    // don't go static
    public static class CurrentLevel
    {      

        private static Dictionary<char, Texture> convertedTexture = new Dictionary<char, Texture>();


        // TODO create 'Tile' class that will contain Texture and GameObject.
        // Make Map as an 2D-array of Tiles

        //public static void InitMap()
        //{
        //    convertedTexture.Add('X', wall);
        //    convertedTexture.Add('_', space);
        //    convertedTexture.Add(' ', nothing);

        //    foreach (string line in inputMap)
        //    {
        //        foreach (char item in line)
        //        {
        //            convertedTexture[item].Print();
        //        }
        //        Console.ResetColor();
        //        Console.WriteLine();
        //    }
        //}

        //// Use Tile to check for Passable instead of doing such methods
        //public static Texture TextureByPosition(Position position)
        //{
        //    return convertedTexture[inputMap[position.Y][position.X]];
        //}

        //public static void PrintByPosition(Position position)
        //{
        //    TextureByPosition(position).Print(position.X, position.Y);
        //}


    }
}