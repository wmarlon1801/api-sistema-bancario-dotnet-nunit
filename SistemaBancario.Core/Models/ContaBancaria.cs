namespace SistemaBancario.Core.Models;

public class ContaBancaria
{
    public string Titular { get; set; }
    public decimal Saldo { get; private set; }

    public ContaBancaria(string titular, decimal saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor > Saldo)
            throw new InvalidOperationException("Saldo insuficiente.");

        Saldo -= valor;
    }
}
