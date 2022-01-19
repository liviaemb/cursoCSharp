using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace idadeWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, pessoas, media;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = 0.0;
            pessoas = 0;

            while (idade >= 0)
            {
                soma = soma + idade;
                pessoas = pessoas + 1;
                idade = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

            }
            if (soma == 0)
            {
                Console.WriteLine("Impossível calcular!");
            }
            else
            {
                media = soma / pessoas;

                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }


            Console.ReadLine();
        }
    }
}
