﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ForNested
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = i; j < 4; j++)
                    Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }
        }
    }
}

