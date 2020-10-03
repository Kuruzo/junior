using System;

namespace MyFirstGame
{
    partial class Program
    {
        public class Message : Position
        {
            public Message(int x, int y) : base(x, y)
            {
                //this.x = base.x;
                //this.y = base.y;
            }

            public void WriteMessage(string message)
            {
                Console.ResetColor();
                Console.SetCursorPosition(x, y);
                Console.WriteLine(">> " + message);
            }

            public void Exeption(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                WriteMessage(" !#@%^! " + message + " !#@%^! ");
            }
        }
    }
}
