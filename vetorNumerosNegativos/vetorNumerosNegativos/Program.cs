using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorNumerosNegativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];
            
            string [] numeros = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(numeros[i]);
            }
            for (int i = 0;i < N; i++)
            {
                if (vet [i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
            Console.ReadLine();

        }
    }
}
