using System;

namespace FixationExerciseVetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler dois números inteiros M e N, e depois ler
                uma matriz de M linhas por N colunas contendo números inteiros,
                podendo haver repetições. Em seguida, ler um número inteiro X que
                pertence à matriz. Para cada ocorrência de X, mostrar os valores à
                esquerda, acima, à direita e abaixo de X, quando houver, conforme
                exemplo.
             */

            Console.WriteLine("Digite a quantidade de linhas e colunas que deseja para a matriz, separando por espaço:");
            string[] line = Console.ReadLine().Split(' ');
            int L = int.Parse(line[0]);
            int C = int.Parse(line[1]);

            int[,] matriz = new int[L, C];

            for (int i = 0; i < L; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < C - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < L - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
