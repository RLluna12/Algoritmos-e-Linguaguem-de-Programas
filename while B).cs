using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, num=0 ;
            while (i<=100)
            {
             num = num + i; 
             i++;
  
             Console.WriteLine(num);
            }
          
            
            Console.WriteLine("Resultado: "+num);           
            

         
            


        }
    }
}
