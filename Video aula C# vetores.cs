using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite N: ");
            int N = int.Parse(Console.ReadLine());
            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2]);
            }
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma += alturas[i];
            }
            double media = soma / N;
            Console.WriteLine("Altura media : " + media.ToString("F2"));
            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagem = (double) cont / N * 100.0;
            Console.WriteLine("Pessoas com menor de 16 anos : " + porcentagem.ToString("F1") + "%");    
        }
    }
}
