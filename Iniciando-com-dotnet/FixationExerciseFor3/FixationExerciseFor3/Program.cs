using System;
using System.Globalization;
namespace FixationExerciseFor3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
                de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
                conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
                peso 5.
             */

            Console.WriteLine("Digite a quantidade de casos a ser testados.");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite agora 3 valores reais separados por espaço.");
                string[] line = Console.ReadLine().Split(' ');

                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine($"A média dos valores [{a}, {b} e {c}] é = {media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
