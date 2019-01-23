using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var function = GetOperator('+');
            Console.WriteLine(function(5, 6));
        }

        static Func<int,int,int> GetOperator(char op)
        {
            if(op=='+')
            {
                return (a, b) => (a + b);
            }
            if (op == '-')
            {
                return (a, b) => (a - b);
            }
            if (op == '*')
            {
                return (a, b) => (a * b);
            }
            if (op == '/')
            {
                return (a, b) => (a / b);
            }
            return (a, b) => (0);
        }
    }
}
