//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Course
//{
//    internal class ContaBancaria
//    {
//        public string? TitularConta;
//        public int Conta { get; private set; }
//        public double Saldo { get; private set; }

//        public ContaBancaria(string? titularConta, int conta)
//        {
//            TitularConta = titularConta;
//            Conta = conta;
//        }
//        public ContaBancaria(string? titularConta, int conta, double depositoInicial) :  this(titularConta, conta)
//        {
//            Deposito(depositoInicial);
//        }
//        public void Deposito(double quantia)
//        {
//            Saldo += quantia;
//        }

//        public void SaqueSaldo(double quantia)
//        {
//            Saldo -= quantia + 5.00;
//        }

//        public override string ToString()
//        {
//            return "Conta "
//                   + Conta
//                   + ", Titular: "
//                   + TitularConta
//                   + ", "
//                   + ", Saldo: $ "
//                   + Saldo.ToString("F2", CultureInfo.InvariantCulture);
//        }
//    }
//}
