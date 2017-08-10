using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SmallPrograms
{
    class SmallProgram
    {
        static void P1()
        {
            for (int i = 0; i < 4; i++)
                Console.WriteLine(string.Concat(Enumerable.Repeat("  ", i)) + (i + 13));
        }

        static void P2()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Тимус 2066. Simple Expression
        /// </summary>
        static void Problem2066()
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Min(a - b - c, a - b * c));
        }

        /// <summary>
        /// Тимус 1924. Four Imps
        /// </summary>
        static void Problem1924()
        {
            //Похоже что неважно как расставлять плюсы и минусы, итоговая четность зависит только от количества чисел.
            //Закономерность такая ННЧЧННЧЧННЧЧ...
            int mod = int.Parse(Console.ReadLine()) % 4;
            if (mod == 1 || mod == 2)
                Console.WriteLine("grimy");
            else
                Console.WriteLine("black");
        }

        /// <summary>
        /// Тимус 2023. Donald is a postman
        /// </summary>
        static void Problem2023()
        {
            string[,] cases = new string[3,9] { { "Alice", "Ariel", "Aurora", "Phil", "Peter", "Olaf", "Phoebus", "Ralph", "Robin" },
                                              { "Bambi", "Belle", "Bolt", "Mulan", "Mowgli", "Mickey", "Silver", "Simba", "Stitch" },
                                              { "Dumbo", "Genie", "Jiminy", "Kuzko", "Kida", "Kenai", "Tarzan", "Tiana", "Winnie" } };
            int n = int.Parse(Console.ReadLine());
            int steps = 0, currentPosition = 0;
            string name;

            for (int k = 0; k < n; k++)
            {
                name = Console.ReadLine();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (cases[i, j] == name)
                        {
                            steps += Math.Abs(currentPosition - i);
                            currentPosition = i;
                        }
                    }
                }
            }
            Console.WriteLine(steps);
        }

        /// <summary>
        /// Timus 1001. Reverse Root
        /// </summary>
        static void Timus1001()
        {
            foreach (string s in (Console.In.ReadToEnd().Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Reverse()))
            {
                Console.WriteLine(Math.Sqrt(double.Parse(s)).ToString("F4"));
            }
        }


        /// <summary>
        /// Timus 1787. Turn for MEGA
        /// </summary>
        static void Timus1787()
        {
            var k = int.Parse(Console.ReadLine().Split()[0]);
            var carsPerMinute = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int extraCars = 0;

            foreach (var i in carsPerMinute)
            {
                extraCars = (i + extraCars > k) ? (i + extraCars - k) : 0;
            }

            Console.WriteLine(extraCars);
        }
        
        /// <summary>
        /// Timus 1880. Psych Up's Eigenvalues
        /// </summary>
        static void Timus1880()
        {
            var eigenValues = new int[3][];
            Console.ReadLine();
            eigenValues[0] = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
            Console.ReadLine();
            eigenValues[1] = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
            Console.ReadLine();
            eigenValues[3] = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
            var result = eigenValues[0].Intersect(eigenValues[1]).Intersect(eigenValues[2]).ToArray();
            Console.WriteLine(result.Length);
        }

        /// <summary>
        /// Timus 1910. Titan Ruins: Hidden Entrance
        /// </summary>
        static void Timus1910()
        {
            var count = int.Parse(Console.ReadLine()) - 2;
            var input = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
            int maxSum = 0;
            int tempSum;
            int index = 1;
            for (int i = 0; i < count; i++)
            {
                tempSum = input[i] + input[i + 1] + input[i + 2];
                if (maxSum < tempSum)
                {
                    maxSum = tempSum;
                    index = i;
                }
            }
            Console.WriteLine("{0} {1}", maxSum, index + 2);
        }

        /// <summary>
        /// Timus 1567. SMS-spam
        /// </summary>
        static void Timus1567()
        {
            int sum = 0;
            var letters = new string[] { "adgjmpsvy. ", "behknqtwz,", "cfilorux!" };
            foreach (char c in Console.ReadLine())
                for (int i = 0; i < 3; i++)
                    if (letters[i].Contains(c))
                        sum += i + 1;
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            Timus1567();
        }
    }
}
