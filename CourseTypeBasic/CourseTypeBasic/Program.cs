using System;
using System.Globalization;

namespace CourseTypeBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";

            Console.Write("Bom dia!"); //Console.Write não quebra linha
            Console.WriteLine("Boa tarde!"); //Console.WriteLine faz quebra de linha
            Console.WriteLine("Boa noite!");
            Console.WriteLine("---------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); //Imprime duas casa decimais
            Console.WriteLine(saldo.ToString("F4")); //Imprime quatro casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //Utilizando Format Provider para exibir o ponto de separação na casa decimal
        }
    }
}
