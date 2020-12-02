using System;

namespace FixationExerciseConditionalStructure3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora que o jogo começou e a hora que o jogo termino. Para separar de um espaço entre as horas");
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}
