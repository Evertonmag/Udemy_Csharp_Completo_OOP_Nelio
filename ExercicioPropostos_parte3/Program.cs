using System.Globalization;

namespace ExerciciosPropostos_parte3;
internal class Program
{
    static void Main(string[] args)
    {
        // Exercicio01();
        // Exercicio02();
        // Exercicio03();
    }

    /// <summary>
    /// Escreva um programa que repita a leitura de uma senha até que ela seja valida.<br/>
    /// Para cadaleitura de senha incorreta informada escrever a mensagem "Senha Invalida".<br/>
    /// Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.<br/>
    /// Considare a senha correta é o valor 2002.
    /// </summary>
    static void Exercicio01()
    {
        Console.Write("Informe a Senha: ");
        int senha = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

        while (senha != 2002)
        {
            Console.WriteLine("Senha invalida");

            Console.Write("Informe a Senha: ");
            senha = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
        }

        Console.WriteLine("Acesso Permitido!");

    }

    /// <summary>
    /// Escreva um programa para ler as coordenadas(X, Y) de uma quantidade indeterminada de pontos no sistemacartesiano.<br/>
    /// Para cada ponto escrever o quadrante a que ele pertence.<br/>
    /// O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
    /// </summary>
    static void Exercicio02()
    {
        Console.WriteLine("Informe dois pontos cartesianos: ");
        string[] valores = Console.ReadLine().Split(' ');
        double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

        while (x != 0.0 && y != 0.0)
        {
            if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            Console.WriteLine("Informe dois pontos cartesianos: ");
            valores = Console.ReadLine().Split(' ');
            x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y = double.Parse(valores[1], CultureInfo.InvariantCulture);
        }
    }


    /// <summary>
    /// Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.<br/>
    /// Escreva um algoritmo para ler o tipo de combustível abastecido<br/>
    /// (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim).<br/>
    /// Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
    /// que seja válido). O programa será encerrado quando o código informado for o número 4.<br/>
    /// Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada
    /// tipo de combustível, conforme exemplo.
    /// </summary>
    static void Exercicio03()
    {
        int alcool = 0, gasolina = 0, diesel = 0;

        Console.WriteLine("Informe o tipo de combustivel utilizado (1.Álcool, 2.Gasolina, 3.Diesel, 4.Fim)");
        int tipoCombustivel = int.Parse(Console.ReadLine());

        while (tipoCombustivel != 4)
        {
            if (tipoCombustivel == 1)
                alcool++;
            else if (tipoCombustivel == 2)
                gasolina++;
            else if (tipoCombustivel == 3)
                diesel++;

            Console.WriteLine("Informe o tipo de combustivel utilizado (1.Álcool, 2.Gasolina, 3.Diesel, 4.Fim)");
            tipoCombustivel = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"MUITO OBRIGADO!\n" +
                          $"Álcool = {alcool}\n" +
                          $"Gasolina = {gasolina}\n" +
                          $"Diesel = {diesel}\n");
    }

}
