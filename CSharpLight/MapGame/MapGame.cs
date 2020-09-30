using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharpLight
{
    static partial class MapGame
    {
        // Start Game
        static public void Run()
        {
            Console.CursorVisible = false;
            Map.Pain();
            Console.ResetColor();

        }

        static void Moving()
        {
            object pressedKey;
            while (true)
            {
                pressedKey = Console.ReadKey().Key;
                if (true)
                switch (pressedKey)
                {
                    case (ConsoleKey.UpArrow):
                        
                        break;
                    case (ConsoleKey.DownArrow):

                        break;
                    case (ConsoleKey.LeftArrow):

                        break;
                    case (ConsoleKey.RightArrow):

                        break;
                }
            }

        }
    }
}
