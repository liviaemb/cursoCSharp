using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inteiroFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, repeticoes, soma; 
            
            numero = int.Parse(Console.ReadLine());
            soma = 0; 
            for (int i=1; i<=numero; i++)
            {
                repeticoes = int.Parse(Console.ReadLine());
                soma = soma + numero;
            }

            Console.WriteLine(soma);
            Console.ReadLine();


        }
    }
}
