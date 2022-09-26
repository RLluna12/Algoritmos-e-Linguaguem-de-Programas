using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite numero: ");
                v[i] = int.Parse(Console.ReadLine());

                if (v[0] < v[1] && v[0] < v[2] && v[0] < v[3] && v[0] < v[4] && v[0] < v[5])
                {
                    Console.WriteLine("o menor é :{0}, e a posiçao é :v[0]", v[0]);
                }
                else if (v[1] < v[0] && v[1] < v[2] && v[1] < v[3] && v[1] < v[4] && v[1] < v[5])
                {
                    Console.WriteLine("o menor é :{0}, e a posiçao é :v[1]", v[1]);
                }
                else if (v[2] < v[1] && v[2] < v[0] && v[2] < v[3] && v[2] < v[4] && v[2] < v[5])
                {
                    Console.WriteLine("o menor é :{0}, e a posiçao é :v[2]", v[2]);
                }
                else if (v[3] < v[1] && v[3] < v[0] && v[3] < v[2] && v[3] < v[4] && v[3] < v[5])
                {
                    Console.WriteLine("o menor é :{0}, e a posiçao é :v[3]", v[3]);
                }
                else if (v[4] < v[1] && v[4] < v[0] && v[4] < v[2] && v[4] < v[3] && v[4] < v[5])
                {
                    Console.WriteLine("o menor é :{0}, e a posiçao é :v[4]", v[4]);
                }
                else if (v[5] < v[1] && v[5] < v[0] && v[5] < v[2] && v[5] < v[3] && v[5] < v[4])
                {
                    Console.WriteLine("o menor é :{0}, e a posiçao é :v[5]", v[5]);
                }
            }
    }
}
