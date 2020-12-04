using System;
using System.Globalization;

namespace FixationExerciseClassesAtributos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Digite a largura e a altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine($"Valor total da Àrea do retângulo: {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor total do Perimetro: {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor total da Diagonal: {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
