using System;
using System.Globalization;

namespace Excercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Rentagulo r = new Rentagulo();
            
            Console.WriteLine("Digiteo valor da largura do retangulo: ");
            r.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digiteo valor da altura do retangulo: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.Write("Area é igual a: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Area é igual a: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Area é igual a: " + r.Diagonal2().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
