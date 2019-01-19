using System;

namespace Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            foreach(String s in FizzBuzz.Compute(15))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(Faculty.Compute(9));
        }
    }
}