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

            // End
            message.WriteMessage("Buy!");
            Console.ReadKey(true);
        }
    }
}
