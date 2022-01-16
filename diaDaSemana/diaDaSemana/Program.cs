using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diaDaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string dia;

            if (x == 1)
            {
                dia = "Domingo!";
            }
            else if (x == 2)
            {
                dia = "Segunda!";
            }
            else if (x == 3)
            {
                dia = "Quarta!";
            }
            else if (x == 4)
            {
                dia = "Quinta!";
            }
            else if (x == 5)
            {
                dia = "Sexta!";
            }
            else if (x == 6)
            {
                dia = "Sábado!";
            }
            else
            {
                dia = "Valor inválido!";
            }

            Console.WriteLine("O dia é: " + dia);

            Console.ReadLine();

        }
    }
}
