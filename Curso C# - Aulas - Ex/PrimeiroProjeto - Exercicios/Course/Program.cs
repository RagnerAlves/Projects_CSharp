using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            //Console.WriteLine("Digite o valor do salário de um trabalhador para saber o % de imposto a ser pago: ");
            //double salario = double.Parse(Console.ReadLine());

            //double imposto;

            //if (salario <= 2000.00)
            //{
            //    imposto = 0.0;
            //    Console.WriteLine("Trabalhador é isento de pagar imposto");
            //}
            //else if (salario < 3000.00)
            //{
            //    imposto = (salario - 2000.0) * 0.08;
            //    Console.WriteLine("O valor de imposto a ser pago é: 8%, valor do salario com desconto é: " + imposto);
            //}
            //else if (salario <= 4500.00)
            //{
            //    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            //    Console.WriteLine("O valor de imposto a ser pago é: 18%, valor do salario com desconto é: " + imposto);
            //}
            //else
            //{
            //    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            //    Console.WriteLine("O valor de imposto a ser pago é: 28%, valor do salario com desconto é: " + imposto);
            //}
            //if (imposto == 0.0)
            //{
            //    Console.WriteLine("Isento");
            //}
            //else
            //{
            //    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            //}

            //Console.WriteLine("Digitre três números para sabermos qual é o maior: ");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());

            //double resultado = Maior(num1, num2, num3);

            //Console.WriteLine("Maior valor digitado é: " + resultado);


            //static int Maior(int a, int b, int c)
            //{
            //    int maior;
            //    if (a > b && a > c)
            //    {
            //        maior = a;
            //    }
            //    else if (b > c)
            //    {
            //        maior = b;
            //    }
            //    else
            //    {
            //        maior = c;
            //    }

            //    return maior;
            //}

            //Console.WriteLine("Ditie um nmúmero: ");
            //double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //while (num1 >= 0.0)

            //{
            //    double raiz = Math.Sqrt(num1);
            //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            //    Console.Write("Digite outro número: ");
            //    num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //Console.WriteLine("Número negativo.");

            //Console.WriteLine("Digite a senha de 4 digitos correta para ter o acesso permitido: ");

            //int senha = int.Parse(Console.ReadLine());

            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha inválida.");
            //    senha  = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Senha correta, acesso permitido.");


            //Console.WriteLine("Digite o codigo de qual combustivbel deseja abastecer: 1 Alcool - 2 Gaolina - 3 Diesel");

            //int alcool = int.Parse(Console.ReadLine());
            //int gasolina = int.Parse(Console.ReadLine());
            //int diesel = int.Parse(Console.ReadLine());

            //int tipo = int.Parse(Console.ReadLine());

            //while(tipo != 4)
            //{
            //    if (tipo == 1)
            //    {
            //        alcool = alcool + 1;
            //    }
            //    else if (tipo == 2)
            //    {
            //        gasolina = gasolina + 1;
            //    }
            //    else
            //    {
            //        diesel = diesel + 1 ;
            //    }

            //    tipo = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Muito Obrigado !!");
            //Console.WriteLine("Alcool: " + alcool);
            //Console.WriteLine("Gasolina: " + gasolina);
            //Console.WriteLine("Diesel: " + diesel);

            //Console.Write("Quantos números inteiros você vai digitar ? ");
            //int num1 = int.Parse(Console.ReadLine());

            //int soma = 0;

            //for (int i = 1; i <= num1; i++)
            //{
            //Console.Write("Digite um valor #{0}: ", i);
            //int valor = int.Parse(Console.ReadLine());
            //soma += valor;
            //}

            //Console.WriteLine("Soma doa valores é de:  " + soma);

            //Console.WriteLine("Digite um valor intero para saber o número de valore impares entre ele: ");
            //int num1 = int.Parse(Console.ReadLine());

            //for(int i = 1;  i <= num1; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        Console.Write(i);
            //    }
            //}

            //Console.WriteLine("Digite um valor inteiro: ");
            //int num1 = int.Parse(Console.ReadLine());

            //int dentroIntervalo = 0;
            //int foraIntervalo = 0;

            //for(int i = 0; i < num1; i++)
            //{
            //    Console.WriteLine("Digite um valor: ");
            //    int valor = int.Parse(Console.ReadLine());

            //    if (valor >= 10.00  && valor <= 20.00)
            //    {
            //        dentroIntervalo += valor; 
            //    }
            //    else
            //    {
            //        foraIntervalo += valor;
            //    }

            //    Console.WriteLine("Foram digitados: " + dentroIntervalo + " numeros.");
            //    Console.WriteLine("Foram digitados: " + foraIntervalo + " numeros.");
            //}

            //Console.WriteLine("Digite um valor: ");
            //int num1 = int.Parse(Console.ReadLine());

            //for(int i = 0; i < num1; i++)
            //{
            //    string[] valor = Console.ReadLine().Split(' ');
            //    int num2 = int.Parse(valor[0]);
            //    int num3 = int.Parse(valor[1]);
            //    int num4 = int.Parse(valor[2]);

            //    double media = (num2 * 2 + num3 * 3 + num4 * 5) / 10;

            //    Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            //}

            //Console.WriteLine("Digite um número: ");
            //int num1 = int.Parse(Console.ReadLine());

            //for(int i = 0; i < num1; i++)
            //{
            //    string[] pares = Console.ReadLine().Split(' ');
            //    int num2 = int.Parse(pares[0]);
            //    int num3 = int.Parse(pares[1]);

            //    if (num3 == 0)
            //    {
            //        Console.WriteLine("Divisão impossível.");
            //    }
            //    else
            //    {
            //        double divisao = num2 / num3;
            //        Console.WriteLine(divisao~.ToString("F1", CultureInfo.InvariantCulture);
            //    }
            //}

            //Console.WriteLine("Digite um número: ");
            //int num1 = int.Parse(Console.ReadLine());

            //int fatorial = 1;

            //for(int i = 1; i <= num1; i++)
            //{
            //    fatorial = fatorial * i;
            //}

            //Console.WriteLine("Fatorial do número digitado é: " + fatorial);

            //Console.WriteLine("Digite um valor para sabermos seus divisores: ");
            //int num1 = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num1; i++)
            //{
            //    if (num1 % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("Digite um número: ");
            //int num1 = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= num1; i++)
            //{
            //    int primeiro = i;
            //    int segundo = i * i;
            //    int terceiro = i * i * i;

            //    Console.WriteLine(primeiro + ", " + segundo + ", " + terceiro);
            //}

            //Console.WriteLine("Digite numero para sabermos quantos números impares entre ele: ");
            //int num1 = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num1; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("Digite um valor: ");
            //int num1 = int.Parse(Console.ReadLine());

            //int dentroIntervalo = 0;
            //int foraIntervalo = 0;

            //for (int i = 0; i < num1; i++)
            //{
            //    Console.Write("Digite um número: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    if (num2 >= 10.00 && num2 <= 20.00)
            //    {
            //        dentroIntervalo++;
            //    }
            //    else
            //    {
            //        foraIntervalo++;
            //    }
            //}

            //Console.WriteLine("Os números digitados que estão dentro do intervalo são: " + dentroIntervalo);
            //Console.WriteLine("Os números digitados que estão fora do intervalo são: " + foraIntervalo);

            //Console.WriteLine("Digite um número: ");
            //int num1 = int.Parse(Console.ReadLine());

            //for (int i = 0; i < num1; i++)
            //{
            //    //Console.WriteLine("Digite o primeiro valor para sabermos se é possivel a divisão pelo segundo: ");
            //    string[] pares = Console.ReadLine().Split(' ');
            //    int num2 = int.Parse(pares[0]);
            //    int num3 = int.Parse(pares[1]);

            //    if (num3 == 0)
            //    {
            //        Console.WriteLine("Divisão impossível.");
            //    }
            //    else
            //    {
            //        double divisao = (double)num2 / num3;
            //        Console.WriteLine("O resultado da divisão é: " + divisao);
            //    }
            //}


            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    string[] line = Console.ReadLine().Split(' ');
            //    int x = int.Parse(line[0]);
            //    int y = int.Parse(line[1]);

            //    if (y == 0)
            //    {
            //        Console.WriteLine("divisao impossivel");
            //    }
            //    else
            //    {
            //        double div = (double)x / y;
            //        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
            //    }
            //}

            //Exercicios:

            //Pessoa p1, p2;
            //p1 = new Pessoa();
            //p2 = new Pessoa();

            //Console.WriteLine("Digite o nome e idade da primeira pessoa: ");
            //p1.Nome = Console.ReadLine();
            //p1.Idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o nome e idade da segunda pessoa: ");
            //p2.Nome = Console.ReadLine();
            //p2.Idade = int.Parse(Console.ReadLine());

            //if (p1.Idade > p2.Idade)
            //{
            //    Console.WriteLine("A pessoa mais velha é: " + p1.Nome);
            //}
            //else
            //{
            //    Console.WriteLine("A pessoa mais velha é: " + p2.Nome);
            //}

            //Pagamento f1, f2;
            //f1 = new Pagamento();
            //f2 = new Pagamento();

            //Console.WriteLine("Digite o nome e salario do primeiro funcionario: ");
            //f1.Nome = Console.ReadLine();
            //f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine();

            //Console.WriteLine("Digite o nome e salario do segundo funcionario: ");
            //f2.Nome = Console.ReadLine();
            //f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double mediaSalario = (f1.Salario + f2.Salario) / 2;

            //Console.WriteLine("Salario medio é de: " + mediaSalario.ToString("F4", CultureInfo.InvariantCulture));

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            
            double areaY = y.Area();

            Console.WriteLine("Valor da área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor da área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("A maior area é a área X");
            }
            else
            {
                Console.WriteLine("A maior área é a área Y");
            }

            Console.ReadKey();
        }
    }
}