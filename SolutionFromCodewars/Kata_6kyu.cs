using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionFromCodewars
{
    public static class Kata_6kyu
    {
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
