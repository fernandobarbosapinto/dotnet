using System;

namespace FixationExerciseMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler um número inteiro N e uma matriz de
                ordem N contendo números inteiros. Em seguida, mostrar a diagonal
                principal e a quantidade de valores negativos da matriz.
             */

            Console.WriteLine("Digite o número de colunas/linhas que deseja para a matriz:");
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: " + count);

        }
    }
}
