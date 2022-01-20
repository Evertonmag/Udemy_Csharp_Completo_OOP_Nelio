using System;

namespace ExercicioDeFixacao;
internal class ContaBancaria
{
    public int Numero { get; private set; }
    public string Titular { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(int numero, string titular)
    {
        Numero = numero;
        Titular = titular;
    }
    public ContaBancaria(int numero, string titular, double depositoIni) : this(numero, titular) => Deposito(depositoIni);

    public void Deposito(double deposito) => Saldo += deposito;

    public void Saque(double saque) => Saldo -= saque + 5;

    public override string ToString() => FormattableString.Invariant($"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo:F2}");
}
