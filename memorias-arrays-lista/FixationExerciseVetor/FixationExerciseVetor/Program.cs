using System;

namespace FixationExerciseVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                A dona de um pensionato possui dez quartos para alugar para estudantes,
                sendo esses quartos identificados pelos números 0 a 9.
                Quando um estudante deseja alugar um quarto, deve-se registrar o nome
                e email deste estudante.
                Fazer um programa que inicie com todos os dez quartos vazios, e depois
                leia uma quantidade N representando o número de estudantes que vão
                alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
                N estudantes. Para cada registro de aluguel, informar o nome e email do
                estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
                que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
                um relatório de todas ocupações do pensionato, por ordem de quarto,
                conforme exemplo.
             */

            Estudante[] vetor = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugado?");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Cadastrando o {i} aluno");
                Console.WriteLine("Digite o nome do aluno");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o e-mail do aluno");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o número do quarto deseja");
                int quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 1; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine($"{i} : {vetor[i]}");
                }
            }
        }
    }
}
