using System;

namespace MyFirstGame
{
    public class Position
    {
        protected int xPos;
        protected int yPos;

        // Block Set
        public void Set(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

        public void Set(Position position)
        {
            this.xPos = position.xPos;
            this.yPos = position.yPos;
        }

        public void SetCursorPosition()
        {
            Console.SetCursorPosition(xPos, yPos);
        }

        // Block Get
        //public int XPos { get; }
        //public int YPos { get; }

        public Position Get(Position position)
        {
            position.xPos = this.xPos;
            position.yPos = this.yPos;
            return position;
        }

        // Moving at coordinates
        public void Up() => yPos--; 
        public void Down() => yPos++; 
        public void Left() => xPos--; 
        public void Right() => xPos++; 

        public void Up(int i) => yPos -= i; 
        public void Down(int i) => yPos += i; 
        public void Left(int i) => xPos -= i; 
        public void Right(int i) => xPos += i; 
    }
}
