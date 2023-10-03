
//using System.Globalization;

//namespace Course
//{
//    internal class Produto
//    {
//        public string? Nome;
//        public double Preco;
//        public double Quantidade;

//        public double ValorTotalEmEstoque()
//        {
//            return Preco * Quantidade;
//        }

//        public void AdicionarProdutos(int quantidade)
//        {
//            Quantidade += quantidade;
//        }

//        public void RemoverProdutos(int quantidade)
//        {
//            Quantidade -= quantidade;
//        }

//        public override string ToString()
//        {
//            return Nome
//                + ", $"
//                + Preco.ToString("F2", CultureInfo.InvariantCulture)
//                + ", "
//                + Quantidade
//                + " "
//                + "unidade, Total: $ "
//                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
//        }
//    }
//}
