using System.Globalization;

namespace ExerciciosPropostos_parte2;
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
        //Exercicio07();
        //Exercicio08();
    }

    static void Exercicio01()
    {
        /*
        Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
        */

        Console.WriteLine("Informe um numero inteiro: ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 0)
            Console.WriteLine($"O numero {num} é Positivo");
        else
            Console.WriteLine($"O numero {num} é Negativo");
    }
    static void Exercicio02()
    {
        /*
        Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar
        */

        Console.WriteLine("Informe um numero inteiro: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine($"O numero {num} é par");
        else
            Console.WriteLine($"O numero {num} é impar");
    }
    static void Exercicio03()
    {
        /*
        Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem
        "Sao Multiplos" ou "Nao sao Multiplos",
        indicando se os valores lidos são múltiplos entre si.
        Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.
        */

        Console.WriteLine("Informe um numero inteiro: ");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe outro numero inteiro: ");
        int B = int.Parse(Console.ReadLine());

        if (A % B == 0 || B % A == 0)
            Console.WriteLine($"Os numeros {A} e {B}. São Multiplos");
        else
            Console.WriteLine($"Os numeros {A} e {B}. Não são Multiplos");
    }
    static void Exercicio04()
    {
        /*
        Leia a hora inicial e a hora final de um jogo.
        A seguir calcule a duração do jogo,
        sabendo que o mesmo pode começar em um dia e terminar em outro,
        tendo uma duração mínima de 1 hora e máxima de 24 horas.
        */

        Console.WriteLine("Informe a hora inicial (somente hora): ");
        int horaini = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a hora final (somente hora): ");
        int horafim = int.Parse(Console.ReadLine());

        int tempoJogo = 0;

        if (horaini < horafim)
            tempoJogo = horafim - horaini;
        else
            tempoJogo = 24 - horaini + horafim;

        Console.WriteLine($"O jogo durou {tempoJogo} Hora(s)");
    }
    static void Exercicio05()
    {
        /*
        Com base na tabela abaixo,
        escreva um programa que leia o código de um item e a quantidade deste item.
        A seguir, calcule e mostre o valor da conta a pagar. 
        ____________________________________________
        |Codigo      | Especificacao     | Preço   |
        |------------------------------------------|
        |1           | Cachorro-quente   | R$ 4,00 |
        |2           | X-salada          | R$ 4,50 |
        |3           | X-Bacom           | R$ 5,00 |
        |4           | Torrada simples   | R$ 2,00 |
        |5           | Refrigerante      | R$ 1,50 |
        --------------------------------------------
        */

        Console.WriteLine("Informe o código e a quatidade do item (Respectivamante): ");
        string[] vet = Console.ReadLine().Split(' ');

        int codigo = int.Parse(vet[0]);
        double qtde = int.Parse(vet[1]);

        double total = 0;

        switch (codigo)
        {
            case 1:
                total = qtde * 4.0;
                Console.WriteLine($"O pedido escolhido foi {qtde} Cachorro-quente e o valor total é de: {total:C}");
                break;
            case 2:
                total = qtde * 4.5;
                Console.WriteLine($"O pedido escolhido foi {qtde} X-salada e o valor total é de: {total:C}");
                break;
            case 3:
                total = qtde * 5.0;
                Console.WriteLine($"O pedido escolhido foi {qtde} X-Bacom e o valor total é de: {total:C}");
                break;
            case 4:
                total = qtde * 2.00;
                Console.WriteLine($"O pedido escolhido foi {qtde} Torrada simples e o valor total é de: {total:C}");
                break;
            case 5:
                total = qtde * 1.50;
                Console.WriteLine($"O pedido escolhido foi {qtde} Refrigerante e o valor total é de: {total:C}");
                break;
        }
    }
    static void Exercicio06()
    {
        /*
        Você deve fazer um programa que leia um valor qualquer
        e apresente uma mensagem dizendo em qual dos seguintes intervalos
        ([0,25], (25,50], (50,75], (75,100]) este valor se encontra.
        Obviamente se o valor não estiver em nenhum destes intervalos,
        deverá ser impressa a mensagem “Fora de intervalo”. 
        */

        Console.WriteLine("informe um valor: ");
        double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (num >= 0 && num <= 25)
            Console.WriteLine($"O numero {num} está entre o intervalo [0, 25]");
        else if(num >= 25 && num <= 50)
            Console.WriteLine($"O numero {num} está entre o intervalo [25, 50]");
        else if (num >= 50 && num <= 75)
            Console.WriteLine($"O numero {num} está entre o intervalo [50, 75]");
        else if (num >= 75 && num <= 100)
            Console.WriteLine($"O numero {num} está entre o intervalo [75, 100]");
        else
            Console.WriteLine($"O numero {num} está fora dos intervalos propostos");
    }
    static void Exercicio07()
    {
        /*
        Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
        de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
        ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
        Se o ponto estiver na origem, escreva a mensagem “Origem”.
        Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação. 
        */
        Console.WriteLine("Informe dois pontos cartesianos: ");
        string[] valores = Console.ReadLine().Split(' ');
        double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

        if (x == 0.0 && y == 0.0)
        {
            Console.WriteLine("Origem");
        }
        else if (x == 0.0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (y == 0.0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (x > 0.0 && y > 0.0)
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
    }
    static void Exercicio08()
    {
        /*
        Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos,
        pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados
        em benefício da população, sem qualquer desvio. A moeda deste país é o Rombus,
        cujo símbolo é o R$. Leia um valor com duas casas decimais,
        equivalente ao salário de uma pessoa de Lisarb.
        
        Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda,
        segundo a tabela abaixo.

        ___________________________________________________
        |            Renda             | Imposto de Renda |
        |de 0,00 a R$ 2000,00          |       Isento     |
        |de R$ 2000,01 até R$ 3000,00  |         8%       |
        |de R$ 3000,01 até R$ 4500,00  |        18%       |
        |Acima de R$ 4500,00           |        28%       |
        ---------------------------------------------------

        Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00,
        pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.
        No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00,
        o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais.
        */

        Console.WriteLine("Informe com a cultura Brasileira (, = separador)" +
            "\nInforme o seu salario: ");
        double salario = double.Parse(Console.ReadLine());

        double imposto = 0.00;

        if (salario > 0.00 && salario <= 2000.00)
            imposto = 0.00;
        else if (salario <= 3000.00)
            imposto = (salario - 2000.0) * 0.08;
        else if (salario <= 4500.0)
            imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
        else
            imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;

        if (imposto == 0.00)
            Console.WriteLine("A pesssoa não precisa pagar o imposto pois ela está ISENTA.");
        else
            Console.WriteLine($"O imposto que essa pessoa deverá pagar é de: {imposto:C}");


    }
}
