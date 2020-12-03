using System;
using System.Globalization;

namespace FixationExerciseClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            
            Console.WriteLine("Insira os dados do primeiro funcionário:");
            Console.WriteLine("-----------------------------------------------------");

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Insira os dados do segundo funcionário:");
            Console.WriteLine("-----------------------------------------------------");

            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine();

            Console.WriteLine($"O salário médio dos trabalhadores é: {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }

    }
}
