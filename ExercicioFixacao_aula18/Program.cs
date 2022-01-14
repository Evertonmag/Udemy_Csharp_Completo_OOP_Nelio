using System.Globalization;

namespace ExercicioFixacao_aula18;
internal class Program
{
    static void Main(string[] args)
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produtos:");
        Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
        Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
        Console.WriteLine($"\nRegsitro: {idade} anos de idade, código {codigo} e gênero: {genero}");
        Console.WriteLine($"\nMedida com oito casas decimais: {medida:F8}");
        Console.WriteLine($"Arredondado tres casas decimais: {medida:F3}");
        Console.WriteLine("Separador decimal invariantCulture (Tostring): " + medida.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine(FormattableString.Invariant($"Separador decimal invariantCulture (FormattableString): {medida:F3}"));

        // Utilizando somente um Console.WriteLine

        Console.WriteLine("Produtos:\n" +
                          $"{produto1}, cujo preço é $ {preco1:F2}\n" +
                          $"{produto2}, cujo preço é $ {preco2:F2}\n" +
                          $"\nRegsitro: {idade} anos de idade, código {codigo} e gênero: {genero}\n" +
                          $"\nMedida com oito casas decimais: {medida:F8}\n" +
                          $"Arredondado tres casas decimais: {medida:F3}\n" +
                          "Separador decimal invariantCulture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
    }
}