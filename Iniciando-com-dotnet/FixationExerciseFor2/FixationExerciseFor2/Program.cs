using System;

namespace FixationExerciseFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
                Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
                essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
             */

            Console.WriteLine("Digite a quantidade de vezes que vai querer digitar um valor inteiro.");
            int N = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 1; i < N; i++)
            {
                Console.WriteLine($"Digite o {i} valor.");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine($"Valor de cont_in {cont_in}");
            Console.WriteLine($"Valor de cont_out {cont_out}");
        }
    }
}
