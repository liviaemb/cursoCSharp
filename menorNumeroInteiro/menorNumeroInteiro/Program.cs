using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menorNumeroInteiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            string [] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);  

            if (x < y && x < z)
            {
                Console.WriteLine("Menor = " + x);
            }
            else
            {
                if ( y < z)
                {
                    Console.WriteLine("Menor = " + y);
                }
                else
                {
                    Console.WriteLine("Menor = " + z); 
                }
            } 

            Console.ReadLine();

        }
    }
}
