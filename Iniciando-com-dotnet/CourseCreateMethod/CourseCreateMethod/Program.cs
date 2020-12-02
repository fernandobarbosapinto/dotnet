using System;

namespace CourseCreateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números, digite o primeiro e de um enter e siga assim até o 3 valor:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine($"Maior vaor = {resultado}");
        }

        static int Maior(int a, int b, int c)
        {
            int maiorValor;
            if (a > b && a > c)
            {
                maiorValor = a;
            }
            else if (b > c)
            {
                maiorValor = b;
            }
            else
            {
                maiorValor = c;
            }
            return maiorValor;
        }
    }
}
