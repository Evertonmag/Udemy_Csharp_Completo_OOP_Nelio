using System.Globalization;

namespace ExerciciosPropostosParte1;
internal class Program
{
    static void Main(string[] args)
    {
        //Exercicio01();
        //Exercicio02();
        //Exercicio03();
    }

    /// <summary>
    /// Fazer um programa para ler os valores da largura e altura de um retangulo.<br/>
    /// Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.<br/>
    /// Usar uma classe como projeto ao lado.
    /// </summary>
    static void Exercicio01()
    {
        Retangulo r = new Retangulo();

        Console.WriteLine("Entre a largura e altura do retângulo: ");
        r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        Console.WriteLine($"Area = {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Perimetro = {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Diagonal = {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

    }

    /// <summary>
    /// Fazer um programa para ler os dados de um funcionário (nome, 
    /// salário bruto e imposto).<br/> Em seguida, mostrar os dados do 
    /// funcionário(nome e salário líquido).<br/> Em seguida, aumentar o salário 
    /// do funcionário com base em uma porcentagem dada(somente o
    /// salário bruto é afetado pela porcentagem) e mostrar novamente os
    /// dados do funcionário. Use a classe projetada abaixo.
    /// </summary>
    static void Exercicio02()
    {
        Funcionario f = new Funcionario();

        Console.Write("Nome: ");
        f.Nome = Console.ReadLine();
        Console.Write("Salário Bruto: ");
        f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine($"Funcionario: {f}");


        Console.WriteLine();
        Console.Write("Deseja aumentar o salário em qual porcentagem? ");
        double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        f.AumentarSalario(porcent);

        Console.WriteLine();
        Console.WriteLine($"Dados atualizados: {f}");
    }

    /// <summary>
    /// Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
    /// (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
    /// ano.Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
    /// para o aluno obter o mínimo para ser aprovado(que é 60 pontos). Você deve criar uma classe Aluno para resolver
    /// este problema.
    /// </summary>
    static void Exercicio03()
    {
        Aluno Aluno = new Aluno();

        Console.Write("Nome do aluno: ");
        Aluno.Nome = Console.ReadLine();
        Console.WriteLine("Digite as três notas do aluno:");
        Aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Nota Final = " + Aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

        if (Aluno.Aprovado())
            Console.WriteLine("APROVADO");
        else
        {
            Console.WriteLine("REPROVADO");
            Console.WriteLine("FALTARAM " + 
                              Aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) +
                              " Pontos");
        }
    }
}
