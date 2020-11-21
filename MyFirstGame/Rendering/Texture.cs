using System;
using System.Collections.Generic;

namespace MyFirstGame
{
    public class Texture
    {
        protected readonly char symbol;
        protected readonly ConsoleColor foregroundColor;
        protected readonly ConsoleColor backgroundColor;

        public enum TextureName
        {
            wall, space, nothing, player, dollar, enemy
        }

        private static Dictionary<TextureName, Texture> TextureDictionary = new Dictionary<TextureName, Texture>()
        {
            {TextureName.wall , new Texture('#', ConsoleColor.DarkYellow, ConsoleColor.Yellow)},
            {TextureName.space, new Texture(' ', ConsoleColor.White)},
            {TextureName.nothing, new Texture(' ', ConsoleColor.Black)}
        };

        #region Class Constructor
        public Texture(char symbol, ConsoleColor backgroundColor)
        {
            this.symbol = symbol;
            this.backgroundColor = backgroundColor;
            this.foregroundColor = backgroundColor;
        }
        public Texture(char symbol, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
            : this(symbol, backgroundColor)
        {
            this.foregroundColor = foregroundColor;
        }
        #endregion

        public void Print()
        {
            if (Console.ForegroundColor != foregroundColor) Console.ForegroundColor = this.foregroundColor;
            if (Console.BackgroundColor != backgroundColor) Console.BackgroundColor = this.backgroundColor;
            Console.Write(symbol);
        }

        public void Print(Position position)
        {
            Print(position.X, position.Y);
        }

        public void Print(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Print();
        }
    }
}
