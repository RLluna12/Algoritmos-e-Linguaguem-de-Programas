using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


              M(ref v);
        }
        public static void M(ref int[] x)
        {

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(x[i]);

            }
        }
    }
}
