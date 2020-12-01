using System;

namespace FixationExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, soma;
            Console.WriteLine("Digite o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo valor: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("O valor da soma é!");
            soma = A + B;

            Console.WriteLine("Soma = " + soma);
        }
    }
}
