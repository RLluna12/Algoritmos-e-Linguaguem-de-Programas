using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idade_doar_sangue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.Write("sua Idade:");
                idade = int.Parse(Console.ReadLine());
            if (idade >=18 && idade <= 67)
            {
                Console.WriteLine("pode doar sangue");
            }
            else
            {
                Console.WriteLine("nao pode doar sangue");
            }



        }
    }
}
