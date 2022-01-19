using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace vetorTabela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] altura = new double[N];

            //Leitura dos dados
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

            }
            //Cálculo idade media

            double soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                soma = soma + altura[i];
            }

            double media = soma / N;

            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            //Porcentagem das pessoas com -16 anos

            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagem = (double) cont / N * 100.0;

            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F2", CultureInfo.InvariantCulture) + "%");


            Console.ReadLine();



        }
    }
}
