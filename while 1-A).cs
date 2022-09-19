using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i<20)
            //{
            //  if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            int i;
            for (i = 1; i < 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
