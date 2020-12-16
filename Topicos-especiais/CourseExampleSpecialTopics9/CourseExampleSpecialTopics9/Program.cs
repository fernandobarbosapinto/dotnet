using System;

namespace CourseExampleSpecialTopics9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Propriedades e Operações com TimeSpan */

            /* Demo: MaxValue, MinValue, Zero */
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine("Demo: MaxValue, MinValue, Zero");
            Console.WriteLine();
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine("===============================================================");
            Console.WriteLine();

            /* Demo - propriedades */
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine("Demo - propriedades");
            Console.WriteLine();
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
            Console.WriteLine("===============================================================");
            Console.WriteLine();

            /* Demo - operações */
            TimeSpan t4 = new TimeSpan(1, 30, 10);
            TimeSpan t5 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t4.Add(t5);
            TimeSpan dif = t4.Subtract(t5);
            TimeSpan mult = t5.Multiply(2.0);
            TimeSpan div = t5.Divide(2.0);
            Console.WriteLine("Demo - operações");
            Console.WriteLine();
            Console.WriteLine($"Exibindo o TimeSpan: {t4}");
            Console.WriteLine($"Utilizando o método Multiply: {t5}");
            Console.WriteLine($"Utilizando o método Add: {sum}");
            Console.WriteLine($"Utilizando o método Subtract: {dif}");
            Console.WriteLine($"Utilizando o método Multiply: {mult}");
            Console.WriteLine($"Utilizando o método Divide: {div}");
            Console.WriteLine("===============================================================");
            Console.WriteLine();
        }
    }
}
