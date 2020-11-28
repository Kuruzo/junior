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
        // Можно объявить 
        public enum Direction : byte
        { Up, Down, Left, Right }

        public void Step(Direction direction, int distance = 1)
        {
            switch (direction)
            {
                case Direction.Up: y -= distance; break;
                case Direction.Down: y += distance; break;
                case Direction.Left: x -= distance; break;
                case Direction.Right: x += distance; break;
            }            
        }

        public Position OnStep(Direction direction, int distance = 1)
        {
            switch (direction)
            {
                case Direction.Up: return Get(x, y - distance);
                case Direction.Down: return Get(x, y + distance);
                case Direction.Left: return Get(x - distance, y);
                case Direction.Right: return Get(x + distance, y);
                
            }

            throw new System.Exception();
        }
    }
}
