using System;
using static System.Console;
using System.Collections.Generic;

namespace MyFirstGame
{
    class GameObject
    {
        public Position position { get; set; }
        private Texture texture { get; }

        public GameObject(Position position, Texture texture)
        {
            this.position = position;
            this.texture = texture;

            Player.Moved += OnMovedEventHandler;
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
}
