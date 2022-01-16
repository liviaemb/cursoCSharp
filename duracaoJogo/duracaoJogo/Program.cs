using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duracaoJogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;

            Console.WriteLine("Digite a hora que o jogo começou e a hora que terminou: ");
            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaFinal;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O jogo durou: " + duracao + " hora(s)!");
            Console.ReadLine();


        }
    }
}
