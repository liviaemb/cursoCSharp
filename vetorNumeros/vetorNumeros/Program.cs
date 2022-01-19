using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace vetorNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;

            Console.WriteLine("Digite a quantidade de números desejada, em seguida digite-os: "); 
            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet [i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0;i < N; i++)
            {
                Console.WriteLine(vet [i].ToString("F1", CultureInfo.InvariantCulture));

            }

            Console.ReadLine();
        }
    }
}
