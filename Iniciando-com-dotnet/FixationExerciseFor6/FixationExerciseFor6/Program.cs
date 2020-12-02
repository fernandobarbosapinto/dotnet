using System;

namespace FixationExerciseFor6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Ler um número inteiro N e calcular todos os seus divisores.
             */

            Console.WriteLine("Digite um valor inteiro.");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine($"Os valores divisiveis por {N} são ===> {i}");
                }
            }
        }
    }
}
