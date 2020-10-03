using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    public class Enemy
    {
        protected Position position;
        protected Texture texture;

        public Enemy(Position position, Texture texture)
        {
            this.position = position;
            this.texture = texture;
        }
    }
}
