using System.Globalization;

namespace ExerciciosPropostos_parte4;
internal class Program
{
    static void Main(string[] args)
    {
        // Exercicio01();
        // Exercicio02();
        // Exercicio03();
        // Exercicio04();
        // Exercicio05();
        // Exercicio06();
        // Exercicio07();
    }

    /// <summary>
    /// Leia um valor inteiro X(1 <= X <= 1000).<br/>
    /// Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
    /// </summary>
    static void Exercicio01()
    {
        Console.WriteLine("Invorme um valor Inteiro: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    /// <summary>
    /// Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.<br/>
    /// Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo,<br/>
    /// mostrando essas informações conforme exemplo<br/>
    /// (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
    /// </summary>
    static void Exercicio02()
    {
        Console.WriteLine("Informe um numero: ");
        int n = int.Parse(Console.ReadLine());

        int contIn = 0;
        int contOut = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Informe um valor Inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 10 && x <= 20)
                contIn++;
            else
                contOut++;
        }

        Console.WriteLine($"{contIn} in");
        Console.WriteLine($"{contOut} out");
    }

    /// <summary>
    /// Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir.<br/>
    /// Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.<br/>
    /// Apresente a média ponderada para cada um destes conjuntos de 3 valores, <br/>
    /// sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5
    /// </summary>
    static void Exercicio03()
    {
        Console.WriteLine("Informe um numero: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Informe tres valores: ");
            string[] vet = Console.ReadLine().Split(' ');

            double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }

    /// <summary>
    /// Fazer um programa para ler um número N.<br/>
    /// Depois leia N pares de números e mostre a divisão do primeiro pelo segundo.<br/>
    /// Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel"
    /// </summary>
    static void Exercicio04()
    {
        Console.WriteLine("Informe um numero: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Informe dois valores: ");
            string[] vet = Console.ReadLine().Split(' ');

            double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if(n2 == 0)
                Console.WriteLine("Divisão impossivel");
            else
            {
                double resultado = n1 / n2;
                Console.WriteLine(resultado.ToString(CultureInfo.InvariantCulture));
            }
        }
    }

    /// <summary>
    /// Ler um valor N. Calcular e escrever seu respectivo fatorial.<br/>
    /// Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.<br/>
    /// Lembrando que, por definição, fatorial de 0 é 1.
    /// </summary>
    static void Exercicio05()
    {
        Console.WriteLine("Informe um numero: ");
        int n = int.Parse(Console.ReadLine());
        int fatorial = 1;
        
        for (int i = 1; i < n; n--)
        {
            Console.Write(n + " * ");
            fatorial *= n;
        }
        Console.Write($"1 = {fatorial}");
    }

    /// <summary>
    /// Ler um número inteiro N e calcular todos os seus divisores.
    /// </summary>
    static void Exercicio06()
    {
        Console.WriteLine("Informe um numero: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                Console.WriteLine(i);
        }
    }

    /// <summary>
    /// Fazer um programa para ler um número inteiro positivo N.<br/>
    /// O programa deve então mostrar na tela N linhas, começando de 1 até N.<br/>
    /// Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.
    /// </summary>
    static void Exercicio07()
    {
        Console.WriteLine("Informe um numero: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int primeiro = i;
            int segundo = i * i;
            int terceiro = i * i * i;
            Console.WriteLine($"{primeiro} {segundo} {terceiro}");
        }
    }
}

