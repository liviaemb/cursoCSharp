using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace calculoSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double codigo1, peca1, valor1, codigo2, peca2, valor2, total;
            string[] vet; 

            vet = Console.ReadLine().Split(' ');
            codigo1 = double.Parse(vet [0]);
            peca1 = double.Parse(vet[1]);
            valor1 = double.Parse(vet[2]);

            vet = Console.ReadLine().Split(' ');    
            codigo2 = double.Parse(vet [0]);
            peca2 = double.Parse(vet[1]);
            valor2 = double.Parse(vet[2]);

            total = (peca1 * valor1) + (peca2 * valor2);

            Console.WriteLine("O valor a pagar pelas peças é: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();




        }
    }
}
