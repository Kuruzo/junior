using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLight
{
    class Queue
    {
        public static void StartMainMettod()
        {
            Console.WriteLine("Wellcome to <Queue>!");
            Console.WriteLine("How much women you see: ");
            int womenInQueue = Convert.ToInt32(Console.ReadLine());

            const int timeForOneWoman = 10;
            int fullTime = womenInQueue * timeForOneWoman;

            Console.WriteLine($"You have to wait: {fullTime / 60} hours and {fullTime % 60} minets.");
        }
    }
}
