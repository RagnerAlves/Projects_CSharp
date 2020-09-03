using System;
using tabuleiro;

namespace xadrez // clase que vai armazenar a mecanica do jogo.
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; } // partida de xadrez tem um tabuleiro.
        private int turno; // a cada jogada um turno é incrementado.
        private Cor jogadorAtual; // indicando de quem é a vez de jogar.
        public bool terminada { get; private set; }
        
        public PartidaDeXadrez() // construtor para definir o inicio da partida de xadrez.
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false; 
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino) // metodo para executar os movimentos e uma partida de xadrez.
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQnteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas() // isntanciando as pecas no tabuleiro.
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao_Xadrez ('c', 1).toPosicao());  // metodo para colocar as peças no tabuleiro.
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao_Xadrez('c', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao_Xadrez('d', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao_Xadrez('e', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao_Xadrez('e', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao_Xadrez('d', 1).toPosicao());
            
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao_Xadrez('c', 7).toPosicao());  // metodo para colocar as peças no tabuleiro.
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao_Xadrez('c', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao_Xadrez('d', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao_Xadrez('e', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao_Xadrez('e', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao_Xadrez('d', 8).toPosicao());
        }

    }
}
