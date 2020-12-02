using System;

namespace CourseStructureFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiros você vai digitar?");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Valor {i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine($"A soma dos valores é {soma}.");
        }
    }
}
