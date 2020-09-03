using System;
using tabuleiro;
using xadrez;


namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
                      
             try // tratamento de erro com o bloco try, qlq erro será tratado como execeção, interrompido e caira no bloco cath.
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();

                    Console.Write("Origem ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao(); // lendo do teclado uma posicao de origem no tabuleiro.
                    Console.Write("Destino ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao(); // lendo do teclado uma posicao de destino no tabuleiro.

                    partida.executaMovimento(origem, destino);
                }
              
            }
            catch (TabuleiroException e) // se der alguma execção no tabuleiro a msg srá exibida.
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
