using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace notaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double av1, av2, media;

            Console.WriteLine("Digite a sua nota do primeiro semestre: ");
            av1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a sua nota do segundo semestre: ");
            av2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = av1 + av2;

            Console.WriteLine("Nota final: " + media);


            if (media < 60.0)
            {
                Console.WriteLine("REPROVADO!");
            }
            else
            {
                Console.WriteLine("APROVADO!");
            }

            Console.ReadLine();


        }
    }
}
