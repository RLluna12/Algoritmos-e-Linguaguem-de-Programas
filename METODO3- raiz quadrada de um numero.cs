using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        public static void Main(string[] args)
        {
            double a, r;
            Console.WriteLine("Digite um numero:");
            a = double.Parse(Console.ReadLine());
            r = M(a);
            Console.WriteLine(r);
        }
        public static double M(double x)
        {
            double r = 0;
            r+=Math.Sqrt(x);
            return r;
        }
    }
}
