using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PosicaoXadrez pos = new PosicaoXadrez('c', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
            */
            
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();

                    Console.Write("Digite a posição da peça que deseja movimentar(ORIGEM)");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.Write("Digite a posição para aonde deseja movimentar(DESTINO)");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
            
        }
    }
}
