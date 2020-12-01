using System;
using System.Globalization;

namespace FixationExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
                casas decimais conforme exemplos.
             */
            double R, A, pi = 3.14159;

            Console.WriteLine("Digite o valor do raio");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("Valor da Área: " + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
