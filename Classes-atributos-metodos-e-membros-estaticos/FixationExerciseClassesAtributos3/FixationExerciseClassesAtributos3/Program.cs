using System;
using System.Globalization;

namespace FixationExerciseClassesAtributos3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite as 4 notas finais do Aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nota Final= {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");

            if (aluno.Aprovado())
            {
                Console.WriteLine("Parabêns você foi Aprovado!");
            }
            else
            {
                Console.WriteLine($"Infelizmente você foi reprovado. Faltaram {aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} pontos");
            }

        }
    }
}
