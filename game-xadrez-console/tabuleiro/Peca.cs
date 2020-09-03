namespace tabuleiro
{
   abstract class Peca
    {
        public Posicao posicao { get; set; } // associando a classe peca com a classe tabuleiro.
        public Cor cor { get; protected set; } // atributo acessivel pela classe e pela subclasse PROTECTED.
        public int quantidadeMovimento { get; protected set; } // atributo acessivel pela classe e pela subclasse PROTECTED.
        public Tabuleiro tab { get; protected set; } // atributo acessivel pela classe e pela subclasse PROTECTED.

        public Peca(Tabuleiro tab, Cor cor ) // instanciando peca de acordo com posciao e cor no tabuleiro.
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            quantidadeMovimento = 0;
        }

        public void incrementarQnteMovimentos()
        {
            quantidadeMovimento++;
        }

        public void decrementarQteMovimentos()
        {
            quantidadeMovimento--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis(); // matriz boleando que marca o movimento posiveis de cada peça.
    }
}
