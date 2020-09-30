using System;

namespace CSharpLight
{
    static partial class MapGame
    {
        public class Texture
        {
            public readonly char symbol;
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

            public void PrintTexture()
            {
                Console.ForegroundColor = foregroundColor;
                Console.BackgroundColor = backgroundColor;
                Console.Write(symbol);
            }

            public void PrintTexture(Position position)
            {
                Console.SetCursorPosition(position.XPos, position.YPos);
                Console.ForegroundColor = foregroundColor;
                Console.BackgroundColor = backgroundColor;
                Console.Write(symbol);
            }
        }

    }
}
