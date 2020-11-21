using System;

namespace MyFirstGame
{

    public class Message
    {
        private Position position;

        public Message(int x, int y)
        {
            position = new Position(x, y);
        }



        public void WriteMessage(string message, bool isExeption = false)
        {
            if (isExeption == false) Console.ResetColor();
            Console.SetCursorPosition(position.X, position.Y);
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
