using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace CSharpLight
{
    class Converter
    {
        public static void Run()
        {
            double[] count = { 1000, 1000, 1000 };
       
            while (true)
            {
                WriteLine($"Do you have {count[0]} EUR(1), {count[1]} USD(2), {count[2]} MDL(3). Sellect from -> in.\n");
                WriteLine(" *** Use index(*) to choose. Use \"exit\" to exit *** ");
                Write("How many convert?");
                int value = Convert.ToInt32(ReadLine());

                string input;
                int from = 0, to = 0, temp;

                Write("From: "); input = ReadLine();
                if (input == "exit") break;
                switch (input)
                {
                    case "1": from = 0; break;
                    case "2": from = 1; break;
                    case "3": from = 2; break;
                    default:
                        WriteLine("ERROR");
                        continue;
                }

                Write("To: "); input = ReadLine();
                if (from != Convert.ToInt32(input) && count[from] >= value)
                    switch (input)
                    {
                        case "1": to = 0; break;
                        case "2":
                            if (from == 0){ count[1] += value * 0.80;   
                            break;
                        case "3": to = 2; break;
                        default:
                            WriteLine("ERROR");
                            continue;
                    }
                else WriteLine("ERROR");



            }
        }
    }
}
