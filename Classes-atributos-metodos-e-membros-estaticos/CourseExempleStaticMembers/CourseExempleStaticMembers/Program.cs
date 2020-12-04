using System;
using System.Globalization;

namespace CourseExempleStaticMembers
{
    class Program
    {
        /*
                Fazer um programa para ler um valor numérico qualquer, e daí mostrar
                quanto seria o valor de uma circunferência e do volume de uma esfera
                para um raio daquele valor. Informar também o valor de PI com duas
                casas decimais.
        */

        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = calculadora.Circunferencia(raio);
            double volume = calculadora.Volume(raio);

            Console.WriteLine($"Valor da Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor do Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
