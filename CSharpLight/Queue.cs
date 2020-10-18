using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLight
{
    class Queue
    {
        public static void Run()
        {
            Console.WriteLine("Wellcome to <Queue>!");
            Console.WriteLine("How much women you see: ");
            int womenInQueue = Convert.ToInt32(Console.ReadLine());

            const short timeForOneWoman = 10;
            var fullTime = womenInQueue * timeForOneWoman;
            var hours = fullTime / 60;
            var minets = fullTime % 60;

            Console.WriteLine($"You have to wait: {hours} hour(s) and {minets} minet(s).");
        }
    }
}
