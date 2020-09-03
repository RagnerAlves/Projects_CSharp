using System.Globalization;

namespace PordutoEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTorTotalEmEstoque()  {

            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade ) {

            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)   {

            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ", $ ,"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + "unidades, Total: $"
                + ValorTorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
