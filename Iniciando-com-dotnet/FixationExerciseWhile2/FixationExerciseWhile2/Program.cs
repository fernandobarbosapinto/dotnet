using System;

namespace FixationExerciseWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
                cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
                menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
             */

            Console.WriteLine("Digite dois valores separados por espaço.");
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y !=0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else
                {
                    Console.WriteLine("Quarto Quadrante");
                }
                valores = Console.ReadLine().Split();
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
    }
}
