using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StarProgram
    {
        static void Main(string[] args)
        {
            StarProgram p = new StarProgram();
            p.paint(10);
        }

        public void paint(int n)
        {
            int i, j;
            for (i = n; i > 0; i--)
            {
                for (j = i; j > 0; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }


    }

}
