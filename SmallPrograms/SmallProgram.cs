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

        static void Main(string[] args)
        {
            //Problem2066();
            //Problem1924();
        }
    }
}
