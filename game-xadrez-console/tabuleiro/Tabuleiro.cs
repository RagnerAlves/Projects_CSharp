namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; } // criando linhas do tabuleiro.
        public int colunas { get; set; } // criando colunas do tabuleiro.
        private Peca[,] pecas; // criando matriz de pecas e colunas.

        public Tabuleiro(int linhas, int colunas)  // criando construtor para instanciar matriz de pecas do tabuleiro.
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; // instanciando numero de linhas e colunas.
        }

        public Peca peca(int linha, int coluna) // peças nas colunas.
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos) // definindo posição.
        {
            return pecas[pos.linha, pos.coluna];
        }

       public bool existePeca(Posicao pos) //metodo para testar se existe uma peça em uma dada posição.
        {
            validaPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos) // colocando as pecas no tabuleiro, peca na posicao da linha e coluna.
        {   
           if(existePeca(pos)) //só posso colocar uma peca onde nao houver pecas, validando peças no tabuleiro.
            {
                throw new TabuleiroException("Ja existe uma peça nesta posição.");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos)// metodo para retirar peca o tabuleiro.
        {
            if (peca(pos) == null)
            {
                return null;
            }

            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }


       public bool posicaoValida(Posicao pos) // metodo para testar se a posicao é valida.
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }

            return true;
        }

        public void validaPosicao(Posicao pos)  // metodo para receber a posicao e caso na seja valida ele vai lançar uma execção personalizada.
        {
            if(!posicaoValida(pos)) // se a posição não é valida ele passa uma exceção.
            {
                throw new TabuleiroException("Posicação inválida !!! ");
            }
        }
    }
}
