using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

namespace entradaExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite sobrenome, idade e altura na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);





        }
    }
}
