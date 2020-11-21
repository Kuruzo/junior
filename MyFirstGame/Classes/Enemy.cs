using System;
using static System.Console;
using System.Collections.Generic;

namespace MyFirstGame
{
    class GameObject
    {
        public Position Position { get; set; }
        public Texture texture;

        public Enemy(Position position, Texture texture)
        {
            this.position = position;
            this.texture = texture;

            Player.Moved += OnMovedEventHandler;
        }

        public Enemy()
        {

        }

        public bool OnMovedEventHandler(Position position)
        {
            if (this.position.X == position.X && this.position.Y == position.Y)
            {

                Message message1 = new Message(10, 10);
                message1.WriteMessage("Collided");
                return true;


            }

            Message message = new Message(10, 10);
            message.WriteMessage("Clear");            

            return false;
        }
    }
    
    static class EnemyDictionary
    {
        public static Texture dollar = new Texture('$', ConsoleColor.White, ConsoleColor.DarkGreen);
        public static Position position1 = new Position(1, 2);
        public static Enemy enemy1 = new Enemy(position1, dollar);

        public static Dictionary<string, Enemy> UnitDictionary = new Dictionary<string, Enemy>()
        {
            {"dollar(1, 1)", new Enemy (new Position(1, 2), dollar) },
            {"dollar(2, 2)", new Enemy (position1, dollar) },
        };
    }
}
