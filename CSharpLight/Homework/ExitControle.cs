using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLight
{
    class ExitControle
    {
        public static void Run()
        {
            Console.WriteLine("You can exit only writing \"exit\"");
            while (true)
            {
                if (Console.ReadLine() == "exit") break;
            }
        }
    }
}
