using System;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLight
{
    class WorkWithString
    {
        public static void Run()
        {
            WriteLine("Hi! I need some information about you.");
            Write("That is your name? - ");
            string name = ReadLine();
            Write("How old are you? - ");
            string age = ReadLine();
            Write("There you live? - ");
            string country = ReadLine();
            Write("There you work? - ");
            string work = ReadLine();

            WriteLine($"\n\nYou are {name} and you have {age} years.\nYou live in {country} and you work as/in {work}.");
        }
    }
}
