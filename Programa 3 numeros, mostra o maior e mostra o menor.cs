using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sei_la
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            Console.WriteLine("digite n1");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite n2");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite n3");
            n3 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n2 < n3)
            {
                Console.WriteLine("N1= {0} é maior e N2= {1} o menor", n1,n2);
            }
            else if (n1 > n2 && n1 > n3 && n3 < n2)
            {
                Console.WriteLine("N1= {0} é maior e N3= {1} o menor", n1, n3);
            }
            else if (n2 > n1 && n2 > n3 && n1 < n3)
            {
                Console.WriteLine("N2= {0} é maior e N1= {1} o menor", n2, n1);
            }
            else if (n2 > n1 && n2 > n3 && n3 < n1)
            {
                Console.WriteLine("N2= {0} é maior e N3= {1} o menor", n2, n3);
            }
            else if (n3 > n1 && n3 > n2 && n1 < n2)
            {
                Console.WriteLine("N3= {0} é maior e N1= {1} o menor", n3, n1 );
            }
            else if (n3 > n1 && n3 > n2 && n2 < n1)
            {
                Console.WriteLine("N3= {0} é maior e N2= {1} o menor", n3, n2);
            }





        }
    }
}
