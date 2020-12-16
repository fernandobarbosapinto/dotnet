using System;

namespace CourseExampleSpecialTopics8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Operações com Datetime */

            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58);


            DateTime y = x.AddHours(2);
            DateTime z = x.AddMinutes(3);

            Console.WriteLine($"Data e Hora original:{x}");
            Console.WriteLine($"Adicionando 2 horas:{y}");
            Console.WriteLine($"Adicionando 3 minutos:{z}");
            Console.WriteLine("===========================================================================");
            Console.WriteLine();

            /*Exemplo de geraçção de data para boleto com data de emissão e data de vencimento*/

            DateTime emissaoBoleto = DateTime.Now;
            DateTime dataVencimento = emissaoBoleto.AddDays(7);

            Console.WriteLine($"Data da emissão do boleto: {emissaoBoleto}");
            Console.WriteLine($"Data de vencimento do boleto: {dataVencimento}");
            Console.WriteLine("===========================================================================");
            Console.WriteLine();

            /*Exemplo utilizando substract para saber quantos dias o boleto está vencido*/

            DateTime dataVencimento1 = new DateTime(2000, 10, 15);
            DateTime dataPgto = new DateTime(2000, 10, 18);

            TimeSpan diasEmAtraso = dataPgto.Subtract(dataVencimento1);

            Console.WriteLine($"Dias em atraso: {diasEmAtraso.Days}");
        }
    }
}
