using System;

namespace Programs
{
    class Program
    {
        static void ExchangeTwoVariables(int a, int b )
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("{0} {1}", a, b);
        }
        static void Main(string[] args)
        {
            ExchangeTwoVariables(1, 2);
        }
    }
}
