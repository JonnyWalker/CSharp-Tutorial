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
            Console.WriteLine(FloatingEquality(1.0f, 1.00001f));
            Console.WriteLine(CharToAscii(65));
            Console.WriteLine(Gauss(10));
            Console.WriteLine(MaximumSum(10));
            Console.WriteLine(StringSum("41", "1"));
        }

        // https://www.programmierenlernen24.de/csharp-uebungen-bch/
        static bool FloatingEquality(float a, float b)
        {
            return Math.Abs(a-b) < 0.0001;
        }

        static char CharToAscii(int i)
        {
            return (char)i;
        }

        static int AsciiToChar(char c)
        {
            return (int)c;
        }

        static bool SimpleBoolDecider(double arg1, double arg2)
        {
            return arg1<5 || arg1+arg2>100;
        }

        static bool SimpleBoolDecider2(double arg1, double arg2)
        {
            return arg1 > arg2 && SimpleBoolDecider(arg1, arg2);
        }

        static int Gauss(int n)
        {
            if(n<=0)
            {
                return 0;
            }
            else
            {
                return n + Gauss(n - 1);
            }
        }

        static int MaximumSum(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                int i = 0;
                while (sum < n)
                {
                    sum += ++i;
                }
                return sum - i;
            }
        }

        static int StringSum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
    }
}