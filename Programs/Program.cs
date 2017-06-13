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

        /// <summary>
        /// Вычисляет сумму всех положительных чисел меньших limit и кратных значениям из массива multiplicity
        /// </summary>
        static int Expr10(int limit, int[] multiplicity)
        {
            int result = 0;

            bool CheckMultiplicity(int numForCheck)
            {
                for (int i = 0; i < multiplicity.Length; i++)
                {
                    if (numForCheck % multiplicity[i] == 0)
                    {
                        return true;
                    }
                }
                return false;
            }

            for (int i = 0; i < limit; i++)
            {
                if (CheckMultiplicity(i))
                {
                    result += i;
                }
            }
            return result;
        }

        /// <summary>
        /// Вычисляет угол между часовой и минутной стрелками
        /// </summary>
        static int Expr11(int hours, int minutes)
        {
            hours %= 12;
            int hoursDegrees = hours * 30;
            int minutesDegrees = minutes * 6;
            int diff = Math.Abs(minutesDegrees - hoursDegrees);
            return Math.Min(diff, 360 - diff);
        }

        /// <summary>
        /// Задача с тимуса 1084. Пусти козла в огород
        /// </summary>
        static void Expr13()
        {
            //Идея: 2 случая, если радиус круга меньше половины стороны квадрата;
            //если больше, то считаем площади секторов без крышечек
            string[] input = Console.ReadLine().Split();
            double side, cord;
            side = double.Parse(input[0]);
            cord = double.Parse(input[1]);
            double result;
            if (cord < side / 2)
            {
                result = Math.PI * Math.Pow(cord, 2);
            }
            else if (cord >= Math.Sqrt(2 * Math.Pow(side, 2)) / 2)
            {
                result = Math.Pow(side, 2);
            }
            else
            {
                double sinAuxAngle = (side / 2) / cord;
                double angle = Math.PI - 2 * Math.Asin(sinAuxAngle);
                double areaSector = Math.PI * Math.Pow(cord, 2) * angle / (2 * Math.PI);
                double areaTriangle = Math.Pow(cord, 2) * Math.Sin(angle) / 2;
                result = Math.PI * Math.Pow(cord, 2) - (areaSector - areaTriangle) * 4;
            }
            Console.WriteLine(String.Format("{0:F3}", result));
        }

        /// <summary>
        /// Задача с тимуса 1885. Комфорт пассажиров
        /// </summary>
        static void Expr12()
        {
            //x*t1 + v*t2 = h; t1 + t2 = t. Решаем систему, находим t2.
            //Если t2 неположительно, значит можем весь путь лететь со скоростью x, 
            //а max находим при движении со скоростью x + epsilon.
            //Вообще идея в том что нам нужно лететь максимально долго с максимальной скоростью, 
            //при которой не закладывает уши. Это скорость x, так мы получаем min.
            int h, t, v, x;
            string[] input = Console.ReadLine().Split();
            h = int.Parse(input[0]);
            t = int.Parse(input[1]);
            v = int.Parse(input[2]);
            x = int.Parse(input[3]);

            double min, max, tBlocked;
            tBlocked = (double)(h - t * x) / (v - x);
            if (tBlocked <= 0)
            {
                min = 0;
                max = (double)h / x;
            }
            else
            {
                min = tBlocked;
                max = (double)t;
            }
            Console.WriteLine(min + " " + max);
        }
        static int BinarySearch(int[] arr, int number)
        {
            // написать код двоичного поиска
            return 0;
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
            Console.WriteLine(Expr10(1000, new int[] { 3, 5 }));
            Console.WriteLine(Expr11(20, 51));
            //Expr13();
            //Expr12();
            
        }
    }
}
