using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        public static void Main(string[] args)
        {
            double area, Base;
            Console.WriteLine("Digite area do triangulo:");
            area = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite base do triangulo: ");
            Base = double.Parse(Console.ReadLine());
            double mult = M(area, Base);
            Console.WriteLine(mult);
        }
        public static double M(double x, double y)
        {
            double mult = (x * y)/2;
            return mult;
        }
    }
}
