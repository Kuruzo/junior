using System;

namespace MyFirstGame
{
    public class Position
    {
        protected int x;
        protected int y;

        // Block Set
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Set(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Set(Position position)
        {
            this.x = position.x;
            this.y = position.y;
        }

        //public void SetCursorPosition()
        //{
        //    Console.SetCursorPosition(xPos, yPos);
        //}

        // Block Get
        public int X { get; }
        public int Y { get; }

        public Position Get(Position position)
        {
            return position;
        }

        // Moving at coordinates
        public void Up() => y--; 
        public void Down() => y++; 
        public void Left() => x--; 
        public void Right() => x++; 

        public void Up(int i) => y -= i; 
        public void Down(int i) => y += i; 
        public void Left(int i) => x -= i; 
        public void Right(int i) => x += i; 
    }
}
