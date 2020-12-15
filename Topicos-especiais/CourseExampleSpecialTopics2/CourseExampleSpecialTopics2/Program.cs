using System;

namespace CourseExampleSpecialTopics2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Utilizando expressão ternária*/
            
            double preco = 34.5;
            double desconto;

            /*utilizando if else de forma comum*/
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
                Console.WriteLine(desconto);
            }
            else
            {
                desconto = preco * 0.05;
                Console.WriteLine(desconto);
            }

            /*utilizando expressão ternária*/
            double preco2 = 34.5;
            double desconto2 = (preco2 < 20.0) ? preco2 * 0.1 : preco2 * 0.05;
            Console.WriteLine(desconto2);
        }
    }
}
