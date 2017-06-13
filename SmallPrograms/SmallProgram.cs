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
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("  ", i)) + (i + 13));
            }
        }
        static void Main(string[] args)
        {
            P1();
        }
    }
}
