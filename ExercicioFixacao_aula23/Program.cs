using System.Globalization;

namespace ExercicioFixacao_aula23;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com seu nome completo: ");
        string NomeCompleto = Console.ReadLine();
        Console.WriteLine("Quantos quartos tem na sua casa?");
        int qtdeQuartos = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o preço de um produto: ");
        double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Entre com seu ultimo nome, idade e altura (Mesma linha): ");
        string[] vet = Console.ReadLine().Split(' ');
        string LastName = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

        Console.WriteLine("\nVoce digitou: \n" +
                          NomeCompleto + "\n" +
                          qtdeQuartos + "\n" +
                          precoProduto.ToString(CultureInfo.InvariantCulture) + "\n" +
                          LastName + "\n" +
                          idade + "\n" +
                          altura.ToString(CultureInfo.InvariantCulture));
    }
}
