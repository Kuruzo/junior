﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue.StartMainMettod();
            Console.WriteLine("Hello!");
            Console.WriteLine(DigitalRoot(123));
        }
        public static int DigitalRoot(long n)
        {
            int result = 0;
            foreach (int item in Convert.ToString(n))
            {
                result += item - '0';
            }

            if (result > 9)
            {
                return DigitalRoot(Convert.ToInt64(result));
            }
            else return result;
        }
    }  
}
