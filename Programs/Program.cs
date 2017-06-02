﻿using System;

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
        /// Находит расстояние от точки (x0,y0) до прямой, заданной двумя точками
        /// </summary>
        static void Distance(double x0, double y0, double x1, double y1, double x2, double y2)
        {
            double distance = (Math.Abs((y2-y1)*x0 - (x2-x1)*y0 + x2*y1 - y2*x1)) / (Math.Sqrt((y2-y1)*(y2 - y1) + (x2-x1)* (x2 - x1)));
            Console.WriteLine($"Distance = {distance}");
        }

        /// <summary>
        /// Сделай то не знаю что
        /// </summary>
        static int Decode(string str)
        {
            str = str.Replace(".", "");
            return (int.Parse(str) % 1024);
        }

        /// <summary>
        /// Вычисляет сумму на момент окончания вклада
        /// </summary>
        /// <param name="userInput">
        /// Строка из трех чисел, разделенных пробелами: первоначальная сумма, процент годовых, количество месяцев
        /// </param>
        public static double Calculate(string userInput)
        {
            string[] inputArray = userInput.Split(new char[] { ' ' });
            double initialSum = double.Parse(inputArray[0]);
            double percentInMonth = 1 + double.Parse(inputArray[1]) / 100 / 12;
            double numberOfMonths = double.Parse(inputArray[2]);
            double totalPercentage = Math.Pow(percentInMonth, numberOfMonths);

            return initialSum *= totalPercentage;
        }

        static void Main(string[] args)
        {
            ExchangeTwoVariables(1, 2);
            Reverse3DigitsNumber(450);
            Reverse3DigitsNumber(459);
            ShowAngle(22);
            ExchangeTwoVariables(3, 4);
            Console.WriteLine(Decode("12....3"));
            Distance(1, 0, 0, 1, 0, 2);
            Console.WriteLine(Calculate("10000 12 12"));
        }
    }
}
