using System;

namespace MyExceptionStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Division(42, 0);
            Console.WriteLine(Fak(6));
            Console.WriteLine(Fak(-1));
        }

        static int Division(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("¡Ay, ay, ay, no me gusta!");
                return 0;
            }     
        }

        static int Fak(int n)
        {
            if(n<0)
            {
                throw new ArgumentException("all your base are belong to us");
            }
            if (n==0)
            {
                return 1;
            }
            else
            {
                return n * Fak(n - 1);
            }
        }
    }
}
