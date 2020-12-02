using System;

namespace FixationExerciseFor5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
                Lembrando que, por definição, fatorial de 0 é 1.
             */

            Console.WriteLine("Digite um valor inteiro");
            int N = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Valor fatorial agora vale => {fatorial}");
                Console.WriteLine($"Valor do for está em => {i}");
                
                fatorial = fatorial * i;
                Console.WriteLine($"O valor fatorial calculado {fatorial}");
                Console.WriteLine();
            }

            Console.WriteLine($"O valor fatorial final é => {fatorial}");
        }
    }
}
