using Xunit;

namespace xUnitTestes
{
    public class CalculadoraTestes
    {
        [Fact]
        public void Somar()
        {
            int n1 = 2;
            int n2 = 3;

            int resultadoEsperado = n1 + n2;

            Assert.Equal(resultadoEsperado, Calculadora.Somar(n1, n2));
        }
    }
}
