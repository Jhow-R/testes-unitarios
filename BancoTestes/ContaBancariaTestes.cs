using Banco;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoTestes
{
    [TestClass]
    public class ContaBancariaTestes
    {
        [TestMethod]
        public void Debito_ComValorValido_AtualizaSaldo()
        {
            double saldoInicial = 11.99;
            double valorDebito = 4.55;
            double saldoEsperado = 7.44;

            ContaBancaria conta = new ContaBancaria("Sr. Schwarzenegger", saldoInicial);
            conta.Debito(valorDebito);

            double saldoAtual = conta.Saldo;
            Assert.AreEqual(saldoEsperado, saldoAtual, 0.001, "Conta não foi debitada corretamente");
        }
    }
}
