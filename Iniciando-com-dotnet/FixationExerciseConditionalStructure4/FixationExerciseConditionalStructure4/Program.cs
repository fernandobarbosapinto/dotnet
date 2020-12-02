using System;
using System.Globalization;

namespace FixationExerciseConditionalStructure4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dgite o código e a quantidade do produto que deseja. Digite os valores separados por espaço");
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if (codigo == 1)
            {
                Console.WriteLine($"Você acaba de comprar {quantidade} cachorro quente");
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                Console.WriteLine($"Você acaba de comprar {quantidade} x-salada");
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                Console.WriteLine($"Você acaba de comprar {quantidade} x-bacon");
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                Console.WriteLine($"Você acaba de comprar {quantidade} torrada simples");
                total = quantidade * 2.0;
            }
            else
            {
                Console.WriteLine($"Você acaba de comprar {quantidade} refrigerante");
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
