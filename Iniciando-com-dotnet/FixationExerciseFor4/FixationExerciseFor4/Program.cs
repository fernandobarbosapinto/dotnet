using System;
using System.Globalization;

namespace FixationExerciseFor4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
                segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
             */

            Console.WriteLine("Digite a quantidade de vezes que deseja repetir essa operação");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite dois valores separados por espaço.");
                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine($"O valor da divisão é: {div.ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
