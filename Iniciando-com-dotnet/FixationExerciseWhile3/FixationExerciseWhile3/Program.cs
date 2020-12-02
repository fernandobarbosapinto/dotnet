using System;

namespace FixationExerciseWhile3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
                um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
                4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
                que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
                mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
                exemplo.
             */

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Digite 1 para Álcool, 2 para Gasolina e 3 para Diesel ou 4 para finalizar.");
            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine($"Quantas vezes foi abastecido com Alcool: {alcool}");
            Console.WriteLine($"Quantas vezes foi abastecido com Gasolina: {gasolina}");
            Console.WriteLine($"Quantas vezes foi abastecido com Diesel: {diesel}");
        }
    }
}
