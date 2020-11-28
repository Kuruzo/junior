using System;
using static System.Console;
using System.Collections.Generic;

namespace MyFirstGame
{
    class GameObject
    {
        public Position position { get; set; }
        public Texture texture { get; }
        public bool passeble { get; }

        public GameObject() { }

        public GameObject(Position position, Texture texture, bool passeble = false)
        {
            this.position = position;
            this.texture = texture;
            this.passeble = passeble;
        }

        public void Print()
        {
            // Дублирование кода. См класс message
            Console.SetCursorPosition(position.X, position.Y);
            if (Console.ForegroundColor != texture.foregroundColor) Console.ForegroundColor = texture.foregroundColor;
            if (Console.BackgroundColor != texture.backgroundColor) Console.BackgroundColor = texture.backgroundColor;
            Console.Write(texture.symbol);

            // пример использования this из класса Texture
            Texture t = texture[Name.wall];            
        }
    }
}
