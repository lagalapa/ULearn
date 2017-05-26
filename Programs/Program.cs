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

        static void Reverse3DigitsNumber(int number)
        {
            int n0, n1, n2;
            n0 = number % 10;
            number /= 10;
            n1 = number % 10;
            n2 = number / 10;
            Console.WriteLine(n2 + n1 * 10 + n0 * 100);
        }

        static void Main(string[] args)
        {
            ExchangeTwoVariables(1, 2);
            Reverse3DigitsNumber(450);
            Reverse3DigitsNumber(459);
        }
    }
}
