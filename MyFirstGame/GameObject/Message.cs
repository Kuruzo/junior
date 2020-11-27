using System;

namespace MyFirstGame
{

    public class Message
    {
        protected Position position;

        public Message(Position position)
        {
            this.position = position;
        }

        public void Write(string messageString, ConsoleColor messageColor = ConsoleColor.DarkGray)
        {
            Console.SetCursorPosition(position.X, position.Y);
            if (Console.BackgroundColor != ConsoleColor.Black) Console.BackgroundColor = ConsoleColor.Black;
            if (Console.ForegroundColor != messageColor) Console.ForegroundColor = messageColor;
            Console.WriteLine(">> " + messageString);
        }
    }

    //public class Exeption : Message
    //{
    //    public Exeption(Position position) : base(position) { }

    //    public void Write(string message)
    //    {
    //        Write(" !#@%^! " + message + " !#@%^! ", ConsoleColor.Red);
    //    }
    //}
}
