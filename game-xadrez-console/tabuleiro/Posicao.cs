namespace tabuleiro
{
    class Posicao
    {
        public int linha { get; set; } // atributos podem ser acessados e alterados por outras classes.
        public int coluna { get; set; }

        public Posicao(int linha, int coluna) // construtor que atribui diretamente os valores para um novo objeto que for criado.
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int lina, int coluna)// metodo para definir as posições.
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString() // sobreposicao para imprimir o obejto instanciado no código principal.
        {
            return linha
                + ", "
                + coluna;
        }


    }
}
