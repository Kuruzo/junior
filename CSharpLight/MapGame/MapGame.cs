using System;

namespace CSharpLight
{
    static partial class MapGame
    {
        // Start Game
        static public void Run()
        {
            // settup
            Console.CursorVisible = false;

            // Paint Map
            Map.Pain();
            Console.ResetColor();

            // spawn Player
            Player player = new Player();
            player.position.Set(4, 6);
            player.texture.Print(player.position);
            player.Moving();

        }



        public class Player
        {
            public Position position = new Position();
            public Texture texture = new Texture('0', ConsoleColor.White, ConsoleColor.DarkRed);


            public void Moving()
            {
                object pressedKey;
                while (true)
                {
                    pressedKey = Console.ReadKey(true).Key;
                    Map.Print(position.xPos - 1, position.yPos);

                    switch (pressedKey)
                    {
                        case (ConsoleKey.UpArrow):
                            position.yPos--;
                            break;
                        case (ConsoleKey.DownArrow):
                            position.yPos++;
                            break;
                        case (ConsoleKey.LeftArrow):
                            position.xPos--;
                            break;
                        case (ConsoleKey.RightArrow):
                            position.xPos++;
                            break;
                        default:
                            break;
                    }

                    texture.Print(position);
                }
            }
        }
    }
}
