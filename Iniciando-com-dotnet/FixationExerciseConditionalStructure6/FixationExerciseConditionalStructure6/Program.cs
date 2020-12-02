using System;
using System.Globalization;
namespace FixationExerciseConditionalStructure6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
                que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
                qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
                Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
                mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
                
                de 0 à 2000.00 = isento
                de 2001.00 ate 3000.00 = 8%
                de 3001.00 ate 4500.00 = 18%
                acima de 4500.00 = 28%

                Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
                salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
                de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
                duas casas decimais.
             */

            Console.WriteLine("Digite o valor do seu salário.");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
