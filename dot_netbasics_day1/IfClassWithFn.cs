using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class IfClassWithFn
    {
        static void Main(string[] args)
        {
            int i = 10, j = 20;

            if (isGreater(i, j))
            {
                Console.WriteLine("i is less than j");
            }

            if (isGreater(j, i))
            {
                Console.WriteLine("j is greater than i");
            }
        }

        static bool isGreater(int i, int j)
        {
            return i > j;
        }
    }
    }

