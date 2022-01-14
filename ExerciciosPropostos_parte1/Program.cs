using System.Globalization;

namespace ExerciciosPropostos_parte1;
internal class Program
{
    static void Main(string[] args)
    {
        //Exercicio01();
        //Exercicio02();
        //Exercicio03();
        //Exercicio04();
        //Exercicio05();
        //Exercicio06();
    }

    static void Exercicio01()
    {
        /*
        Faça um programa para ler dois valores inteiros,
        e depois mostrar na tela a soma desses números com uma mensagem explicativa,
        conforme exemplos.
        */

        Console.WriteLine("Informe o primeiro valor Inteiro: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o Segundo valor Inteiro: ");
        int n2 = int.Parse(Console.ReadLine());

        int soma = n1 + n2;

        Console.WriteLine($"Soma = {soma}");
    }
    static void Exercicio02()
    {
        /*
        Faça um programa para ler o valor do raio de um círculo,
        e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.

        Fórmula da área: area = π.raio^2
        Considere o valor de π = 3.14159
        */

        Console.WriteLine("Informe o raio de um circulo: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double area = 3.14159 * (raio * raio);

        Console.WriteLine($"O valor da area desse circulo é de: {area.ToString("F4", CultureInfo.InvariantCulture)}");
    }
    static void Exercicio03()
    {
        /*
        Fazer um programa para ler quatro valores inteiros A, B, C e D.
        A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D
        segundo a fórmula: DIFERENCA = (A * B ) - (C * D).
        */

        Console.WriteLine("Informe o primeiro valor inteiro: ");
        int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor inteiro: ");
        int B = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o terceiro valor inteiro: ");
        int C = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o quarto valor inteiro: ");
        int D = int.Parse(Console.ReadLine());

        int DIFERENCA = (A * B) - (C * D);

        Console.WriteLine(DIFERENCA);
    }
    static void Exercicio04()
    {
        /*
        Fazer um programa que leia o número de um funcionário,
        seu número de horas trabalhadas,
        o valor que recebe por hora e calcula o salário desse funcionário.
        A seguir, mostre o número e o salário do funcionário, com duas casas decimais
        */

        Console.WriteLine("Informe o numero do funcionário: ");
        int numFuncionario = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
        int qtdeNumHoras = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor recebido por hora trabalhada: ");
        double vlrHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salario = qtdeNumHoras * vlrHoras;

        Console.WriteLine($"Number = {numFuncionario} \n" +
                          $"Salary = U${salario.ToString("F2", CultureInfo.InvariantCulture)}");
    }
    static void Exercicio05()
    {
        /*
        Fazer um programa para ler o código de uma peça 1,
        o número de peças 1,
        o valor unitário de cada peça 1,
        o código de uma peça 2,
        o número de peças 2 e o valor unitário de cada peça 2.
        Calcule e mostre o valor a ser pago.
        */

        Console.WriteLine("Informe o codigo da peça 1, a quantidade de pecas 1, o valor unitário da peça 1 (Mesma linha): ");
        string[] vet1 = Console.ReadLine().Split(' ');
        int codigopeca1 = int.Parse(vet1[0]);
        int qtdepeca1 = int.Parse(vet1[1]);
        double valorunidade1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

        Console.WriteLine("Informe o codigo da peça 2, a quantidade de pecas 2, o valor unitário da peça 2 (Mesma linha): ");
        string[] vet2 = Console.ReadLine().Split(' ');
        int codigopeca2 = int.Parse(vet2[0]);
        int qtdepeca2 = int.Parse(vet2[1]);
        double valorunidade2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

        double total = (qtdepeca1 * valorunidade1) + (qtdepeca2 * valorunidade2);

        Console.WriteLine($"Valor a pagar: {total:C}");

    }
    static void Exercicio06()
    {
        /*
        Fazer um programa que leia três valores
        com ponto flutuante de dupla precisão: A, B e C.
        Em seguida, calcule emostre: 

        a) a área do triângulo retângulo que tem A por base e C por altura. 
        b) a área do círculo de raio C. (pi = 3.14159)
        c) a área do trapézio que tem A e B por bases e C por altura.
        d) a área do quadrado que tem lado B. 
        e) a área do retângulo que tem lados A e B
        */

        Console.WriteLine("Informe o valor de A, B e C respectivamente:");
        string[] vet = Console.ReadLine().Split(' ');

        double A = double.Parse(vet[0], CultureInfo.InvariantCulture);

        double B = double.Parse(vet[1], CultureInfo.InvariantCulture);

        double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

        double areaTriangulo = A * C / 2;
        double areaCirculo = 3.14159 * (C * C);
        double areaTrapezio = (A + B) * C / 2;
        double areaQuadrado = B * B;
        double areaRetangulo = B * A;

        Console.WriteLine(($"Triangulo: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                          $"Circulo: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                          $"Trapézio: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                          $"Quadrado: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                          $"Retangulo: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}"));
    }

}