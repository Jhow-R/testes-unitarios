using Banco;
using Xunit;

namespace xUnitTestes
{
    public class ContaBancariaTestes
    {
        [Fact]
        public void Debito_ComValorValido_AtualizaSaldo()
        {
            double saldoInicial = 11.99;
            double valorDebito = 4.55;
            double saldoEsperado = 7.44;

            ContaBancaria conta = new ContaBancaria("Sr. Schwarzenegger", saldoInicial);
            conta.Debito(valorDebito);

            double saldoAtual = conta.Saldo;
            Assert.Equal(saldoEsperado, saldoAtual);
        }
    }
}
