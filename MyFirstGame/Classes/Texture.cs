using System;

namespace MyFirstGame
{
    public class Texture
    {
        protected readonly char symbol;
        protected readonly ConsoleColor foregroundColor;
        protected readonly ConsoleColor backgroundColor;
        protected readonly bool passable = true;

        public Texture(char symbol, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            this.symbol = symbol;
            this.foregroundColor = foregroundColor;
            this.backgroundColor = backgroundColor;
        }

        public Texture(char symbol, ConsoleColor foregroundColor, ConsoleColor backgroundColor, bool passable)
            : this(symbol, foregroundColor, backgroundColor)
        {
            this.passable = passable;
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
    }
}
