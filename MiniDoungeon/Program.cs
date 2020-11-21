using System;
using static System.Console;

namespace MiniDoungeon
{
    class Program
    {
        static void Main()
        {
            WriteLine("Schreiben nummer: ");
            int inputNumber = Convert.ToInt32(ReadLine());

            int tempNumber = 2;
            int exp = 0;
            while (true)
            {
                if (inputNumber < tempNumber) { exp++; break; }
                else { exp++; tempNumber = tempNumber * 2; }
            }

            tempNumber = inputNumber;
            int[] arrResult = new int[exp];

            for (int i = exp; i > 0; i--)
            {
                arrResult[i - 1] = tempNumber % 2;
                tempNumber = tempNumber / 2;
            }
            
            WriteLine();
            WriteLine();

            string str
                Result = "";
            for (int i = 0; i < arrResult.Length; i++)
            {
                strResult += (char)arrResult[i];
                Write(arrResult[i]);
            }

            WriteLine();
            WriteLine();
        }
    }
}
