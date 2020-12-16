using System;

namespace CourseExampleSpecialTopics5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                TimeSpan
                • Representa uma DURAÇÃO
                • É um tipo valor (struct)
                
                Agenda:
                    • Representação interna
                    • Instanciação: construtores, fields, métodos From, Parse
                
                Representação interna
                    • Um objeto TimeSpan internamente armazena uma duração na forma de ticks (100 nanosegundos)
             */

            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine($"TimeSpan: {t1}");
            Console.WriteLine($"TimeSpan usando Ticks: {t1.Ticks}");
            Console.WriteLine("==============================================================");
            Console.WriteLine();

            /*
                Construtores

                • TimeSpan()
                • TimeSpan(ticks)
                • TimeSpan(horas, minutos, segundos)
                • TimeSpan(dias, horas, minutos, segundos)
                • TimeSpan(dias, horas, minutos, segundos, milissegundos)
             */

            /* Demo - construtores */
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine("Demo - construtores");
            Console.WriteLine($"new TimeSpan(): {t2}");
            Console.WriteLine($"new TimeSpan(900000000L): {t3}");
            Console.WriteLine($"new TimeSpan(2, 11, 21): {t4}");
            Console.WriteLine($"new TimeSpan(1, 2, 11, 21): {t5}");
            Console.WriteLine($"new TimeSpan(1, 2, 11, 21, 321): {t6}");
            Console.WriteLine("==============================================================");
            Console.WriteLine();

            /*Demo - métodos From*/
            TimeSpan t7 = TimeSpan.FromDays(1.5);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine("Demo - Métodos From");
            Console.WriteLine($"TimeSpan.FromDays(1.5): {t7}");
            Console.WriteLine($"TimeSpan.FromHours(1.5): {t8}");
            Console.WriteLine($"TimeSpan.FromMinutes(1.5): {t9}");
            Console.WriteLine($"TimeSpan.FromSeconds(1.5): {t10}");
            Console.WriteLine($"TimeSpan.FromMilliseconds(1.5): {t11}");
            Console.WriteLine($"TimeSpan.FromTicks(900000000L): {t12}");
            Console.WriteLine("==============================================================");
            Console.WriteLine();
        }
    }
}
