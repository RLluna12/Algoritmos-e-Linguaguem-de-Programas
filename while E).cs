using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 1, soma = 0;
            while (i <= 50)
            {
                i++;
                if (i % 2 == 0)
                {
                    soma = soma + i;
                    Console.WriteLine("Resultado: " + soma);
                }
            }

            
            

            

        }
    }
}
