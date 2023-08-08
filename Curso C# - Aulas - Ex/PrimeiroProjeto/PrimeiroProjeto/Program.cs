using System.Globalization;
using System.Xml.Schema;

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

//Console.WriteLine("Digite a hora atual: ");
//int hora = int.Parse(Console.ReadLine());

//if(hora < 12)
//{
//    Console.WriteLine("Bom dia !");
//}
//else if (hora > 12 && hora < 18)
//{
//    Console.WriteLine("Boa tarde !");
//} 
//else
//{
//    Console.WriteLine("Boa noite.");
//}

//Console.WriteLine(hora);


//Console.WriteLine("Digite um número para sabermos se ele é um número negativo ou positivo: ");
//int num1 = int.Parse(Console.ReadLine());

//if(num1 < 0)
//{
//    Console.WriteLine("Número digitado é negativo.");
//}
//else if (num1 == 0)
//{
//    Console.WriteLine("Valor digitado é nulo.");
//}
//else
//{
//    Console.WriteLine("Número digitado é positivo");
//}


//Console.WriteLine("Digite um número inteiro para sabermos se é par ou impar: ");
//int num1 = int.Parse(Console.ReadLine());

//if(num1 % 2 == 0)
//{
//    Console.WriteLine("O número digitado é par.");
//}
//else
//{
//    Console.WriteLine("O número digitado é impar.");
//}

//Console.WriteLine("digite dois números para sabermos se são multiplos entre si: ");

//string[] valores = Console.ReadLine().Split(' ');
//int num1 = int.Parse(valores[0]);
//int num2 = int.Parse(valores[1]);


//if (num1 % num2 == 0 || num2 % num1 == 0)
//{
//    Console.WriteLine("os números digitados: " + num1 + " e " + num2 + " são multiplos entre si.");
//}
//else
//{
//    Console.WriteLine("os números digitados: " + num1 + " e " + num2 + " não são multiplos eentre si.");
//}

//Console.WriteLine("Digite a hora de inicio e a hora de termino do jogo: ");
//string[] hora = Console.ReadLine().Split(' ');
//int entrada = int.Parse(hora[0]);
//int saida = int.Parse(hora[1]);

//int duracao = 0;

//if (entrada < saida)
//{
//    duracao = saida - entrada;
//}
//else
//{
//    duracao = 24 - entrada + saida;
//}

//Console.WriteLine("O jogo teve uyma duração de: " + duracao + " horas.");

//Console.WriteLine("Digite o codigo do item e a quantidade: ");
//string[] valores = Console.ReadLine().Split(' ');
//double codigo = double.Parse(valores[0]);
//double quantidade = double.Parse(valores[1]);

//double total = 0;
//if (codigo == 1)
//{
//    total = quantidade * 4;
//}
//else if (codigo == 2)
//{
//    total = quantidade = 4.50;
//}
//else if (codigo == 3)
//{ 
//     total = quantidade * 5;
//}
//else if (codigo == 4)
//{
//    total = quantidade * 2;
//}
//else if( codigo == 5)
//{
//    total = quantidade * 1.50;
//}
//else
//{
//    Console.WriteLine("Nenhum codigo digitado é válido, favor verificar.");
//}

//Console.WriteLine("Tota: " + total.ToString("F2", CultureInfo.InvariantCulture));

//Console.WriteLine("Digite um valor para verificar o intervalo em que ele se encontra: ");
//double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//if (num1 < 25 && num1 > 100)
//{
//    Console.WriteLine("Fora do intervalo");
//}
//else if (num1 <= 25.0)
//{
//    Console.WriteLine("Valor digitado esta no intervalo entre (0,25]");
//}
//else if(num1 <= 50.0)
//{
//    Console.WriteLine("Valor digitado esta no intervalo entre (25,50]");
//}
//else if (num1 <= 75)
//{
//    Console.WriteLine("Valor digitado esta no intervalo entre (50,75]");
//}
//else
//{
//    Console.WriteLine("O intervalo digitado é (75,100]");
//}

Console.WriteLine("Digite o valor do salário de um trabalhador para saber o % de imposto a ser pago: ");
double salario = double.Parse(Console.ReadLine());

double imposto = 0.0;

if (salario <= 2000.00)
{
    Console.WriteLine("Trabalhador é isento de pagar imposto");
}
else if (salario < 2000.01)
{
    imposto = salario * (8 / 100);
    Console.WriteLine("O percentual de imposto a ser pago é: 8%, valor do salario com desconto é: " + imposto);
}
else if (salario <= 3000.01)
{
    imposto = salario * (18 / 100);
    Console.WriteLine("O percentual de imposto a ser pago é: 18%, valor do salario com desconto é: " + imposto);
}
else if (salario >= 4500.00)
{
    imposto = salario * (28 / 100);
    Console.WriteLine("O percentual de imposto a ser pago é: 28%, valor do salario com desconto é: " + imposto);
}

Console.ReadKey();

