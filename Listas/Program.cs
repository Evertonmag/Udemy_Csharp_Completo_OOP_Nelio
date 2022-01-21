using System;
using System.Collections.Generic;
using System.Globalization;

namespace Listas;
internal class Program
{
    static void Main(string[] args)
    {
        //Exemplo01();
        Exercicio01();
    }

    static void Exemplo01()
    {
        List<string> list = new List<string>();

        list.Add("Maria");
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Anna");
        list.Insert(2, "Marco");

        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine($"List count: {list.Count}");

        string s1 = list.Find(x => x[0] == 'A');
        Console.WriteLine($"First 'A': {s1}");

        string s2 = list.FindLast(x => x[0] == 'A');
        Console.WriteLine($"Last 'A': {s2}");

        int pos1 = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine($"First Position 'A': {pos1}");

        int pos2 = list.FindLastIndex(x => x[0] == 'A');
        Console.WriteLine($"Last Position 'A': {pos2}");

        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");

        List<string> list2 = list.FindAll(x => x.Length == 5);
        foreach (string obj in list2)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");

        list.Remove("Alex");
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("-+-+-+-+-+-+-+-+-+-");
        list.RemoveAll(x => x[0] == 'M');
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("-+-+-+-+-+-+-+-+-+-");
        list.RemoveAt(1);
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("-+-+-+-+-+-+-+-+-+-");
        Console.WriteLine("Voltando a lista!");
        list.Insert(0, "Maria");
        list.Insert(2, "Marco");
        list.Insert(1, "Alex");
        list.Insert(4, "Anna");

        Console.WriteLine("-+-+-+-+-+-+-+-+-+-");
        list.RemoveRange(2, 2);
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("-+-+-+-+-+-+-+-+-+-");
        Console.WriteLine("Voltando a lista!");

        list.Insert(2, "Marco");
        list.Insert(3, "Bob");

        Console.WriteLine("-+-+-+-+-+-+-+-+-+-");

        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
    }

    /// <summary>
    /// Fazer um programa para ler um número inteiro N e depois os dados(id, nome e salario) de
    /// N funcionários.Não deve haver repetição de id.<br/><br/>
    /// Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
    /// Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
    /// mensagem e abortar a operação.Ao final, mostrar a listagem atualizada dos funcionários,
    /// conforme exemplos.<br/><br/>
    /// Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
    /// ser mudado livremente.Um salário só pode ser aumentado com base em uma operação de
    /// aumento por porcentagem dada.
    /// </summary>
    static void Exercicio01()
    {

        List<Employee> list = new List<Employee>();

        Console.Write("How many employees will be registred? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Employee #{i}");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Employee testeId = list.Find(x => x.Id == id);
            if (testeId != null)
            {
                Console.WriteLine("O id Informado Já existe");
                i--;
            }
            else
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salario));
            }
        }

        Console.Write("\nEnter the employee id that will have salary increase: ");
        int searchId = int.Parse(Console.ReadLine());

        Employee employee = list.Find(x => x.Id == searchId);

        if (employee != null)
        {
            Console.Write("Enter the percentage: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.increaseSalary(percent);
        }
        else
            Console.WriteLine("This id does not exist! ");

        Console.WriteLine("\nUpdated list of employees: ");

        foreach (Employee obj in list)
            Console.WriteLine(obj);
        

    }
}

