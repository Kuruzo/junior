using System;

namespace MyFirstGame
{
    partial class Program
    {
        public class Message : Position
        {
            public Message(int x, int y)
            {
                xPos = x;
                yPos = y;
            }

            public void WriteMessage(string message)
            {
                Console.ResetColor();
                SetCursorPosition();
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
