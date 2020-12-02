using System;

namespace FixationExerciseFor1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
                X, se for o caso.
             */

            Console.WriteLine("Digite um valor inteiro.");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine($"Abaixo estão todos os valores ímpares dentro do intervalo de {N}.");

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
