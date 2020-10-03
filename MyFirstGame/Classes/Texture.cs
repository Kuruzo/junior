using System;

namespace MyFirstGame
{
    class Texture
    {
        private readonly char symbol;
        private readonly ConsoleColor foregroundColor;
        private readonly ConsoleColor backgroundColor;
        private readonly bool passable = true;

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

        public void Print(Position position)
        {
            position.SetCursorPosition();
            Print();
        }
    }
}
