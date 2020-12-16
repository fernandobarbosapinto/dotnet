using System;

namespace CourseExampleSpecialTopics6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Propriedades e Operações com DateTime

                • Date (DateTime)
                • Day (int)
                • DayOfWeek (DayOfWeek)
                • DayOfYear (int)
                • Hour (int)
                • Kind (DateTimeKind)
                • Millisecond (int)
                • Minute (int)
                • Month (int)
                • Second (int)
                • Ticks (long)
                • TimeOfDay (TimeSpan)
                • Year (int)
             
             */

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine($"Variável d sem nenhuma formatação: {d}");
            Console.WriteLine("1) Variável d utilizando Date: " + d.Date);
            Console.WriteLine("2) Variável d utilizando Day: " + d.Day);
            Console.WriteLine("3) Variável d utilizando DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) Variável d utilizando DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Variável d utilizando Hour: " + d.Hour);
            Console.WriteLine("6) Variável d utilizando Kind: " + d.Kind);
            Console.WriteLine("7) Variável d utilizando Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Variável d utilizando Minute: " + d.Minute);
            Console.WriteLine("9) Variável d utilizando  Month: " + d.Month);
            Console.WriteLine("10) Variável d utilizando Second: " + d.Second);
            Console.WriteLine("11) Variável d utilizando Ticks: " + d.Ticks);
            Console.WriteLine("12) Variável d utilizando TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Variável d utilizando Year: " + d.Year);

        }
    }
}
