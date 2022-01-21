using System;
using System.Globalization;

namespace Params;
internal class Program
{
    static void Main(string[] args)
    {
        //Exemplo01();
        //Exemplo02();
        //Exemplo03();
        //Exemplo04();
    }

    #region Params
    static void Exemplo01()
    {
        int s1 = Calculator.Sum(2, 3 );
        int s2 = Calculator.Sum(2, 4, 3 );

        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
    #endregion

    #region Modificadores
    //ref
    static void Exemplo02()
    {
        int a = 10;

        Calculator.Triple(ref a);
        Console.WriteLine(a);
    }

    //out
    static void Exemplo03()
    {
        int a = 10;
        int triple;
        Calculator.TripleOut(a, out triple);
        Console.WriteLine(triple);
    }
    #endregion

    #region Laco For Each
    static void Exemplo04()
    {
        string[] vect = new string[] { "Maria", "Alex", "Bob" };

        for (int i = 0; i < vect.Length; i++)
        {
            Console.WriteLine(vect[i]);
        }

        Console.WriteLine("-----------------------------");

        foreach (string obj in vect)
        {
            Console.WriteLine(obj);
        }
    }
    #endregion
}

