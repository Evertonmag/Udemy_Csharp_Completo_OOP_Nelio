using System;
using System.Collections.Generic;
using System.Globalization;

namespace Matrizes;
internal class Program
{
    static void Main(string[] args)
    {
        //Exemplo01();
        //Exemplo02();
        Exercicio01();
    }

    static void Exemplo01()
    {
        double[,] mat = new double[2, 3];

        Console.WriteLine(mat.Length);

        Console.WriteLine(mat.Rank);

        Console.WriteLine(mat.GetLength(0));

        Console.WriteLine(mat.GetLength(1));
    }

    /// <summary>
    /// Fazer um programa para ler um numero inteiro N e uma matriz de ordem N contendo números inteiros.
    /// Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.
    /// </summary>
    static void Exemplo02()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(values[j]);
            }
        }

        Console.WriteLine("Main Diagonal: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(mat[i, i] + " ");
        }
        Console.WriteLine();

        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i, j] < 0)
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"Negative number {count}");
    }

    /// <summary>
    /// Fazer um programa para ler dois números inteiros M e N, e depois ler
    /// uma matriz de M linhas por N colunas contendo números inteiros,
    /// podendo haver repetições.Em seguida, ler um número inteiro X que
    /// pertence à matriz.Para cada ocorrência de X, mostrar os valores à
    /// esquerda, acima, à direita e abaixo de X, quando houver, conforme
    /// exemplo.
    /// </summary>
    static void Exercicio01()
    {
        Console.WriteLine("Informe 2 valores para o tamanho da matriz (Linhas / Colunas): ");
        string[] vet = Console.ReadLine().Split(' ');

        int m = int.Parse(vet[0]);
        int n = int.Parse(vet[1]);

        int[,] mat = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            string[] values = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(values[j]);
            }
        }

        Console.Write("Informe um valor Inteiro que tenha na matriz: ");
        int pesquisa = int.Parse(Console.ReadLine());

        for (int linha = 0; linha < m; linha++)
        {
            for (int coluna = 0; coluna < n; coluna++)
            {
                if (mat[linha, coluna] == pesquisa)
                {
                    Console.WriteLine($"Posição: {linha}, {coluna}:");
                    if (coluna > 0)
                    {
                        Console.WriteLine($"Esquerda: {mat[linha, coluna - 1]}");
                    }
                    if (linha > 0)
                    {
                        Console.WriteLine($"Emcima: {mat[linha - 1, coluna]}");
                    }
                    if (coluna < n - 1)
                    {
                        Console.WriteLine($"Direita: {mat[linha, coluna + 1]}");
                    }
                    if (linha < m - 1)
                    {
                        Console.WriteLine($"Embaixo: {mat[linha + 1, coluna]}");
                    }
                }
            }
        }
    }
}

