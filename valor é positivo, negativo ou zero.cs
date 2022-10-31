using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
            //numero 0
            if (a == 0)
            {
                return a = 0;
            }
            //numero positivo
            if (a>0)
            {
                return a = 1;
            }
            //numero negativo
            else
            {
                return a = -1;
            }
        }
    }
}
