using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 
namespace vetorSomaMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double [] vet;
            double soma, media;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] numeros = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(numeros[i], CultureInfo.InvariantCulture);   
            }

            for (int i = 0;i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            soma = 0.0;
            for (int i = 0; (i < N); i++)
            {
                soma = soma + vet[i];
            }

            media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();



        }
    }
}
