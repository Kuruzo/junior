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
        public static void StartMainMettod()
        {
            Console.WriteLine("Welcome to <Cristal Shop>!");

            Console.WriteLine("How much Gold do you have?");
            int countGold = Convert.ToInt32(Console.ReadLine());

            const int CristalPrice = 23;
            Console.WriteLine($"Good! Cristal cost {CristalPrice} Gold. How much do you want?");
            int cristalOrder = Convert.ToInt32(Console.ReadLine());

            if (countGold >= cristalOrder * CristalPrice)
            {
                countGold -= cristalOrder * CristalPrice;
            }
            else
            {
                cristalOrder = countGold / CristalPrice;
                countGold -= cristalOrder * CristalPrice;
            }

            Console.WriteLine($"Your Gold is enough for {cristalOrder} Cristal.");
            Console.WriteLine("Thanks for your purchase! Good bye!");
            Console.WriteLine();
            Console.WriteLine($"Hmm...I have {countGold} Gold and {cristalOrder} Cristal.");
        }
    }
}
