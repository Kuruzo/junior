using System.Drawing;

namespace MyFirstGame
{
    public class Position 
    {

        //Point position = new Point();
        protected int x;
        protected int y;

        #region Block Set
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
        #endregion

        #region Block Get
        public int X { get => x; }
        public int Y { get => y; }

        public Position Get()
        {
            return new Position(x, y);
        }

        private Position Get(int x, int y)
        {
            return new Position(x, y);
        }
        #endregion

        // Moving at coordinates
        public void Step(string direction, int distance = 1)
        {
            // TODO use enum for directions
            switch (direction)
            {
                case "Up": y -= distance; break;
                case "Down": y += distance; break;
                case "Left": x -= distance; break;
                case "Right": x += distance; break;
            }            
        }

        public Position Up(int distance = 1) { return Get(x, y - distance); }
        public Position Down(int distance = 1) { return Get(x, y + distance); }
        public Position Left(int distance = 1) { return Get(x - distance, y); }
        public Position Right(int distance = 1) { return Get(x + distance, y); }
    }
}
