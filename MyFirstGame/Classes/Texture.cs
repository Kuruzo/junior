using System;

namespace MyFirstGame
{
    public class Texture
    {
        protected readonly char symbol;
        protected readonly ConsoleColor foregroundColor;
        protected readonly ConsoleColor backgroundColor;
        protected readonly bool passable = true;

        #region Class Constructor
        public Texture(char symbol, ConsoleColor backgroundColor)
        {
            this.symbol = symbol;
            this.backgroundColor = backgroundColor;
        }

        public Texture(char symbol, ConsoleColor backgroundColor, bool passable)
            : this(symbol, backgroundColor)
        {
            this.passable = passable;
        }

        public Texture(char symbol, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
            : this(symbol, backgroundColor)
        {
            this.foregroundColor = foregroundColor;
        }

        public Texture(char symbol, ConsoleColor backgroundColor, ConsoleColor foregroundColor, bool passable)
            : this(symbol, backgroundColor, passable)
        {
            this.foregroundColor = foregroundColor;
        }
        #endregion

        public bool IsPassable()
        {
            return (passable == true) ? true : false;
        }

        public void Print()
        {
            if (Console.ForegroundColor != foregroundColor) Console.ForegroundColor = foregroundColor;
            if (Console.BackgroundColor != backgroundColor) Console.BackgroundColor = backgroundColor;
            Console.Write(symbol);
        }

        public void Print(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Print();
        }

        public void Print(Position position)
        {
            Print(position.X, position.Y);
        }
    }
}
