using tabuleiro;

namespace xadrez // classe apenas para axuliar no context do tabuleiro de xadrez.
{
    class Posicao_Xadrez // associando posiçõe do xadrez com as letras  enumero do tabuleiro.
    {
        public char coluna { get; set; }

        public int linha { get; set; }

        public Posicao_Xadrez(char coluna, int linha) // construtor para a tribuir os metodos linhas e coluna.
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString() // imprimindo letras e numeros do tabuleiro.
        {
            return "" + coluna + linha;
        }

    }
}
