using System;

namespace MyFirstGame
{
    partial class Program
    {
        static void Main()
        {
            // settup
            Console.CursorVisible = false;

            // Start
            Map.InitMap();
            Message message = new Message(3, Console.CursorSize - 10);
            message.WriteMessage("Hi!");

            // Spawn Pleyer
            Player player = new Player(new Position(5, 3), new Texture('0', ConsoleColor.White, ConsoleColor.Red));
            player.WaitMoving();

            // End
            message.WriteMessage("Buy!");
            Console.ReadKey(true);

        }
    }
}
