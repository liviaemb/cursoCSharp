using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizDiagonalNegativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] A;

            N = int.Parse(Console.ReadLine());
            A = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string [] s = Console.ReadLine().Split(' ');    
                for (int j=0; j<N; j++)
                {
                    A [i,j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0;i < N; i++)
            {
                Console.WriteLine(A [i,i] + " ");
            }
            Console.WriteLine();

            int cont = 0;
            for (int i = 0;i<N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A [i,j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("Números negativos: " + cont);
            Console.ReadLine(); 
        }
    }
}
