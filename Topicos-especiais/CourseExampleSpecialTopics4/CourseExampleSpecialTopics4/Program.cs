using System;
using System.Globalization;

namespace CourseExampleSpecialTopics4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                DateTime
                
                • Representa um INSTANTE
                • É um tipo valor (struct)

                • Agenda:
                    • Representação interna
                    • Instanciação: construtores, builders / conversão String -> DateTime
                    • Formatação: DateTime -> String
             */

            /*
                • Um objeto DateTime internamente armazena:
                    • O número de "ticks" (100 nanosegundos) desde a meia noite do dia 1 de
                    janeiro do ano 1 da era comum
             */

            DateTime d1 = DateTime.Now;

            Console.WriteLine($"Exibindo Datetime.Now: {d1}");
            Console.WriteLine($"Exibindo o número de Ticks: {d1.Ticks}");
            Console.WriteLine("==========================================================================");
            Console.WriteLine();

            /* Instanciação - Demo - construtores */

            DateTime d2 = new DateTime(2000, 8, 15);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d4 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine("Instanciação - Demo - construtores");
            Console.WriteLine();
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine("==========================================================================");

            /* Instanciação - Demo - Now, UtcNow, Today */
            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.UtcNow;
            DateTime d7 = DateTime.Today;
            Console.WriteLine("Instanciação - Demo - Now, UtcNow, Today ");
            Console.WriteLine();
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine("==========================================================================");

            /* Instanciação - Demo - Parse */
            Console.WriteLine("Instanciação - Demo - Parse ");
            Console.WriteLine();
            DateTime d8 = DateTime.Parse("2000-08-15");
            DateTime d9 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d10 = DateTime.Parse("15/08/2000");
            DateTime d11 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine("==========================================================================");

            /* Instanciação - Demo - ParseExact */
            Console.WriteLine("Instanciação - Demo - ParseExact ");
            Console.WriteLine();
            DateTime d12 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d13 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d12);
            Console.WriteLine(d13);
            Console.WriteLine("==========================================================================");
        }
    }
}
