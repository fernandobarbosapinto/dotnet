using System;

namespace CourseConditionalStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEMO 1
            Console.WriteLine("Digite um número inteiro:");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("O valor digitado é Par.");
            }
            else
            {
                Console.WriteLine("O valor digitado é Impar.");
            }

            //DEMO 2
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
