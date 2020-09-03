using System;

namespace Excercicio
{
    class Rentagulo
    {
        public double Largura;
        public double Altura;
        public double Diagonal;

        public double Area()    {

            return Largura * Altura;
        }
        public double Perimetro()   {

            return 2 * (Largura + Altura);
        }
        public double Diagonal2()    {

            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

    }
}
