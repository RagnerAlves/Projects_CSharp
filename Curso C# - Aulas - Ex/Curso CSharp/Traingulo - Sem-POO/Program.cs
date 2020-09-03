using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite as medidas do triagulo X: ");
            x.A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas do triagulo Y: ");
            y.A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C / 2);
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            
            p = (y.A + y.B + y.C / 2);
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("O valor da area de X é: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor da area de Y é: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            
            if ( areaX > areaY)
            {
                Console.WriteLine("A maior area é  X");
            } 
            else
            {
                Console.WriteLine("A maior area é Y");
            }
        }            
    }
}
