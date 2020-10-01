namespace CSharpLight
{
    static partial class MapGame
    {
        public class Position
        {
            public int xPos, yPos;

            public void Set(int x, int y)
            {    
                xPos = x;
                yPos = y;
            }
        }
    }
}
