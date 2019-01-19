using System;

namespace OOP
{
    class OOP
    {
        static void Main(string[] args)
        {
            TestComplex();
            TestPerson();
            TestKaffee();
        }

        static void TestComplex()
        {
            var a = new Complex(7, 4);
            var b = new Complex(3, 5);
            var c = a + b;
            Console.WriteLine(c);
        }

        static void TestPerson()
        {
            var m = new Mitarbeiter("John", 34, 1234);
            Console.WriteLine(m.Alter);
            int i = 5;
            RefTest(m, ref i);
            Console.WriteLine(i);
            Console.WriteLine(m.Alter);
        }

        static void TestKaffee()
        {
            var k0 = new Kaffeemaschine();
            k0.BohnenAuffuellen(10);
            k0.WasserAuffuellen(10);
            var k1 = new Kaffeemaschine();
            k1.BohnenAuffuellen(7);
            k1.WasserAuffuellen(7);
            var k2 = new Kaffeemaschine();
            k2.BohnenAuffuellen(10);
            k2.WasserAuffuellen(10);
            Console.WriteLine(k0 == k1);
            Console.WriteLine(k0 == k2);
        }

        static void RefTest(Person p, ref int i)
        {
            p.Altern();
            i++;
        }
    }
}
