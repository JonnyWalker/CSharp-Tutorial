using System;

namespace Loops
{
    class FizzBuzz
    {
        public static string[] Compute(uint n)
        {
            string[] result = new string[n];
            for (uint i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i-1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    result[i-1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i-1] = "Buzz";
                }
                else
                {
                    result[i-1] = i.ToString();
                    result[i-1] = i.ToString();
                }
            }
            return result;
        }
    }
}
