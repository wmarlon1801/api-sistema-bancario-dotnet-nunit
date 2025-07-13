using SistemaBancario.Core.Models;

namespace SistemaBancario.Core.Services;

public class ContaService
{
    private ContaBancaria _conta;

    public ContaService(string nome, decimal saldoInicial)
    {
        _conta = new ContaBancaria(nome, saldoInicial);
    }

    public decimal ConsultarSaldo() => _conta.Saldo;
    public void Depositar(decimal valor) => _conta.Depositar(valor);
    public void Sacar(decimal valor) => _conta.Sacar(valor);
}

