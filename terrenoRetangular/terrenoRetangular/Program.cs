using System;
using System.Globalization;

namespace terrenoRetangular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;
            Console.WriteLine("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o preço do metro quadrado: ");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("A área do terreno é = " + area.ToString("F2", CultureInfo.InvariantCulture) + "m2");
            Console.WriteLine("O preço do terreno é:  = R$" + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}