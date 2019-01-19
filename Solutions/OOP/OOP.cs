using System;

namespace OOP
{
    class OOP
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(7, 4);
            Complex b = new Complex(3, 5);
            Complex c = a + b;
            Console.WriteLine(c);
        }
    }
}
