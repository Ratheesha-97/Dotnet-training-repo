using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SwtchClass2
    {
        static void Main(string[] args)
        {
            int x = 125;
            switch (x % 2)
            {
                case 0:
                    Console.WriteLine($"{x} is an even value");
                    break;
                case 1:
                    Console.WriteLine($"{x} is an odd Value");
                    break;
            }
        }
    }
}

