using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static void Main(string[] args)
        {
            //Problem2066();
        }
    }
}
