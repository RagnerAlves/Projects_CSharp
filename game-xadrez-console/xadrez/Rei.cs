using System;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos) // regra para movimentação da peça rei.
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor; // irá se mover se a proxima "casa" estiver vazia ou se  a cor for diferente da cor deste rei.
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
        }

        Posicao pos = new Posicao(0, 0);

        pos.definirValores(posicao.linha - 1, posicao.coluna);
        
    }
}
