

//string frase = Console.ReadLine();
//string x = Console.ReadLine();
//string y = Console.ReadLine();
//string z = Console.ReadLine();

//string[] v = Console.ReadLine().Split(' ');
//string a = v[0];
//string b = v[1];
//string c = v[2];

//Console.WriteLine("Voce digitou: " );
//Console.WriteLine(frase);
//Console.WriteLine(x);
//Console.WriteLine(y);
//Console.WriteLine(z);
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);

//using System.Globalization;

//int num1 = int.Parse(Console.ReadLine());
//char caractere = char.Parse(Console.ReadLine());
//double num_double = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//string[] v = Console.ReadLine().Split(' ');
//string nome = v[0];
//char letra =  char.Parse(v[1]);
//int idade = int.Parse(v[2]);
//double altura = double.Parse(v[3], CultureInfo.InvariantCulture);

//Console.WriteLine("Você digitou: ");
//Console.WriteLine(num1);
//Console.WriteLine(caractere);
//Console.WriteLine(num_double);
//Console.WriteLine(nome);
//Console.WriteLine(letra);
//Console.WriteLine(idade);
//Console.WriteLine(altura);


//using System.Globalization;

//Console.WriteLine("Digite o seu nome completo: ");
//string nome = Console.ReadLine();
//Console.WriteLine("Quantos qurtos tem na sua casa ? ");
//int quartos = int.Parse(Console.ReadLine());
//Console.WriteLine("Entre com o preço do produto: ");
//double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
//string[] v = Console.ReadLine().Split(' ');
//string nome1 = v[0];
//int idade = int.Parse(v[1]);
//double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

//Console.WriteLine("Você digitou: ");
//Console.WriteLine(nome);
//Console.WriteLine(quartos);
//Console.WriteLine(preco);
//Console.WriteLine(nome1);
//Console.WriteLine(idade);
//Console.WriteLine(altura);

//exercicio 01
//Console.WriteLine("Digite um numero inteiro para sabermos se é par ou impar: ");
//int num = int.Parse(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("Número digitado é par");
//} 
//else
//{
//    Console.WriteLine("Número digitado é impar.");
//}

//exercicio02
//Console.WriteLine("Digite dois valores inteiros para sabermos se são multiplos entre si: ");

//string[] vet = Console.ReadLine().Split(' ');
//int num1 = int.Parse(vet[0]);
//int num2 = int.Parse(vet[1]);

//if (num1 % num2 == 0 || num2 % num1 == 0)
//{ 
//    Console.WriteLine("Os número digitados são multiplos entre si");
//}
//else
//{
//    Console.WriteLine("Os números digitados não são multiplos entre si.");
//}

//exercicio03

using System.Globalization;
using System.Net;

//    Console.WriteLine("Favor digite o codigo do item e a quantidade abaixo para o valor total da compra: ");

//    string[] vet = Console.ReadLine().Split(' ');
//    int cod1 = int.Parse(vet[0]);
//    int quantidade = int.Parse(vet[1]);

//    double total = 0;
//    if (cod1 == 1)
//    {
//        total = quantidade * 4.0;
//    }
//    else if (cod1 == 2)
//    {
//        total = quantidade * 4.5;
//    }
//    else if (cod1 == 3)
//    {
//        total = quantidade * 5.0;
//    }
//    else if (cod1 == 4)
//    {
//        total = quantidade * 2.0;
//    }
//    else if (cod1 == 5)
//    {
//        total = quantidade * 1.50;
//    }

//    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

//Console.WriteLine("Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos\r\nseguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra: ");

//double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//if (numero < 0.0 || numero > 100.0)
//{
//    Console.WriteLine("Número digitado está fora do intervalo");
//}
//else if (numero >= 0.0 && numero <= 25.00)
//{
//    Console.WriteLine("Número digitado está entre o intervalo (0,25]");
//}
//else if (numero >= 25.0 && numero <= 50.0)
//{
//    Console.WriteLine("Número digitado está no intervalo (25, 50]");
//}
//else if (numero >= 50.00 && numero <= 75)
//{
//    Console.WriteLine("Número digitado está no intervalo (50, 75]");
//}
//else if (numero >= 75.00 && numero <= 100)
//{
//    Console.WriteLine("Número digitado está no intervalo (75, 100]");
//}

//Console.WriteLine("Digite um número inteiro: ");
//int y = int.Parse(Console.ReadLine());

//if (y < 5) Console.WriteLine("Bom dia.");

//Console.WriteLine("Digite um numero inteiro para sabermos se é par ou impar.");
//int x = int.Parse(Console.ReadLine());


//if (x % 2 == 0)
//{
//    Console.WriteLine("O número digitado é par");
//}
//else
//{
//    Console.WriteLine("Número digitado é impar.");
//}


//Console.WriteLine("Qual a hora atual? ");
//int h = int.Parse(Console.ReadLine());

//if (h < 12)
//{
//    Console.WriteLine("Bom dia !");
//}
//else if (h < 18)
//{
//    Console.WriteLine("Boa tarde");
//}
//else
//{
//    Console.WriteLine("Boa noite.");
//}


//Console.WriteLine("Digite o valor do salário para saber se é isento ou não de IR: ");
//double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//double imposto;
//if(salario <= 2000.00)
//{
//    Console.WriteLine("Trabalhador está isento de pagar o imposto.");
//}
//else if (salario <= 3000.00)
//{
//    imposto = salario * (8 / 100);
//    Console.WriteLine("O valor do imposto a ser pago é de " + imposto);
//}
//else if (salario <= 4500.00)
//{
//    imposto = salario * (18 / 100);
//    Console.WriteLine("O valor do imposto a ser pago é de " + imposto);
//}
//else if (salario >= 4500.00)
//{
//    imposto = salario * (28 / 100);
//    Console.WriteLine("O valor do imposto a ser pago é de " + imposto);
//}

//Console.WriteLine("Digite um numero inteiro: ");
//int num = int.Parse(Console.ReadLine());

//if (num > 0)
//{
//    Console.WriteLine("Número digitado é positivo");
//}
//else
//{
//    Console.WriteLine("Número digitado é negativo");
//}

//Console.WriteLine("Digite um número inteiro para saber se ele é par ou impar: ");
//int num = int.Parse(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("Número digitado é par.");
//}
//else
//{
//    Console.WriteLine("Número digitado é impar.");
//}

//Console.WriteLine("Digite dois valores para sabermos se são multiplos entre si: ");
//string[] vet = Console.ReadLine().Split(' ');
//int num1 = int.Parse(vet[0]);
//int num2 = int.Parse(vet[1]);

//if (num1 % num2 == 0 || num2 % num1 == 0)
//{
//    Console.WriteLine("Numeros digitados são multiplos entre si");
//}
//else
//{
//    Console.WriteLine("Numeros digitados não são multiplos entre si");
//}

Console.WriteLine("Digite três números inteiros para sabermos qual o maior entre eles: ");
Console.WriteLine("Digite o primeiro valor :");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("O primeiro valor é o maior.");
}
else if (num2 > num3)
{
    Console.WriteLine("O segundo valor é o maior.");
}
else if (num1 == num2 && num1 == num3)
{
    Console.WriteLine("Os valores digitados são iguais.");
}
else if (num1 == num2)
{
    Console.WriteLine("O primeiro e o segundo valor digitados são iguais.");
}
else if (num1 == num3)
{
    Console.WriteLine("O primeiro e o terceiro valor digitados são iguais.");
}
else if (num2 == num3)
{
    Console.WriteLine("O segundo e o terceiro valor digitados são iguais.");
}
else
{
    Console.WriteLine("O terceiro valor é o maior");
}


Console.ReadKey();