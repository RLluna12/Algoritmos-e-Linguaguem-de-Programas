using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplo_de_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
                Console.Write("Digite seu numero inteiro: ");
            n1 = int.Parse(Console.ReadLine());
            
            if (n1 %7==0)
            {
                Console.WriteLine("seu numero é um multiplo de 7");
            }
            else
            {
                Console.WriteLine("nao é um multiplo de 7");
            }

        }
    }
}
