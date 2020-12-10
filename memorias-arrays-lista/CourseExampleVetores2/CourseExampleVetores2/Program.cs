using System;
using System.Globalization;

namespace CourseExampleVetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 Fazer um programa para ler um número inteiro N e os dados (nome e
                 preço) de N Produtos. Armazene os N produtos em um vetor. Em
                 seguida, mostrar o preço médio dos produtos.
             */

            Console.WriteLine("Digite a quantidade de produtos que deseja cadastrar.");
            int N = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite o nome do produto");
                string name = Console.ReadLine();

                Console.WriteLine("Digite o preço do produto");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[i] = new Produto { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < N; i++)
            {
                sum += vetor[i].Price;
            }

            double avg = sum / N;

            Console.WriteLine($"A média dos valores dos produtos é de R${avg.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
