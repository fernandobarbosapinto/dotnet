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

        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine($"Valor da Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor do Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");

        }

        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }
    }
}
