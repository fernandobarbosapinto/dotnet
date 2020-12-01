using System;

namespace FixationExerciseConditionalStructure1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
             */

            Console.WriteLine("Digite um valor inteiro.");
            int value = int.Parse(Console.ReadLine());

            if (value < 0)
            {
                Console.WriteLine("O valor digitado é negativo");
            }
            else
            {
                Console.WriteLine("O valor digitado é positivo");
            }
        }
    }
}
