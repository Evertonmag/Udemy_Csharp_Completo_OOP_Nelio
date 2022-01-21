using System;
using System.Globalization;

namespace Vetores;
internal class Program
{
    static void Main(string[] args)
    {
        //Exemplo01();
        //Exemplo02();
        ExercicioFixacao();
    }

    /// <summary>
    /// Fazer um programa para ler um numero inteiro N e a altura de N pessoas.
    /// Armazene as N alturas em um vetor. em seguida, mostrar a altura média 
    /// dessas pessoas. 
    /// </summary>
    static void Exemplo01()
    {
        int n = int.Parse(Console.ReadLine());

        double[] vect = new double[n];

        for (int i = 0; i < n; i++)
        {
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double sum = 0.0;
        for (int i = 0; i < n; i++)
        {
            sum += vect[i];
        }

        double avg = sum / n;

        Console.WriteLine($"AVERAGE HEIGHT = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    /// <summary>
    /// Fazer um programa para ler um numero inteiro N e os dados (nome e preço)
    /// de N produtos. Armazene os N produtos em um vetor. Em seguida, mostrar
    /// o preço medio dos produtos
    /// </summary>
    static void Exemplo02()
    {
        int n = int.Parse(Console.ReadLine());

        Product[] vect = new Product[n];

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vect[i] = new Product
            {
                Name = name,
                Price = price
            };
        }
        double sum = 0.0;

        for (int i = 0; i < n; i++)
        {
            sum += vect[i].Price;
        }

        double avg = sum / n;

        Console.WriteLine($"AVERAGE PRICE = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    /// <summary>
    /// A dona de um pensionato possui dez quartos para alugar para estudantes,
    /// sendo esses quartos identificados pelos números 0 a 9.<br/><br/>
    /// Fazer um programa que inicie com todos os dez quartos vazios, e depois 
    /// leia uma quantidade N representando o número de estudantes que vão alugar
    /// quartos (N pode ser de 1 a 10). Em seguida, registre o alugel dos N estudantes.
    /// para cada registro de alugel, informar o nome e email do estudante, bem como
    /// qual dos quartos ele escolheu (de 0 a 9). suponha que seja escolhido um quarto vago.
    /// Ao final, seu programa deve imprimir um relátorio de todas ocupações do pensionato, 
    /// por ordem de quarto, conforme exemplo.
    /// </summary>
    static void ExercicioFixacao()
    {
        Console.Write("How many rooms will be rented? ");
        int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Pensao[] vect = new Pensao[10];

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Rent #{i}");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("E-Mail: ");
            string email = Console.ReadLine();
            Console.Write("Room: ");
            int quarto = int.Parse(Console.ReadLine());

            vect[quarto] = new Pensao(nome, email);
        }

        for (int i = 0; i < 10; i++)
        {
            if (vect[i] != null)
            {
                Console.WriteLine($"{i}: {vect[i]}");
            }
        }

    }

}
