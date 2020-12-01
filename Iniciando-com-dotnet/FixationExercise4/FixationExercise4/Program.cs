using System;
using System.Globalization;

namespace FixationExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
                hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
                decimais.
             */

            int numero, horas;
            double valorHora, salario;

            Console.WriteLine("Digite o número da matrícula do funcionário");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas trabalhadas");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da hora desse funcionário");
            valorHora = double.Parse(Console.ReadLine());

            salario = valorHora * horas;

            Console.WriteLine("Número da matrícula: " + numero);
            Console.WriteLine("Valor do Salário = R$" + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
