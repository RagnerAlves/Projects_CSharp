using System.Globalization;

//string frase = Console.ReadLine();
//string x = Console.ReadLine();
//string y = Console.ReadLine();
//string z = Console.ReadLine();

//string[] vet = Console.ReadLine().Split(' ');
//string a = vet[0];
//string b = vet[1];
//string c = vet[2];

//Console.WriteLine("Você digitou: ");
//Console.WriteLine(frase);
//Console.WriteLine(x);
//Console.WriteLine(y);
//Console.WriteLine(z);
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);



//int num1 = int.Parse(Console.ReadLine());
//char caractere = char.Parse(Console.ReadLine());
//double num2 = double.Parse(Console.ReadLine());

//string[] vet = Console.ReadLine().Split(' ');
//string nome = vet[0];
//char sexo = char.Parse(vet[1]);
//int idade = int.Parse(vet[2]);
//double altura = double.Parse(vet[3]);

//Console.WriteLine("Você digitou: ");
//Console.WriteLine(num1);
//Console.WriteLine(caractere);
//Console.WriteLine(num2);
//Console.WriteLine(nome);
//Console.WriteLine(sexo);
//Console.WriteLine(idade);
//Console.WriteLine(altura);


//Console.WriteLine("Digite seu nome completo: ");
//string nome = Console.ReadLine();
//Console.WriteLine("Digite quatos quartos tem na sua casa: ");
//int quartos = int.Parse(Console.ReadLine());
//Console.WriteLine("Digite o preço de um produto: ");
//double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//Console.WriteLine("Digite Seu nome, idade e altura: ");

//string[] vet = Console.ReadLine().Split(' ');
//string sobrenome = vet[0];
//int idade = int.Parse(vet[1]);
//double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

//Console.WriteLine();
//Console.WriteLine(nome);
//Console.WriteLine(quartos);
//Console.WriteLine(preco);
//Console.WriteLine(sobrenome);
//Console.WriteLine(idade);
//Console.WriteLine(altura);

Console.WriteLine("Digite a hora atual: ");
int hora = int.Parse(Console.ReadLine());

if(hora < 12)
{
    Console.WriteLine("Bom dia !");
}
else if (hora > 12 && hora < 18)
{
    Console.WriteLine("Boa tarde !");
} 
else
{
    Console.WriteLine("Boa noite.");
}

//Console.WriteLine(hora);

Console.ReadKey();

