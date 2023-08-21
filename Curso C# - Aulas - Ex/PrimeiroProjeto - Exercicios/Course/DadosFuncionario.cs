//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Course
//{
//    internal class DadosFuncionario
//    {
//        public string? Nome;
//        public double SalarioBruto;
//        public double Imposto;

//        public void SalarioLiquido()
//        {
//            SalarioBruto = SalarioBruto - Imposto;
//        }
//        public double AumentarSalario(double porcentagem)
//        {
//            return SalarioBruto + ((SalarioBruto * Imposto) / 100);
//        }
//        public override string ToString()
//        {
//            return Nome 
//                   + ", $"
//                   + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture);

//        }
//    }
//}
