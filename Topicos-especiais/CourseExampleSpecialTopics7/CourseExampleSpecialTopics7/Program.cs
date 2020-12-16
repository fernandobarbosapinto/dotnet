using System;

namespace CourseExampleSpecialTopics7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Formatação (DateTime -> string) */

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine($"Utlizando ToLongDateString: {s1}");
            Console.WriteLine($"Utlizando ToLongTimeString: {s2}");
            Console.WriteLine($"Utlizando ToShortDateString: {s3}");
            Console.WriteLine($"Utlizando ToShortTimeString: {s4}");
            Console.WriteLine($"Utlizando ToString: {s5}");
            Console.WriteLine($"Utlizando ToString(yyyy - MM - dd HH: mm:ss): {s6}");
            Console.WriteLine($"Utlizando ToString(yyyy - MM - dd HH: mm:ss.fff): {s7}");
        }
    }
}
