using System;

namespace CourseExampleSpecialTopics3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Funções interessantes para string
                
                Formatar: ToLower(), ToUpper(), Trim()
                Buscar: IndexOf, LastIndexOf
                Recortar: Substring(inicio), Substring(inicio, tamanho)
                Substituir: Replace(char, char), Replace(string, string)
                String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)
                str.Split(' ')
                Conversão para numero: int x = int.Parse(str), int x =Convert.ToInt32(str)
                Conversão de número: str = x.ToString(), str = x.ToString("C"), str = x.ToString("C3"), str = x.ToString("F2")
             */

            string original = "abcde FGHI ABC abc DEFG";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            Console.WriteLine($"Texto original: {original}");
            Console.WriteLine($"Texto ToUpper: {s1}");
            Console.WriteLine($"Texto ToLower: {s2}");
            Console.WriteLine($"Texto Trim: {s3}");

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            Console.WriteLine($"Texto IndexOf: {n1}");
            Console.WriteLine($"Texto LastIndexOf: {n2}");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            Console.WriteLine("Substring(3): " + s4);
            Console.WriteLine("Substring(3, 5): " + s5);
            Console.WriteLine("Replace('a', 'x'): " + s6);
            Console.WriteLine("Replace('abc', 'xy'): " + s7);

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
