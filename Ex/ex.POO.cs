using System;
using System.Globalization;

namespace Ex { 
    class Program { 
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do trianguilo X");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do trianguilo Y");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (pxA) * (p - xB), (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (yA) * (p - yB), (p - yC));

            Console.Write.Line("Area de x: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.Write.Line("Area de y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaxY)
            {
                Console.WriteLine("Maior Area é o triangulo X");
            } else
            {
                Console.WriteLine("Maior Area é o triangulo Y");
            }          
        }
    }


}