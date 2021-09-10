using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter the first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            y = Convert.ToInt32(Console.ReadLine()); //ReadLine returns string , which is explicity converted 

            CalcSum(x, y);
        }
        private static void CalcSum(int a, int b)
        {
            int Sum = a + b;
            Console.WriteLine("the sum is {0}", Sum);
        }
    }
}
