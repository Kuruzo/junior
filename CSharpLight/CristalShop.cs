using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLight
{
    public class CristalShop
    {
        public static void StartMainProgram()
        {
            Console.WriteLine("Welcome to <Cristal Shop>!");
            
            Console.WriteLine("How much Gold do you have?");
            int countGold = Convert.ToInt32(Console.ReadLine());
            
            const int CristalPrice = 23;
            Console.WriteLine($"Good! Cristal cost {CristalPrice} Gold. How much do you want?");
            int cristalOrder = Convert.ToInt32(Console.ReadLine());

            int countSellCristal = 0;
            for (int i = 1; i <= cristalOrder && countGold >= CristalPrice; i++)
            {
                countSellCristal++;
                countGold -= CristalPrice;
            }

            Console.WriteLine($"Your Gold is enough for {countSellCristal} Cristal.");
            Console.WriteLine("Thanks for your purchase! Good bye!");
            Console.WriteLine();
            Console.WriteLine($"Hmm...I have {countGold} Gold and {countSellCristal} Cristal.");
        }
    }
}