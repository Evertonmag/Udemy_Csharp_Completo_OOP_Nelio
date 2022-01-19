using System.Globalization;

namespace PrimeirosExercicios;
internal class Program
{
    static void Main(string[] args)
    {
        // Exercicio01();
        // Exercicio02();
    }

    /// <summary>
    /// Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
    /// </summary>
    static void Exercicio01()
    {
        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa();

        Console.WriteLine("Dados da primeira pessoa: ");
        Console.Write("Nome: ");
        p1.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        p1.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados da Segunda pessoa: ");
        Console.Write("Nome: ");
        p2.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        p2.Idade = int.Parse(Console.ReadLine());

        if (p1.Idade > p2.Idade)
            Console.WriteLine($"Pessoa Mais Velha: {p1.Nome}");
        else if (p2.Idade > p1.Idade)
            Console.WriteLine($"Pessoa Mais Velha: {p2.Nome}");
        else
            Console.WriteLine("As duas pessoas possuem a mesma idade");

    }

    /// <summary>
    /// Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários
    /// </summary>
    static void Exercicio02()
    {
        Funcionarios f1 = new Funcionarios();
        Funcionarios f2 = new Funcionarios();

        Console.WriteLine("Dados do primeiro funcionário:");
        Console.Write("Nome: ");
        f1.Nome = Console.ReadLine();
        Console.Write("Salário: ");
        f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Dados do Segundo funcionário:");
        Console.Write("Nome: ");
        f2.Nome = Console.ReadLine();
        Console.Write("Salário: ");
        f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = (f1.Salario + f2.Salario) / 2;

        Console.WriteLine(FormattableString.Invariant($"O Salário médio é de: {media:F2}"));
    }
}

