namespace CSharpLight
{
    static partial class MapGame
    {
        public class Position
        {
            private int xPos, yPos;

            public void SetPosition(int x, int y)
            {    
                xPos = x;
                xPos = y;
            }

            // Block Get
            public int XPos { get => xPos; }
            public int YPos { get => yPos; }
        }
    }
}
