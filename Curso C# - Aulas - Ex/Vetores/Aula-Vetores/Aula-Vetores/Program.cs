using System;
using System.Globalization;

namespace Aula_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for(int i = 0; i < n; i++) {

                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }
    }
}
