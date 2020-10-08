using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    class Enemy
    {
        protected Position position;
        protected Texture texture;

        protected Enemy(Position position, Texture texture)
        {
            this.position = position;
            this.texture = texture;
        }
    }
}
