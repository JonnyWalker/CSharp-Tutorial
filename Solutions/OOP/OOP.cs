using System;

namespace OOP
{
    class OOP
    {
        static void Main(string[] args)
        {
            var a = new Complex(7, 4);
            var b = new Complex(3, 5);
            var c = a + b;
            Console.WriteLine(c);
            var m = new Mitarbeiter("John", 34, 1234);
            Console.WriteLine(m.Alter);
            int i = 5;
            RefTest(m, ref i);
            Console.WriteLine(i);
            Console.WriteLine(m.Alter);
        }

        static void RefTest(Person p, ref int i)
        {
            p.Altern();
            i++;
        }
    }
}
