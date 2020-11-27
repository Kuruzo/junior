using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyFirstGame
{
    class Player : GameObject
    {
        // Action, Func

        public static event Func<Position, bool> Moved;

        public Player(Position position, Texture texture)
            : base(position, texture) { Print(); }

        public void WaitKeyForMoving()
        {
            while (true)
            {
                bool todo = true;
                Position.Direction direction = 0;

                ConsoleKey consoleKey = Console.ReadKey(true).Key;
                switch (consoleKey)
                {
                    case ConsoleKey.A: direction = Position.Direction.Left; break;
                    case ConsoleKey.W: direction = Position.Direction.Up; break;
                    case ConsoleKey.D: direction = Position.Direction.Right; break;
                    case ConsoleKey.S: direction = Position.Direction.Down; break;

                    case ConsoleKey.LeftArrow: direction = Position.Direction.Left; break;
                    case ConsoleKey.UpArrow:   direction = Position.Direction.Up; break;
                    case ConsoleKey.RightArrow:direction = Position.Direction.Right; break;
                    case ConsoleKey.DownArrow: direction = Position.Direction.Down; break;
                    
                    case ConsoleKey.Escape: todo = false; break;
                    default:
                        Message message = new Message(new Position(3, 12)); // make metod in CurrentLevel
                        message.Write("Incorrect Key. To Exit press ESC");
                        continue;
                }

                if (todo != true) break;
                else Move(direction);
            }
        }

        public void Move(Position.Direction direction)
        {
            position.Step(direction);
            //Moved(position);
            //Print();
        }
    }
}
