using System.Globalization;

namespace ExerciciosPropostos_parte4;
internal class Program
{
    static void Main(string[] args)
    {
        // Exercicio01();
         Exercicio02();
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
        int vlr = int.Parse(Console.ReadLine());

        for (int i = 1; i <= vlr; i += 2)
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
        Console.WriteLine("Invorme um valor Inteiro: ");
        int vlr = int.Parse(Console.ReadLine());

    }

}

