using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Cotacao
    {
        public static double Imposto = 6.0;

        public static double Conversao(double cotacao, double quantia)
        {
            double total = quantia * cotacao;
            return total + ((total * Imposto) / 100);
        }
    }
}
