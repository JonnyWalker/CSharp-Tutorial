﻿namespace Loops
{
    class Faculty
    {
        public static uint Compute(uint n)
        {
            uint result = 1;
            for (uint i=1; i<=n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
