

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

Console.WriteLine("Digite um numero inteiro para sabermos se é par ou impar: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Número digitado é par");
} 
else
{
    Console.WriteLine("Número digitado é impar.");
}


Console.ReadKey();