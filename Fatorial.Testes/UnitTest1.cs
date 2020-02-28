using System;
using Xunit;

namespace Fatorial.Testes
{
    public class UnitTest1
    {
        [Fact]
        public void Nao_Devera_Aceitar_Negativo()
        {
            var calculo = new Calculo();
            Assert.Throws<ArgumentException>(() => calculo.CalcularFatorial(-1));
        }

        [Fact]
        public void Nao_Devera_Aceitar_1()
        {
            var calculo = new Calculo();
            Assert.Equal(1, calculo.CalcularFatorial(0));
        }

        [Theory]
        [InlineData(5)]
        public void Calcular_Fatorial_5(int numero)
        {
            var calculo = new Calculo();
            Assert.Equal(120, calculo.CalcularFatorial(numero));
        }
    }
}
