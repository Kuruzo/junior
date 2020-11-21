using System;

namespace MyFirstGame
{

    public class Message : Position
    {
        public Message(int x, int y) : base(x, y) { }

        public void WriteMessage(string message)
        {
            Console.ResetColor();
            Console.SetCursorPosition(x, y);
            Console.WriteLine(">> " + message);
        }

        public void WriteMessage(string message, bool isExeption)
        {
            if (isExeption == false) Console.ResetColor();
            Console.SetCursorPosition(x, y);
            Console.WriteLine(">> " + message);
        }

        public void Exeption(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            WriteMessage(" !#@%^! " + message + " !#@%^! ", true);
        }
    }

}
