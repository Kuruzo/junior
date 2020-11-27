namespace MyFirstGame
{
    partial class Program
    {
        static void Main()
        {
            Game game = new Game();
            game.Start();
        }
    }
}
// dependency injection
// Autofac

// Player.Moved += OnMovedEventHandler;
//public bool OnMovedEventHandler(Position position)
//{
//    if (this.position.X == position.X && this.position.Y == position.Y)
//    {

//        Message message1 = new Message(new Position(15, 20));
//        message1.Write("Collided");
//        return true;


//    }

//    Message message = new Message(new Position(15, 20));
//    message.Write("Clear");            

//    return false;
//}

