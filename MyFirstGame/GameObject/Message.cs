using System;

namespace MyFirstGame
{

    public interface IDrawable
    {
        ConsoleColor ForegroundColor { get; }
    }

    public class Message
    {
        protected Position position;

        public Message(Position position)
        {
            this.position = position;
        }

        public void Write(string messageString, ConsoleColor messageColor = ConsoleColor.DarkGray)
        {
            // Дублируется код. 
            // Класс Drawer (Printer), который отвечает за отрисовку объектов. 
            // Все рисуемые объекты имеют интерфейс IDrawable, где висят свойства сообщения, цветов и выводимого символа
            // Класс Drawer вызывает метод Draw и получает экземпляр IDrawable для отрисовки и определяет общий алгоритм рисования
            // Drawer является статическим (для упрощения. Более интересный вариант - синглтон. Самый интересный - DI)
            // ОГРАНИЧЕНИЕ: если планируется какой-то объект со сложным алгоритмом рисования, то будет не очень работать            
            Console.SetCursorPosition(position.X, position.Y);
            if (Console.BackgroundColor != ConsoleColor.Black) Console.BackgroundColor = ConsoleColor.Black;
            if (Console.ForegroundColor != messageColor) Console.ForegroundColor = messageColor;
            Console.WriteLine(">> " + messageString);
        }

        public void Draw(IDrawable instance)
        {

        }
    }

    public class Exeption : Message
    {
        public Exeption(Position position) : base(position) { }

        public void Write(string message)
        {
            Write(" !#@%^! " + message + " !#@%^! ", ConsoleColor.Red);
        }
    }
}
