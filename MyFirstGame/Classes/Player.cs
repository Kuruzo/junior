using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyFirstGame
{
    class Player : Enemy
    {
        public Player(Position position, Texture texture)
            : base(position, texture) { texture.Print(position); }

        public void WaitMoving()
        {
            while (true)
            {
                ConsoleKey consoleKey = Console.ReadKey(true).Key;
                Map.PrintByPosition(position);
                switch (consoleKey)
                {
                    case ConsoleKey.UpArrow:
                        if (Map.TextureByPosition(position.Up()).IsPassable()) 
                            position.Step("Up"); 
                        break;
                    case ConsoleKey.DownArrow: if (Map.TextureByPosition(position.Down()).IsPassable()) 
                            position.Step("Down");
                        break;
                    case ConsoleKey.LeftArrow: if (Map.TextureByPosition(position.Left()).IsPassable()) 
                            position.Step("Left"); 
                        break;
                    case ConsoleKey.RightArrow: if (Map.TextureByPosition(position.Right()).IsPassable()) 
                            position.Step("Right"); 
                        break;
                    case ConsoleKey.Escape: goto exit;
                    default:
                        texture.Print(position);
                        Program.Message message = new Program.Message(3, 12);
                        message.Exeption("Incorrect Key. To Exit press ESC");
                        break;
                }
                texture.Print(position);
            }
        exit:;
        }

        private void CanMove(Position position)
        {
            if (Map.TextureByPosition(position).IsPassable()) this.position = position;
        }
    }
}
