using System;

namespace Programs
{
    class Program
    {
        /// <summary>
        /// Меняет местами значения двух переменных
        /// </summary>
        static void ExchangeTwoVariables(int a, int b )
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("{0} {1}", a, b);
        }

        /// <summary>
        /// Записывает трехзначное число наоборот
        /// </summary>
        static void Reverse3DigitsNumber(int number)
        {
            int n0, n1, n2;
            n0 = number % 10;
            number /= 10;
            n1 = number % 10;
            n2 = number / 10;
            Console.WriteLine(n2 + n1 * 10 + n0 * 100);
        }

        /// <summary>
        /// Дано время ровно hour часов. Находит угол между часовой и минутной стрелками.
        /// </summary>
        static void ShowAngle(int hour)
        {
            hour %= 12;
            Console.WriteLine(Math.Abs((hour / 6) * 180 - (hour % 6) * 30));
        }

        /// <summary>
        /// Сделай то не знаю что
        /// </summary>
        static string Decode(string str)
        {
            str = str.Replace(".", "");
            return (int.Parse(str) % 1024).ToString();
        }

        static void Main(string[] args)
        {
            ExchangeTwoVariables(1, 2);
            Reverse3DigitsNumber(450);
            Reverse3DigitsNumber(459);
            ShowAngle(22);
            ExchangeTwoVariables(3, 4);
            Console.WriteLine(Decode("12....3"));
        }
    }
}
