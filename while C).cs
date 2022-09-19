using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 30)
            {
             if(i % 4 == 0)
                    {
                    Console.WriteLine(i);
                }
                    i++;
            }

        }
    }
}
