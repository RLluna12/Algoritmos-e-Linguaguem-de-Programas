using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
       public static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Digite numero a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero: ");
            b = double.Parse(Console.ReadLine());
            double mult = M(a, b);
            Console.WriteLine(mult);
        }
        public static double M (double x,double y)
        {
            double mult = x * y;
            return mult;
        }
    }
}
