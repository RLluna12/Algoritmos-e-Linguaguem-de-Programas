﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int []v= new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite numero: ");
                v[i] = int.Parse(Console.ReadLine());    
            }
            for (int i = 0; i < 10; i++)
            {
                
                if (v[i] % 2 == 1)
                {
                   
                    Console.WriteLine("Numeros Impares: "+v[i]);
                }




            }
        }
    }
}
