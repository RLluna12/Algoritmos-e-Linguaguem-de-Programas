using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            v[0] = 10;
            v[1] = 9;
            v[2] = 8;
            v[3] = 7;
            v[4] = 6;
            v[5] = 5;
            v[6] = 4;
            v[7] = 3;
            v[8] = 2;
            v[9] = 1;

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}
