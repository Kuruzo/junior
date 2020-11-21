using System;
using static System.Console;
using System.Collections.Generic;

namespace MyFirstGame
{
    class Enemy
    {
        public Position position;
        public Texture texture;

        public Enemy(Position position, Texture texture)
        {
            this.position = position;
            this.texture = texture;
        }
    }

    static class EnemyDictionary
    {
        public static Texture dollar = new Texture('$', ConsoleColor.White, ConsoleColor.DarkGreen);
        public static Position position1 = new Position(1, 2);
        public static Enemy enemy1 = new Enemy(position1, dollar);

        public static Dictionary<string, Enemy> UnitDictionary = new Dictionary<string, Enemy>()
        {
            {"dollar(1, 1)", new Enemy{ position = new Position(1, 2), texture = dollar} },
            {"dollar(2, 2)", new Enemy{ position = position1, texture = dollar} },
        };
    }
}
