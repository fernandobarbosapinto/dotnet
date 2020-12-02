using System;

namespace FixationExerciseFor7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
                começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
                exemplo
             */

            Console.WriteLine("Digite um valor inteiro");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;

                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
    }
}
