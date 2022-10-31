using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
       public static void Main(string[] args)
        {
            int v, a;
            a = int.Parse(Console.ReadLine());
            v = M(a);
            Console.WriteLine(v);
        }
        public static int M(int a)
       {
            
            if (a % 2 == 0)
            {
                return a = 0;
            }
            else
            {
                return a=1;
            }
       }
    }
}
