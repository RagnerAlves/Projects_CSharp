using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab) // imprimindo linhas e colunas do tabuleiro com as peças.
        {
            for (int i = 0; i < tab.linhas; i++) // criando as linhas do tabuleiro.
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)  // criando as colunas do tabuleiro.
                {
                    if(tab.peca(i,j)==null) // se os valores for nulo imprimi um - para montar o tabuleiro se nao imprimi um peca.
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();  // quebrando as linhas para formar as linhas e colnas do tabuleiro.

            }

            Console.WriteLine(" a b c d e f g h ");
        }

        public static Posicao_Xadrez lerPosicaoXadrez () // lendo posicao que o usuario informar em uma string.
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + " ");
            return new Posicao_Xadrez(coluna, linha);
        }


            public static void imprimirPeca(Peca peca) // definindo cor das pecas o tabuleiro.
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }

            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

    }
}
