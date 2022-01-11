using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace maiorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorAB, maior;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;
            maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;



            Console.WriteLine("O maior número é: " + maior);
            Console.ReadLine();


        }
    }
}
