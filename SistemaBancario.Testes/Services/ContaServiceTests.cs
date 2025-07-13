using NUnit.Framework;
using SistemaBancario.Core.Services;

namespace SistemaBancario.Testes.Services
{
    public class ContaServiceTests
    {
        private ContaService _service;

        [SetUp]
        public void Setup()
        {
            _service = new ContaService("Teste", 0); // Começa com saldo 0
        }

        [Test]
        public void ConsultarSaldo_DeveRetornarZeroInicialmente()
        {
            var saldo = _service.ConsultarSaldo();
            Assert.AreEqual(0, saldo);
        }

        [Test]
        public void Depositar_DeveAumentarSaldo()
        {
            _service.Depositar(200);
            var saldo = _service.ConsultarSaldo();
            Assert.AreEqual(200, saldo);
        }

        [Test]
        public void Sacar_DeveDiminuirSaldo()
        {
            _service.Depositar(300);
            _service.Sacar(100);
            var saldo = _service.ConsultarSaldo();
            Assert.AreEqual(200, saldo);
        }

        [Test]
        public void Sacar_ComSaldoInsuficiente_DeveLancarExcecao()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                _service.Sacar(100); // Vai falhar porque saldo é 0
            });
        }
    }
}
