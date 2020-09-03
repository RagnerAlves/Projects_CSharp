using System;


namespace Curso_CSharp
{
    class Condicional
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Numero par");
            } else
            {
                Console.WriteLine("Numero  impar");
            }


        }
    }
}
